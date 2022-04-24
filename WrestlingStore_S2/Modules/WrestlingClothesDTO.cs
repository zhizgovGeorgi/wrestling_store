using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modules
{
    public class WrestlingClothesDTO
    {
        [Required(ErrorMessage = "Enter product's name!")]
        public string ProdName { get; set; }

        [Required(ErrorMessage = "Enter category!")]
        public string ProdCategory { get; set; }

        [Required(ErrorMessage = "Enter price!")]
        public double ProdPrice { get; set; }

        [Required(ErrorMessage = "Enter image!")]
        public string ProdImg { get; set; }


        [Required(ErrorMessage = "Enter material!")]
        public string ProdMaterial { get; set; }



        //public ProductDTO(string prodName, string prodCategory, double prodPrice, string prodImg)
        //{
        //    ProdName = prodName;
        //    ProdCategory = prodCategory;
        //    ProdPrice = prodPrice;
        //    ProdImg = prodImg;
        //}
        //public ProductDTO()
        //{

        //}
    }
}
