using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modules
{
    public class CartItem
    {
        public int cartID { get; set; }

        public string userEmail { get; set; }

        public string prodName { get; set; }

        public string prodImage { get; set; }

        public string size { get; set; }

        public int quantity { get; set; }

        public double prodPrice { get; set; }


        public CartItem(int cartID, string userEmail,  string prodName, string prodImage, string size, int quantity, double prodPrice, int totalPrice)
        {
            this.cartID = cartID;
            this.userEmail = userEmail;
            this.prodName = prodName;
            this.prodImage = prodImage;
            this.size = size;
            this.quantity = quantity;
            this.prodPrice = prodPrice;
        }

        //public CartItem(DataAccessLayer.DTOs.CartItemDTO cartItemDTO)
        //{
        //    cartID = cartItemDTO.cartID;
        //    userEmail = cartItemDTO.userEmail;
        //    prodName = cartItemDTO.prodName;
        //    prodImage = cartItemDTO.prodImage;
        //    size = cartItemDTO.Size;
        //    quantity = cartItemDTO.Quantity;
        //    prodPrice = cartItemDTO.prodPrice;
        //}

        public CartItem()
        {

        }
    }
}
