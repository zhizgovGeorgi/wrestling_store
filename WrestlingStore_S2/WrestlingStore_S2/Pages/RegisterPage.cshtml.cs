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

namespace MyWebStore.Pages
{
    public class RegisterPageModel : PageModel
    {
        [BindProperty]
        public Register register { get; set; }

        public UserManager um = new UserManager();

        public void OnGet()
        {
           
        }

        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {


                um.AddUser(register.fName, register.lName, register.email, register.adress, register.password);
                return RedirectToPage("LogIn");

            }
            return Page();
        }


    }
}
