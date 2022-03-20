using Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class CartManager
    {
        private List<CartItem> cartItems;

        public CartManager()
        {
            cartItems = new List<CartItem>();
        }

        public void AddCartItem( User user, Product product, string size, int quantity, int totalPrice)
        {
            cartItems.Add(new CartItem() 
            {
                user = user,
                product = product,
                size = size,
                quantity = quantity,
                totalPrice= totalPrice
            });
        }

        public void RemoveCartItem(CartItem ci)
        {
            foreach (CartItem cartItem in cartItems)
            {
                if (ci.cartID == cartItem.cartID)
                {
                    cartItems.Remove(ci);
                }
            }
        }

        public List<CartItem> GetCartItems()
        {
            return cartItems;
        }
    }
}
