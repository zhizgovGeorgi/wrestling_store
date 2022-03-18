using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modules
{

    public  class User
    {
        public int id { get; set; }

        public string fName { get; set; }

        public string lName { get; set; }



        [Required(ErrorMessage = "Enter your email!")]
        public string email { get; set; }

        public string adress { get; set; }

        [Required(ErrorMessage = "Enter your password!")]
        public string password { get; set; }

        public string role { get; set; }

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

        public User()
        {

        }

        public string GetNames()
        {
            return $"{fName} {lName}";
        }

        public override string ToString()
        {
            return $"{fName} {lName} {email} {adress} {role}";
        }


    }
}
