using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Modules;
using LogicLayer;
using System.Security.Claims;
using DAL;

namespace WrestlingStore_S2.Pages
{
    public class ShowProductModel : PageModel
    {
        public ProductManager pm = new ProductManager(new ProductData());
        public UserManager um = new UserManager(new UserData());
        public OrderManager om = new OrderManager(new OrderData());


        public Product Product;

        [BindProperty]
        public OrderDTO Order { get; set; }


        public void OnGet(int id)
        {
            Product = pm.GetProduct(id);
        }

        public void OnPost()
        {
            pm.RemoveProduct(Product);
        }

        public IActionResult OnPostAddToCart(string name)
        {
            User user = um.GetUser(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value);
            Product product = pm.GetProductByName(name);
            Order order = new Order(user, product, Order.Size, Order.Quantity, Status.Pending);

            om.AddOrder(order);
            return RedirectToPage("Cart");
        }

        public IActionResult OnPostAddToCart2(string name)
        {
            User user = um.GetUser(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value);
            Product product = pm.GetProductByName(name);
            Order order = new Order(user, product, "NO SIZE", Order.Quantity, Status.Pending);

            om.AddOrder(order);
            return RedirectToPage("Cart");
        }
    }
}
