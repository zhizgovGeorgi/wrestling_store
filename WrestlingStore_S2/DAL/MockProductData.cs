using Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class MockProductData : IProductDataManagement<Product>
    {
        public void AddProduct(Product product)
        {
            List<Product> products = new List<Product>();
            products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            List<Product> products = new List<Product>();
            products.Add(product);
            products.Remove(product);
        }

        public void EditProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int prod_id)
        {
            List<Product> products = new List<Product>();
            Product product = new WrestlingAccessories(1, "product", "category", 22, "image");
            products.Add(product);
            return products.Find(x => x.Prod_id == prod_id);
        }

        public List<Product> ShowAllProducts()
        {
            List<Product> products = new List<Product>();
            return products;
        }
    }
}
