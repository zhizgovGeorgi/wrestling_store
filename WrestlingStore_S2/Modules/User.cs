using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modules
{

    public  class User
    {
        private int id;
        private string fName;
        private string lName;
        private string email;
        private string adress;
        private string password;
        private string role;



        public int Id { get { return this.id; } } 

        [Required(ErrorMessage = "Enter your firstName!")]
        public string FName { get { return this.fName; } }

        [Required(ErrorMessage = "Enter your last Name!")]
        public string LName { get { return this.lName; } }



        [Required(ErrorMessage = "Enter your email!")]
        public string Email { get { return this.email; } }

        [Required(ErrorMessage = "Enter your adress!")]
        public string Adress { get { return this.adress; } }

        [Required(ErrorMessage = "Enter your password!")]
        public string Password { get { return this.password; } }

        public string Role { get { return this.role; } }

        public User( int id, string fName, string lName, string email, string adress, string password, string role)
        {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.adress = adress;
            this.password = password;
            this.role = role;
        }

        public User( string fName, string lName, string email, string adress, string password, string role)
        {
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.adress = adress;
            this.password = password;
            this.role = role;
        }

        public User()
        {

        }

        public string GetNames()
        {
            return $"{FName} {LName}";
        }

        public override string ToString()
        {
            return $"{FName} {LName} {Email} {Adress} {Role}";
        }


    }
}
