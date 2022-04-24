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
    public class AddProductModel : PageModel
    {
     

        [BindProperty]
        public WrestlingClothesDTO wc { get; set; }

  

        public ProductManager pm = new ProductManager(new ProductData());

        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Product product = new WrestlingClothes(wc.ProdName, wc.ProdCategory, wc.ProdPrice, wc.ProdImg, wc.ProdMaterial);
                pm.AddProduct(product);


                return RedirectToPage("WrestlingClothes");

            }
            return Page();
        }
    }
}
