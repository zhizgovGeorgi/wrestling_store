using Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class ProductManager
    {
        private List<Product> products;

        public ProductManager()
        {
            products = new List<Product>();
        }



        public void AddShoes(int id, string prodName, string prodCategory, double prodPrice, string prodImg, string kindOfActivity)
        {
            products.Add(new WrestlingClothes(id, prodName, prodCategory, prodPrice, prodImg, kindOfActivity));
        }

        public void AddClothes(int id, string prodName, string prodCategory, double prodPrice, string prodImg, string material)
        {
            products.Add(new WrestlingClothes(id, prodName, prodCategory, prodPrice, prodImg, material));

        }

        public void AddAccessories(int id, string prodName, string prodCategory, double prodPrice, string prodImg)
        {
            products.Add(new WrestlingAccessories(id, prodName, prodCategory, prodPrice, prodImg));
            //{
            //    ProdName = prodName,
            //    ProdCategory = prodCategory,
            //    ProdPrice = prodPrice,
            //    ProdImg = prodImg
            //}
            //);
        }

        public void RemoveProduct(Product p)
        {
            foreach (Product product in products)
            {
                if (p.prod_id == product.prod_id)
                {
                    products.Remove(p);
                    return;    

                }
            }
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product[] GetAllProducts()
        {
            List<Product> prodList = new List<Product>();
            foreach (Product p in products)
            {
                prodList.Add(p);
            }
            return prodList.ToArray();
        }
    }
}
