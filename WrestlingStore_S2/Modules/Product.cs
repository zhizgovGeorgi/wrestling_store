using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modules
{

    public abstract class Product
    {
        private int prod_id;
        private string prodName;
        private string prodCategory;
        private double prodPrice;
        private string prodImg;


        public int Prod_id { get { return this.prod_id; } }

        [Required(ErrorMessage = "Enter product's name!")]
        public string ProdName { get { return this.prodName; } }

        [Required(ErrorMessage = "Enter category!")]
        public string ProdCategory { get { return this.prodCategory; } }

        [Required(ErrorMessage = "Enter price!")]
        public double ProdPrice { get { return this.prodPrice; } }

        [Required(ErrorMessage = "Enter image!")]
        public string ProdImg { get { return this.prodImg; } }



        public Product(int prodId, string prodName, string prodCategory, double prodPrice, string prodImg)
        {
            this.prod_id = prodId;
            this.prodName = prodName;
            this.prodCategory = prodCategory;
            this.prodPrice = prodPrice;
            this.prodImg = prodImg;
        }

        public Product( string prodName, string prodCategory, double prodPrice, string prodImg)
        {
            this.prodName = prodName;
            this.prodCategory = prodCategory;
            this.prodPrice = prodPrice;
            this.prodImg = prodImg;
        }

        public Product()
        {

        }

        public override string ToString()
        {
            return $"{ProdName} {ProdCategory} {ProdPrice} ";
        }

        public double GetPrice()
        {
            return ProdPrice;
        }


    }
}
