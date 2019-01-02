using System.Collections.Generic;

namespace CoreWebApp.Models
{
    public class ProductViewModel
    {
        public string searchstring { get; set; }
        public bool IsList { get; set; }
        public List<Product> Products { get; set; }

        public ProductViewModel()
        {
            Products = new List<Product>();
            Products.Add(new Product()
            {
                Name = "Prod 1"
            });
            Products.Add(new Product()
            {
                Name = "Prod 2"
            }); Products.Add(new Product()
            {
                Name = "Prod 3"
            }); Products.Add(new Product()
            {
                Name = "Prod 4"
            });
            Products.Add(new Product()
            {
                Name = "Prod 10"
            });
            Products.Add(new Product()
            {
                Name = "Prod 20"
            }); Products.Add(new Product()
            {
                Name = "Prod 30"
            }); Products.Add(new Product()
            {
                Name = "Prod 04"
            });
            Products.Add(new Product()
            {
                Name = "Prod 41"
            });
            Products.Add(new Product()
            {
                Name = "Prod 12"
            }); Products.Add(new Product()
            {
                Name = "Prod 33"
            }); Products.Add(new Product()
            {
                Name = "Prod 47"
            });
        }
    }
}
