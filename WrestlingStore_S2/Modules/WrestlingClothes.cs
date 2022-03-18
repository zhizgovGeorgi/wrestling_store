using System;
using System.Collections.Generic;
using System.Text;

namespace Modules
{
    public class WrestlingClothes : Product
    {
        private string material;

        public string Material { get; set; }

        public WrestlingClothes(int prodId, string prodName, string prodCategory, double prodPrice, string prodImg, string material) : base(prodId, prodName, prodCategory, prodPrice, prodImg)
        {
            this.material = material;
        }

        public WrestlingClothes()
        {

        }


        public override string ToString()
        {
            return base.ToString() + material;
        }
    }
}
