using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LogicLayer;
using Modules;
using DAL;
using System.Security.Claims;

namespace WrestlingStore_S2.Pages
{
    public class CartModel : PageModel
    {
        public OrderManager om = new OrderManager(new OrderData());
        public UserManager um = new UserManager(new UserData());
        public void OnGet()
        {
        }

        public void OnPost(int id)
        {
            om.RemoveCartItem(id);
        }

        public void OnPostCompleteOrder()
        {
            if (ModelState.IsValid)
            {
                foreach (Order o in om.ShowOrderItems(um.GetUser(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value)))
                {
                    if (o.Status == Status.Pending)
                    {
                        om.EditOrder(o, Status.Complete);
                    }
                }
            }
        }
    }
}
