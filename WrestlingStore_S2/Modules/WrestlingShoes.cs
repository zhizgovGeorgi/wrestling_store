using System;
using System.Collections.Generic;
using System.Text;

namespace Modules
{
    public class WrestlingShoes : Product
    {
        private string kindOfActivity;

        public string KindOfActivity { get; set; }

        public WrestlingShoes(int prodId, string prodName, string prodCategory, double prodPrice, string prodImg, string kindOfActivity) : base(prodId, prodName, prodCategory, prodPrice, prodImg)
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
