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
    public class AddWrestlingShoesModel : PageModel
    {
        [BindProperty]
        public ProductDTO ws { get; set; }

        public ProductManager pm = new ProductManager(new ProductData());

        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Product product = new WrestlingShoes(ws.ProdName, ws.ProdCategory, ws.ProdPrice, ws.ProdImg, ws.ProdKind);
                pm.AddProduct(product);

                return RedirectToPage("AddWrestlingShoes");

            }
            return Page();
        }
    }
}
