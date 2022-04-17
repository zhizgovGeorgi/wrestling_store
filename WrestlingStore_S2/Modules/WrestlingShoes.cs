using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modules
{
    public class WrestlingShoes : Product
    {
        private string kindOfActivity;
        

        [Required(ErrorMessage ="Please, provide for what kind of activity it is!")]
        public string KindOfActivity { get { return this.kindOfActivity; } }

        public WrestlingShoes(int prodId, string prodName, string prodCategory, double prodPrice, string prodImg, string kindOfActivity) : base(prodId, prodName, prodCategory, prodPrice, prodImg)
        {
            this.kindOfActivity = kindOfActivity;
        }

        public WrestlingShoes(string prodName, string prodCategory, double prodPrice, string prodImg, string kindOfActivity) : base( prodName, prodCategory, prodPrice, prodImg)
        {
            this.kindOfActivity = kindOfActivity;
        }

        public WrestlingShoes()
        {

        }

        public override string ToString()
        {
            return base.ToString() + kindOfActivity;
        }
    }
}
