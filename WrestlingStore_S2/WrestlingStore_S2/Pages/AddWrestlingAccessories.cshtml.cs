using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Modules;

namespace WrestlingStore_S2.Pages
{
    public class AddWrestlingAccessoriesModel : PageModel
    {
        [BindProperty]
        public WrestlingAccessories wa { get; set; }



        public ProductManager pm = new ProductManager();

        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                pm.AddAccessories(wa.prodName, wa.prodCategory, wa.prodPrice, wa.prodImg);

                return RedirectToPage("AddWrestlingAccessories");

            }
            return Page();
        }
    }
}
