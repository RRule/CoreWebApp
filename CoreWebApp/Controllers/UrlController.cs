using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreWebApp.Controllers
{
    public class UrlController : Controller
    {
        public class UrlModel
        {
            public string Url { get; set; }

            public List<ListItem> UrlList { get; set; }

            public UrlModel()
            {
                UrlList = new List<ListItem>();
            }

            public void ScrapeUrl()
            {
                var web = new HtmlWeb();
                web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
                var doc = web.Load(Url);
                if (doc != null)
                {
                    var nodes = doc.DocumentNode.SelectNodes("//a[@href]");
                    if (nodes != null)
                    {
                        foreach (var node in nodes)
                        {
                            if (!node.OuterHtml.Contains("<svg"))
                            {
                                UrlList.Add(new ListItem(node.OuterHtml, Url));
                            }
                        }
                    }
                }
            }
        }

        public class ListItem
        {
            public int ID { get; set; }
            public string ItemUrl { get; set; }
            public string Domain { get; set; }
            public string InnerHtml { get; set; }
            public string Type { get; set; }
            public string ImageUrl { get; set; }
            public bool ContainsImage { get; set; }
            public string Target { get; set; }
            public string OriginalUrl { get; set; }
            public ListItem(string url, string host)
            {
                OriginalUrl = url;

                var doc = new HtmlDocument();
                doc.LoadHtml(url);
                var nodes = doc.DocumentNode.SelectNodes("//a[@href]");
                if (nodes != null)
                {
                    foreach (var node in nodes)
                    {
                        ContainsImage = false;
                        ItemUrl = node.Attributes["href"]?.Value ?? "";
                        InnerHtml = node.InnerHtml ?? "";
                        Target = node.Attributes["target"]?.Value ?? "";
                        bool result = Uri.TryCreate(ItemUrl, UriKind.Absolute, out Uri uriResult);
                        if (result)
                        {
                            Domain = uriResult.Scheme + "://" + uriResult.Host;
                        }
                        else
                        {
                            Domain = host;
                        }

                        if (InnerHtml.Contains("src="))
                        {
                            ContainsImage = true;
                            var imagedoc = new HtmlDocument();
                            imagedoc.LoadHtml(InnerHtml);
                            var imageNode = imagedoc.DocumentNode.SelectNodes("//img[@src]").FirstOrDefault();
                            if (imageNode != null)
                            {
                                ImageUrl = imageNode.OuterHtml;
                            }
                        }

                    }

                }
            }
        }

        public IActionResult Index(string url)
        {
            var model = new UrlModel
            {
                Url = url ?? ""
            };

            if (string.IsNullOrEmpty(url))
            {
                return View(model);
            }

            model.ScrapeUrl();
            return View(model);
        }
    }
}