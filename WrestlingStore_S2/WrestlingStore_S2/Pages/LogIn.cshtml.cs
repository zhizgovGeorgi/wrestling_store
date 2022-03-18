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

namespace WrestlingStore_S2.Pages
{
    public class LogInModel : PageModel
    {

        public UserManager um = new UserManager();

        [BindProperty]
        public LogIn login { get; set; }

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

                if (um.GetUser(login.email, login.password) != null)
                {
                    User user = um.GetUser(login.email, login.password);

                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Email, user.email));
                    claims.Add(new Claim("email", user.email));
                    claims.Add(new Claim(ClaimTypes.Name, user.fName));
                    claims.Add(new Claim("firstName", user.fName));
                    claims.Add(new Claim(ClaimTypes.Surname, user.lName));
                    claims.Add(new Claim("lastName", user.lName));
                    claims.Add(new Claim(ClaimTypes.StreetAddress, user.adress));
                    claims.Add(new Claim("adress", user.adress));
                    claims.Add(new Claim(ClaimTypes.Role, user.role));
                    claims.Add(new Claim("role", user.role));



                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(
CookieAuthenticationDefaults.AuthenticationScheme,
new ClaimsPrincipal(claimsIdentity),
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
