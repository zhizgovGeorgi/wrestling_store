using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modules
{
    public class UserLogIn
    {
        [Required(ErrorMessage = "Enter your email!")]
        public string email { get; set; }


        [Required(ErrorMessage = "Enter your password!")]
        public string password { get; set; }



        //public UserLogIn(string FName, string LName, string Email, string Adress, string Password)
        //{
        //    Email = email;
        //    Password = password;
        //}
        //public UserLogIn()
        //{

        //}
    }
}
