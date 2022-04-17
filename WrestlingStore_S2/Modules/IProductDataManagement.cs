using System;
using System.Collections.Generic;
using System.Text;

namespace Modules
{
    public interface IProductDataManagement<Product>
    {
        List<Product> ShowAllProducts();

        Product GetProduct(string prod_Name);

        void AddProduct(Product product);

        //void AddWrestlingShoes(string prod_name, string prod_category, double prod_price, string prod_image, string prod_kind);

        //void AddWrestlingClothes(string prod_name, string prod_category, double prod_price, string prod_image, string prod_material);

        void DeleteProduct(Product product);
        void EditProduct(int prod_id, string prod_name, string prod_category, double prod_price, string prod_image);
    }
}
