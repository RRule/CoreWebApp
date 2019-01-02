using System;
using System.Text.RegularExpressions;

namespace CoreWebApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string ProductUrl { get; set; }
        public string ImageUrl { get; set; }
        private string articlecode { get; set; }
        public string ArticleCode
        {
            get => articlecode;

            set
            {
                var regex = new Regex("^\\d{5}[A-Z]{3}$");
                var success = regex.Match(value);
                if (success.Success)
                {
                    articlecode = value;
                }
                else
                {
                    throw new Exception("Invalid article code");
                }
            }
        }

        public Product()
        {
            ArticleCode = "00001ABC";
        }
    }
}
