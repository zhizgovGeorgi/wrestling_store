using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modules
{

    public class User
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

        public User(int id, string FName, string LName, string Email, string Adress, string Password, string Role)
        {
            this.id = id;
            this.fName = FName;
            this.lName = LName;
            this.email = Email;
            this.adress = Adress;
            this.password = Password;
            this.role = Role;
        }

        //public User(DataAccessLayer.DTOs.UserDTO userDTO)
        //{
        //    id = userDTO.id;
        //    fName = userDTO.fName;
        //    lName = userDTO.lName;
        //    email = userDTO.email;
        //    adress = userDTO.adress;
        //    password = userDTO.password;
        //    role = userDTO.role;
        //}

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
