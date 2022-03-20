using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modules
{
    public class CartItem
    {
        public int cartID { get; set; }

        public User user { get; set; }

        public Product product { get; set; }

        public string size { get; set; }

        public int quantity { get; set; }

        public int totalPrice { get; set; }

       


        public CartItem(int cartID, User user, Product product, string size, int quantity, int totalPrice)
        {
            this.cartID = cartID;
            this.user = user;
            this.product = product;
            this.size = size;
            this.quantity = quantity;
            this.totalPrice= totalPrice;
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
