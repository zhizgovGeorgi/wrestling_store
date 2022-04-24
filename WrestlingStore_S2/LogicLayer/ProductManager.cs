using Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class ProductManager
    {
        private List<Product> products;
        IProductDataManagement<Product> productDataManagement;

        public ProductManager(IProductDataManagement<Product> productDataManagement)
        {
            this.productDataManagement = productDataManagement;
            products = this.productDataManagement.ShowAllProducts();
        }

        public bool AddProduct(Product product)
        {
            if (products.Find(x => x.ProdName == product.ProdName) is null)
            {
                productDataManagement.AddProduct(product);
                products.Add(product);
                return true;
            }

            return false;
        }

        public void RemoveProduct(Product p)
        {

            if (products.Find(x => x.ProdName == p.ProdName) != null)
            {
                productDataManagement.DeleteProduct(p);
                products.Remove(p);
            }
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            return products.Find(x => x.Prod_id == id);
        }

        public Product GetProductByName(string name)
        {
            return products.Find(x => x.ProdName == name);
        }

        public Product[] GetAllProducts()
        {
            //List<Product> prodList = new List<Product>();
            //foreach (Product p in products)
            //{
            //    prodList.Add(p);
            //}
            return products.ToArray();
        }

        public bool EditProduct(Product p)
        {
            if (products.Find(x => x.Prod_id == p.Prod_id) != null)
            {
                productDataManagement.EditProduct(p);
                return true;
            }
            return false;
        }
    }
}
