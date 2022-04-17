using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Modules;
using System.Data;

namespace DAL
{
    public class OrderData : IOrderDataManagement<Order>
    {
        private ConnectionDB connection;


        public OrderData()
        {
            connection = new ConnectionDB();
        }

        public void AddOrder(Order o)
        {
            string sqlStatement = "INSERT INTO wad_order (user_id,prod_id,  size, quantity, total_price, status) VALUES (@user_id,@prod_id,  @size, @quantity, @total_price, @status);";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());


            command.Parameters.AddWithValue("@user_id", o.User.Id);
            command.Parameters.AddWithValue("@prod_id", o.Product.Prod_id);
            command.Parameters.AddWithValue("@size", o.Size);
            command.Parameters.AddWithValue("@quantity", o.Quantity);
            command.Parameters.AddWithValue("@total_price", o.Product.ProdPrice * o.Quantity);
            command.Parameters.AddWithValue("@status", o.Status.ToString());
            try
            {
                int n;

                connection.GetConnection().Open();

                n = command.ExecuteNonQuery();


                if (n != 1)
                {
                    throw new ArgumentOutOfRangeException("This should not be happening!");
                }
            }
            catch (MySqlException ex)
            {
                throw ex;

            }
            finally
            {
                connection.GetConnection().Close();
            }
        }


        public List<Order> ShowOrderItems(User user)
        {
            string sqlStatement = "SELECT * FROM wad_order WHERE user_id = @user_id";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());
            ProductData productData = new ProductData();
            UserData userData = new UserData();
            List<Order> orders = new List<Order>();
            command.Parameters.AddWithValue("@user_id", user.Id);

            try
            {
                MySqlDataReader orderReader;

                connection.GetConnection().Open();

                orderReader = command.ExecuteReader();
                Order order;

                while (orderReader.Read())
                {
                    Product product = productData.GetProduct(Convert.ToInt32(orderReader["prod_id"]));
                    order = new Order(Convert.ToInt32(orderReader["order_id"]), user, product, orderReader["size"].ToString(), Convert.ToInt32(orderReader["quantity"]), (Status)Enum.Parse(typeof(Status), orderReader["status"].ToString()));
                    //{
                    //    OrderId = Convert.ToInt32(orderReader["order_id"]),
                    //    User = user,
                    //    Product = product,
                    //    Size = orderReader["size"].ToString(),
                    //    Quantity = Convert.ToInt32(orderReader["quantity"]),
                    //    TotalPrice = Convert.ToInt32(orderReader["total_price"]),
                    //    Status = (Status)Enum.Parse(typeof(Status), orderReader["status"].ToString()
                    //                    )
                    //};
                    orders.Add(order);
                }
                return orders;



            }
            catch (MySqlException ex)
            {

                throw ex;
            }
            finally
            {
                connection.GetConnection().Close();
            }
        }

        public List<Order> GetAllOrders()
        {
            string sqlStatement = "SELECT * FROM wad_order ";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());
            ProductData productData = new ProductData();
            UserData userData = new UserData();
            List<Order> orders = new List<Order>();

            try
            {
                MySqlDataReader orderReader;

                connection.GetConnection().Open();

                orderReader = command.ExecuteReader();
                Order order;

                while (orderReader.Read())
                {
                    Product product = productData.GetProduct(Convert.ToInt32(orderReader["prod_id"]));
                    User user = userData.GetUser(Convert.ToInt32(orderReader["user_id"]));
                    order = new Order(Convert.ToInt32(orderReader["order_id"]), user, product, orderReader["size"].ToString(), Convert.ToInt32(orderReader["quantity"]), (Status)Enum.Parse(typeof(Status), orderReader["status"].ToString()));
                    orders.Add(order);
                }
                return orders;



            }
            catch (MySqlException ex)
            {

                throw ex;
            }
            finally
            {
                connection.GetConnection().Close();
            }
        }
        public void DeleteOrder(Order order)
        {
            string sqlStatement = "DELETE FROM wad_order WHERE order_id = @order_id";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            try
            {
                MySqlDataReader databaseReader;

                connection.GetConnection().Open();

                command.Parameters.AddWithValue("@order_id", order.OrderId);

                databaseReader = command.ExecuteReader();

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.GetConnection().Close();
            }
        }
    


        public void EditOrder(Order o, Status status)
        {
            string sql = "UPDATE wad_order SET status = @status WHERE order_id = @order_id";
            MySqlCommand command = new MySqlCommand(sql, connection.GetConnection());

            command.Parameters.AddWithValue("@order_id", o.OrderId);
            command.Parameters.AddWithValue("@status", status.ToString());
            try
            {

                connection.GetConnection().Open();

                command.ExecuteNonQuery();


            }
            catch (MySqlException ex)
            {
                throw ex;
            }

            finally
            {
                if (connection.GetConnection() != null && connection.GetConnection().State == ConnectionState.Open)
                {
                    connection.GetConnection().Close();
                }
            }
        }




    }
}
