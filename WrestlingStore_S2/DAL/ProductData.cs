using Modules;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class ProductData : IProductDataManagement<Product>
    {
        private ConnectionDB connection;


        public ProductData()
        {
            connection = new ConnectionDB();
        }

        public List<Product> ShowAllProducts()
        {
            string sqlStatement = "SELECT * FROM wad_products";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());
            List<Product> products = new List<Product>();
            try
            {
                MySqlDataReader prodReader;

                connection.GetConnection().Open();
                prodReader = command.ExecuteReader();
                Product product;

                while (prodReader.Read())
                {

                    

                    if (prodReader.GetString("prod_category") == "Wrestling Shoes" )
                    {
                        product = new WrestlingShoes(prodReader.GetInt32("prod_id"), prodReader.GetString("prod_Name"), prodReader.GetString("prod_category"), prodReader.GetDouble("prod_price"), prodReader.GetString("prod_image"), prodReader.GetString("prod_kind"));
                        products.Add(product);
                    }
                    else if (prodReader.GetString("prod_category") == "Wrestling Clothes")
                    {
                        product = new WrestlingClothes(prodReader.GetInt32("prod_id"), prodReader.GetString("prod_Name"), prodReader.GetString("prod_category"), prodReader.GetDouble("prod_price"), prodReader.GetString("prod_image"), prodReader.GetString("prod_material")); 
                       
                        products.Add(product);
                    }
                    else if (prodReader.GetString("prod_category") == "Wrestling Accessories")
                    {
                        product = new WrestlingAccessories(prodReader.GetInt32("prod_id"), prodReader.GetString("prod_Name"), prodReader.GetString("prod_category"), prodReader.GetDouble("prod_price"), prodReader.GetString("prod_image"));

                        products.Add(product);
                    }




                }
                return products;



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

        public Product GetProduct(int prod_id)
        {
            string sqlStatement = "SELECT * FROM wad_products where prod_id = @prod_id";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            try
            {
                MySqlDataReader databaseReader;

                connection.GetConnection().Open();

                command.Parameters.AddWithValue("@prod_id", prod_id);

                databaseReader = command.ExecuteReader();

                Product product;

                while (databaseReader.Read())
                {
                    if (databaseReader.GetString("prod_category") == "Wrestling Shoes")
                    {
                        product = new WrestlingShoes(databaseReader.GetInt32("prod_id"), databaseReader.GetString("prod_Name"), databaseReader.GetString("prod_category"), databaseReader.GetDouble("prod_price"), databaseReader.GetString("prod_image"), databaseReader.GetString("prod_kind"));                      
                        return product;
                    }
                    else if (databaseReader.GetString("prod_category") == "Wrestling Clothes")
                    {
                        product = new WrestlingClothes(databaseReader.GetInt32("prod_id"), databaseReader.GetString("prod_Name"), databaseReader.GetString("prod_category"), databaseReader.GetDouble("prod_price"), databaseReader.GetString("prod_image"), databaseReader.GetString("prod_material"));
                        return product;
                    }
                    else if (databaseReader.GetString("prod_category") == "Wrestling Accessories")
                    {
                        product = new WrestlingAccessories(databaseReader.GetInt32("prod_id"), databaseReader.GetString("prod_Name"), databaseReader.GetString("prod_category"), databaseReader.GetDouble("prod_price"), databaseReader.GetString("prod_image"));
                        return product;
                    }


                    
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
            return null;
        }

        //public void AddWrestlingAccessories(Product p)
        //{
        //    string sqlStatement = "INSERT INTO wad_products (prod_name, prod_category, prod_price, prod_image) VALUES (@prod_name, @prod_category,  @prod_price , @prod_image);";
        //    MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

        //    command.Parameters.AddWithValue("@prod_name", p.ProdName);
        //    command.Parameters.AddWithValue("@prod_category", p.ProdCategory);
        //    command.Parameters.AddWithValue("@prod_price", p.ProdPrice);
        //    command.Parameters.AddWithValue("@prod_image", p.ProdImg);
        //    try
        //    {
        //        int n;

        //        connection.GetConnection().Open();

        //        n = command.ExecuteNonQuery();


        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw ex;

        //    }
        //    finally
        //    {
        //        connection.GetConnection().Close();
        //    }
        //}

        //public void AddWrestlingShoes(Product p)
        //{
        //    string sqlStatement = "INSERT INTO wad_products (prod_name, prod_category, prod_price, prod_image, prod_kind) VALUES (@prod_name, @prod_category,  @prod_price , @prod_image, @prod_kind);";
        //    MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

        //    command.Parameters.AddWithValue("@prod_name", p.ProdName);
        //    command.Parameters.AddWithValue("@prod_category", p.ProdCategory);
        //    command.Parameters.AddWithValue("@prod_price", p.ProdPrice);
        //    command.Parameters.AddWithValue("@prod_image", p.ProdImg);
        //    command.Parameters.AddWithValue("@prod_kind", ((WrestlingShoes)p).KindOfActivity);
        //    try
        //    {
        //        int n;

        //        connection.GetConnection().Open();

        //        n = command.ExecuteNonQuery();


        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw ex;

        //    }
        //    finally
        //    {
        //        connection.GetConnection().Close();
        //    }
        //}

        //public void AddWrestlingClothes(WrestlingClothes p)
        //{
        //    string sqlStatement = "INSERT INTO wad_products (prod_name, prod_category, prod_price, prod_image, prod_material) VALUES (@prod_name, @prod_category,  @prod_price , @prod_image, @prod_material);";
        //    MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

        //    command.Parameters.AddWithValue("@prod_name", p.ProdName);
        //    command.Parameters.AddWithValue("@prod_category", p.ProdCategory);
        //    command.Parameters.AddWithValue("@prod_price", p.ProdPrice);
        //    command.Parameters.AddWithValue("@prod_image", p.ProdImg);
        //    command.Parameters.AddWithValue("@prod_material", p.Material);
        //    try
        //    {
        //        int n;

        //        connection.GetConnection().Open();

        //        n = command.ExecuteNonQuery();


        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw ex;

        //    }
        //    finally
        //    {
        //        connection.GetConnection().Close();
        //    }
        //}

        public void AddProduct(Product p)
        {
            if (p is WrestlingClothes)
            {
                string sqlStatement = "INSERT INTO wad_products (prod_name, prod_category, prod_price, prod_image, prod_material) VALUES (@prod_name, @prod_category,  @prod_price , @prod_image, @prod_material);";
                MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

                command.Parameters.AddWithValue("@prod_name", p.ProdName);
                command.Parameters.AddWithValue("@prod_category", p.ProdCategory);
                command.Parameters.AddWithValue("@prod_price", p.ProdPrice);
                command.Parameters.AddWithValue("@prod_image", p.ProdImg);
                command.Parameters.AddWithValue("@prod_material", ((WrestlingClothes)p).Material);
                try
                {
                    int n;

                    connection.GetConnection().Open();

                    n = command.ExecuteNonQuery();


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
            else if (p is WrestlingShoes)
            {
                string sqlStatement = "INSERT INTO wad_products (prod_name, prod_category, prod_price, prod_image, prod_kind) VALUES (@prod_name, @prod_category,  @prod_price , @prod_image, @prod_kind);";
                MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

                command.Parameters.AddWithValue("@prod_name", p.ProdName);
                command.Parameters.AddWithValue("@prod_category", p.ProdCategory);
                command.Parameters.AddWithValue("@prod_price", p.ProdPrice);
                command.Parameters.AddWithValue("@prod_image", p.ProdImg);
                command.Parameters.AddWithValue("@prod_kind", ((WrestlingShoes)p).KindOfActivity);
                try
                {
                    int n;

                    connection.GetConnection().Open();

                    n = command.ExecuteNonQuery();


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
            else if (p is WrestlingAccessories)
            {
                string sqlStatement = "INSERT INTO wad_products (prod_name, prod_category, prod_price, prod_image) VALUES (@prod_name, @prod_category,  @prod_price , @prod_image);";
                MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

                command.Parameters.AddWithValue("@prod_name", p.ProdName);
                command.Parameters.AddWithValue("@prod_category", p.ProdCategory);
                command.Parameters.AddWithValue("@prod_price", p.ProdPrice);
                command.Parameters.AddWithValue("@prod_image", p.ProdImg);
                try
                {
                    int n;

                    connection.GetConnection().Open();

                    n = command.ExecuteNonQuery();


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
        }
        public void DeleteProduct(Product product)
        {
            string sqlStatement = "DELETE FROM wad_products WHERE prod_id = @prod_id";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            try
            {
                MySqlDataReader databaseReader;

                connection.GetConnection().Open();

                command.Parameters.AddWithValue("@prod_id", product.Prod_id);

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

        public void EditProduct(Product p)
        {
            string sql = "UPDATE wad_products SET prod_name = @prod_name, prod_category = @prod_category, prod_price = @prod_price, prod_image = @prod_image WHERE prod_id = @prod_id;";
            MySqlCommand command = new MySqlCommand(sql, connection.GetConnection());

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());

                cmd.Parameters.AddWithValue("@prod_id", p.Prod_id);
                cmd.Parameters.AddWithValue("@prod_name", p.ProdName);
                cmd.Parameters.AddWithValue("@prod_category", p.ProdCategory);
                cmd.Parameters.AddWithValue("@prod_price", p.ProdPrice);
                cmd.Parameters.AddWithValue("@prod_image", p.ProdImg);

                connection.GetConnection().Open();

                cmd.ExecuteNonQuery();


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
