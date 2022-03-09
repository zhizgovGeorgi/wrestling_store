using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modules
{

    public class Product
    {

        public int prod_id { get; set; }

        [Required(ErrorMessage = "Enter  product's name!")]
        public string prodName { get; set; }

        [Required(ErrorMessage = "Enter  category!")]
        public string prodCategory { get; set; }

        [Required(ErrorMessage = "Enter  price!")]
        public double prodPrice { get; set; }

        [Required(ErrorMessage = "Enter  image!")]
        public string prodImg { get; set; }

        public Product(int prod_id,string prodName, string prodCategory, double prodPrice, string prodImg)
        {
            this.prod_id = prod_id;
            this.prodName = prodName;
            this.prodCategory = prodCategory;
            this.prodPrice = prodPrice;
            this.prodImg = prodImg;
        }

        //public Product(DataAccessLayer.DTOs.ProductDTO productDTO)
        //{
        //    prod_id = productDTO.prodId;
        //    prodName = productDTO.prodName;
        //    prodCategory = productDTO.prodCategory;
        //    prodPrice = productDTO.prodPrice;
        //    prodImg = productDTO.prodImg;
        //}

        public Product()
        {

        }

       public override string ToString()
        {
            return $"{prodName} {prodCategory} {prodPrice}";
        }

        
    }
}
