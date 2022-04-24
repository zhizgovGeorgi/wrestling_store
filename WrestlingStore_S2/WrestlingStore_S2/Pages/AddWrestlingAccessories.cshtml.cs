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
    public class AddWrestlingAccessoriesModel : PageModel
    {
        [BindProperty]
        public WrestlingAccessoriesDTO wa { get; set; }



        public ProductManager pm = new ProductManager(new ProductData());

        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Product product = new WrestlingAccessories(wa.ProdName, wa.ProdCategory, wa.ProdPrice, wa.ProdImg);
                pm.AddProduct(product);


                return RedirectToPage("WrestlingAccessories");

            }
            return Page();
        }
    }
}
