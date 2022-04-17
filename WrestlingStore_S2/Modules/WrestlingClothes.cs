using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modules
{
    public class WrestlingClothes : Product
    {
        private string material;

        [Required(ErrorMessage="Materia is required")]
        public string Material { get { return this.material; } }

        public WrestlingClothes(int prodId, string prodName, string prodCategory, double prodPrice, string prodImg, string material) : base(prodId, prodName, prodCategory, prodPrice, prodImg)
        {
            this.material = material;
        }

        public WrestlingClothes( string prodName, string prodCategory, double prodPrice, string prodImg, string material) : base( prodName, prodCategory, prodPrice, prodImg)
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
