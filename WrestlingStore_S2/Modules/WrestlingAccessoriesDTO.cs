using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modules
{
    public class WrestlingAccessoriesDTO
    {
        [Required(ErrorMessage = "Enter product's name!")]
        public string ProdName { get; set; }

        [Required(ErrorMessage = "Enter category!")]
        public string ProdCategory { get; set; }

        [Required(ErrorMessage = "Enter price!")]
        public double ProdPrice { get; set; }

        [Required(ErrorMessage = "Enter image!")]
        public string ProdImg { get; set; }
    }
}
