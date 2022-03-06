//using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogIn
    {
        [Required(ErrorMessage ="Enter your email!")]
        public string email { get; set; }


        [Required(ErrorMessage = "Enter your password!")]
        public string password { get; set; }

        public LogIn(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public LogIn()
        {

        }
    }
}
