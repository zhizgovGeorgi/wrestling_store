using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Modules;
using LogicLayer;
using DAL;

namespace WrestlingStore_S2.Pages
{
    public class WrestlingShoesModel : PageModel
    {

        public ProductManager pm = new ProductManager(new ProductData());
        public void OnGet()
        {
        }

        public IActionResult OnPost( Product p)
        {

            return RedirectToPage("ShowProduct", p);

        }
    }
}
