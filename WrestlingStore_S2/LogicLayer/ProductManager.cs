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

        public void AddProduct(Product product)
        {
            productDataManagement.AddProduct(product);
            products.Add(product);
        }
        //public void AddShoes( string prodName, string prodCategory, double prodPrice, string prodImg, string kindOfActivity)
        //{
        //    pd.AddWrestlingShoes(prodName, prodCategory, prodPrice, prodImg, kindOfActivity );
        //    Product product = new WrestlingShoes()
        //    {
        //        ProdName = prodName,
        //        ProdCategory = prodCategory,
        //        ProdPrice = prodPrice,
        //        ProdImg = prodImg,
        //        KindOfActivity = kindOfActivity

        //    };
        //    products.Add(product);
        //}

        //public void AddClothes( string prodName, string prodCategory, double prodPrice, string prodImg, string material)
        //{
        //    pd.AddWrestlingClothes( prodName, prodCategory, prodPrice, prodImg, material);
        //    Product product = new WrestlingClothes()
        //    {
        //        ProdName = prodName,
        //        ProdCategory = prodCategory,
        //        ProdPrice = prodPrice,
        //        ProdImg = prodImg,
        //        Material = material

        //    };
        //    products.Add(product);
        //}

        //public void AddAccessories( string prodName, string prodCategory, double prodPrice, string prodImg)
        //{
        //    pd.AddWrestlingAccessories(prodName, prodCategory, prodPrice, prodImg);
        //    Product product = new WrestlingAccessories()
        //    {
        //        ProdName = prodName,
        //        ProdCategory = prodCategory,
        //        ProdPrice = prodPrice,
        //        ProdImg = prodImg

        //    };
        //    products.Add(product);
        //}

        public void RemoveProduct(Product p)
        {
            foreach (Product product in products)
            {
                if (p.Prod_id == product.Prod_id)
                {
                    productDataManagement.DeleteProduct(p);
                    products.Remove(p);
                    return;    

                }
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
            List<Product> prodList = new List<Product>();
            foreach (Product p in products)
            {
                prodList.Add(p);
            }
            return prodList.ToArray();
        }
    }
}
