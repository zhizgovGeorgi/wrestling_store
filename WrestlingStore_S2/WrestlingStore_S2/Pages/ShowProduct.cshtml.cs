using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Modules;
using LogicLayer;

namespace WrestlingStore_S2.Pages
{
    public class ShowProductModel : PageModel
    {
        public ProductManager pm = new ProductManager();

     

        [BindProperty(SupportsGet = true)]
        public Product Product { get; set; }

        [BindProperty(SupportsGet = true)]
        public CartItem cartItem { get; set; }


        public void OnGet(Product product)
        {
            Product = product;
        }

        public void OnPost(Product product)
        {
            pm.RemoveProduct( product);
        }
    }
}
