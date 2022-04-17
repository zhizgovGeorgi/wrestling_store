using System;
using System.Collections.Generic;
using System.Text;
using Modules;

namespace DAL
{
    public class MockDataClass : IProductDataManagement<Product>
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(int prod_id, string prod_name, string prod_category, double prod_price, string prod_image)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(string prod_Name)
        {
            throw new NotImplementedException();
        }

        public List<Product> ShowAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
