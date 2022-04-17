using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Modules;
using DAL;

namespace WrestlingStore_S2.Pages
{
    public class WrestlingClothesModel : PageModel
    {

        public ProductManager pm = new ProductManager(new ProductData());
        public WrestlingClothes wc { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost(Product p)
        {

            return RedirectToPage("ShowProduct", p);

        }
    }
}
