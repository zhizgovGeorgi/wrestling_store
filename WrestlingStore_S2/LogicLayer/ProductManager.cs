using DAL;
using Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class ProductManager
    {
        private List<Product> products;
        private ProductData pd;

        public ProductManager()
        {
            pd = new ProductData();
            products = pd.ShowAllProducts();
        }



        public void AddShoes( string prodName, string prodCategory, double prodPrice, string prodImg, string kindOfActivity)
        {
            pd.AddWrestlingShoes(prodName, prodCategory, prodPrice, prodImg, kindOfActivity );
            Product product = new WrestlingShoes()
            {
                prodName = prodName,
                prodCategory = prodCategory,
                prodPrice = prodPrice,
                prodImg = prodImg,
                KindOfActivity = kindOfActivity

            };
            products.Add(product);
        }

        public void AddClothes( string prodName, string prodCategory, double prodPrice, string prodImg, string material)
        {
            pd.AddWrestlingClothes( prodName, prodCategory, prodPrice, prodImg, material);
            Product product = new WrestlingClothes()
            {
                prodName = prodName,
                prodCategory = prodCategory,
                prodPrice = prodPrice,
                prodImg = prodImg,
                Material = material

            };
            products.Add(product);
        }

        public void AddAccessories( string prodName, string prodCategory, double prodPrice, string prodImg)
        {
            pd.AddWrestlingAccessories(prodName, prodCategory, prodPrice, prodImg);
            Product product = new WrestlingAccessories()
            {
                prodName = prodName,
                prodCategory = prodCategory,
                prodPrice = prodPrice,
                prodImg = prodImg

            };
            products.Add(product);
        }

        public void RemoveProduct(Product p)
        {
            foreach (Product product in products)
            {
                if (p.prod_id == product.prod_id)
                {
                    pd.DeleteProduct(p);
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
