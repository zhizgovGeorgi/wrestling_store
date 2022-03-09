//using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modules
{
    public class Register
    {
       

        [Required(ErrorMessage = "Enter your name!")]
        public string fName { get; set; }

        [Required(ErrorMessage = "Enter your last Name!")]
        public string lName { get; set; }


        [Required(ErrorMessage = "Enter your email!")]
        public string email { get; set; }

        [Required(ErrorMessage ="Enter your adress!")]
        public string adress { get; set; }

        [Required(ErrorMessage = "Enter your password!")]
        public string password { get; set; }



        public Register(string FName, string LName, string Email, string Adress , string Password)
        {
            FName = fName;
            LName = lName;
            Email = email;
            Adress = adress;
            Password = password;
        }
        public Register()
        {

        }

    }
}
