using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LogicLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Modules;
using DAL;

namespace WrestlingStore_S2.Pages
{
    public class LogInModel : PageModel
    {

        public UserManager um = new UserManager(new UserData());

        [BindProperty]
        public UserLogIn logIn { get; set; }

        public string Title { get; set; }


        public void OnGet()
        {
            Title = "LogIn";
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                //var password = userDTO.password;
                //var newSalt = "njkfbaijsa";
                //var hashedPassword = hashing.ComputeHash(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(newSalt));

                if (um.ReadUser(logIn.email, logIn.password) != null)
                {
                    User user = um.ReadUser(logIn.email, logIn.password);

                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Email, user.Email));
                    claims.Add(new Claim(ClaimTypes.Name, user.FName));
                    claims.Add(new Claim(ClaimTypes.Surname, user.LName));
                    claims.Add(new Claim(ClaimTypes.StreetAddress, user.Adress));
                    claims.Add(new Claim(ClaimTypes.Role, user.Role));



                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity),
                        new AuthenticationProperties
                        {
                            IsPersistent = true,
                            ExpiresUtc = DateTime.UtcNow.AddMinutes(20)
                        });


                    return RedirectToPage("Index");
                }
                else
                {
                    return RedirectToPage("LogIn");
                }

            }
            return Page();
        }

    }
}
