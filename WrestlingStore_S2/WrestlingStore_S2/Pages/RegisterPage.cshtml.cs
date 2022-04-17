using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text;
using Modules;
using LogicLayer;
using DAL;

namespace MyWebStore.Pages
{
    public class RegisterPageModel : PageModel
    {
        [BindProperty]
        public UserRegister User { get; set; }


        public UserManager um = new UserManager(new UserData());

        public void OnGet()
        {
           
        }

        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {
                User user = new User(User.fName, User.lName, User.email, User.adress, User.password, "User");

                um.AddUser(user);
                return RedirectToPage("LogIn");

            }
            return Page();
        }


    }
}
