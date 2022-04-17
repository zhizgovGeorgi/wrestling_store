using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modules
{
    public class Order
    {
        private int orderId;
        private User user;
        private Product product;
        private string size;
        private int quantity;
        private double totalPrice;
        private Status status;


        public int OrderId { get { return this.orderId; } }

        public User User { get { return this.user; } }

        public Product Product { get { return this.product; } }


        [Required(ErrorMessage = "Enter product's size!")]
        public string Size { get { return this.size; } }

        [Required(ErrorMessage = "Enter product's quantity!")]
        public int Quantity { get { return this.quantity; }  }

        public double TotalPrice { get { return this.totalPrice; } }

        public Status Status { get { return this.status; } }



       


        public Order(int orderId, User user, Product product, string size, int quantity, Status status)
        {
            if (quantity <= 0)
            {
                throw new Exception("Quantity must be defined!");
            }
            if (size is null)
            {
                throw new Exception("Size must be defined!");
            }

            this.orderId = orderId;
            this.user = user;
            this.product = product;
            this.size = size;
            this.quantity = quantity;
            this.totalPrice= product.ProdPrice * quantity;
            this.status = status;
        }

        public Order( User user, Product product, string size, int quantity, Status status)
        {
            if (quantity <= 0)
            {
                throw new Exception("Quantity must be defined!");
            }
            if (size is null)
            {
                throw new Exception("Size must be defined!");
            }
            this.user = user;
            this.product = product;
            this.size = size;
            this.quantity = quantity;
            this.totalPrice = product.ProdPrice * quantity;
            this.status = status;
        }


        public Order()
        {

        }


        public override string ToString()
        {
            return $"Order number: {OrderId} for - {User.Email}  with {Product.ProdName} {Quantity} x {Product.ProdPrice} = {TotalPrice} [{Status}]";
        }

    }
}
