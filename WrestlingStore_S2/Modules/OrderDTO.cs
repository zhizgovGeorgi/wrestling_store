using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modules
{
    public class OrderDTO
    {
        [Required(ErrorMessage = "Enter product's size!")]
        public string Size { get; set; }

        [Required(ErrorMessage = "Enter product's quantity!")]
        public int Quantity { get; set; }
    }
}
