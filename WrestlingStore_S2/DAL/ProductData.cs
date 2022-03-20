using Modules;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class ProductData
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
                        product = new WrestlingShoes()
                        {
                            prod_id = prodReader.GetInt32("prod_id"),
                            prodName = prodReader.GetString("prod_Name"),
                            prodCategory = prodReader.GetString("prod_category"),
                            prodPrice = prodReader.GetDouble("prod_price"),
                            prodImg = prodReader.GetString("prod_image"),
                            KindOfActivity = prodReader.GetString("prod_kind")
                        };
                        products.Add(product);
                    }
                    else if (prodReader.GetString("prod_category") == "Wrestling Clothes")
                    {
                        product = new WrestlingClothes()
                        {
                            prod_id = prodReader.GetInt32("prod_id"),
                            prodName = prodReader.GetString("prod_Name"),
                            prodCategory = prodReader.GetString("prod_category"),
                            prodPrice = prodReader.GetDouble("prod_price"),
                            prodImg = prodReader.GetString("prod_image"),
                            Material = prodReader.GetString("prod_material")
                        };
                        products.Add(product);
                    }
                    else if (prodReader.GetString("prod_category") == "Wrestling Accessories")
                    {
                        product = new WrestlingAccessories()
                        {
                            prod_id = prodReader.GetInt32("prod_id"),
                            prodName = prodReader.GetString("prod_Name"),
                            prodCategory = prodReader.GetString("prod_category"),
                            prodPrice = prodReader.GetDouble("prod_price"),
                            prodImg = prodReader.GetString("prod_image")
                        };
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

        public void AddWrestlingAccessories(string prod_name, string prod_category, double prod_price, string prod_image)
        {
            string sqlStatement = "INSERT INTO wad_products (prod_name, prod_category, prod_price, prod_image) VALUES (@prod_name, @prod_category,  @prod_price , @prod_image);";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            command.Parameters.AddWithValue("@prod_name", prod_name);
            command.Parameters.AddWithValue("@prod_category", prod_category);
            command.Parameters.AddWithValue("@prod_price", prod_price);
            command.Parameters.AddWithValue("@prod_image", prod_image);
            try
            {
                int n;

                connection.GetConnection().Open();

                n = command.ExecuteNonQuery();
                Product wa = new WrestlingAccessories()
                {
                    prodName = prod_name,
                    prodCategory = prod_category,
                    prodPrice = prod_price,
                    prodImg = prod_image

                };


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

        public void AddWrestlingShoes(string prod_name, string prod_category, double prod_price, string prod_image, string prod_kind)
        {
            string sqlStatement = "INSERT INTO wad_products (prod_name, prod_category, prod_price, prod_image, prod_kind) VALUES (@prod_name, @prod_category,  @prod_price , @prod_image, @prod_kind);";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            command.Parameters.AddWithValue("@prod_name", prod_name);
            command.Parameters.AddWithValue("@prod_category", prod_category);
            command.Parameters.AddWithValue("@prod_price", prod_price);
            command.Parameters.AddWithValue("@prod_image", prod_image);
            command.Parameters.AddWithValue("@prod_kind", prod_kind);
            try
            {
                int n;

                connection.GetConnection().Open();

                n = command.ExecuteNonQuery();
                Product ws = new WrestlingShoes()
                {
                    prodName = prod_name,
                    prodCategory = prod_category,
                    prodPrice = prod_price,
                    prodImg = prod_image,
                    KindOfActivity = prod_kind

                };


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

        public void AddWrestlingClothes(string prod_name, string prod_category, double prod_price, string prod_image, string prod_material)
        {
            string sqlStatement = "INSERT INTO wad_products (prod_name, prod_category, prod_price, prod_image, prod_material) VALUES (@prod_name, @prod_category,  @prod_price , @prod_image, @prod_material);";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            command.Parameters.AddWithValue("@prod_name", prod_name);
            command.Parameters.AddWithValue("@prod_category", prod_category);
            command.Parameters.AddWithValue("@prod_price", prod_price);
            command.Parameters.AddWithValue("@prod_image", prod_image);
            command.Parameters.AddWithValue("@prod_material", prod_material);
            try
            {
                int n;

                connection.GetConnection().Open();

                n = command.ExecuteNonQuery();
                Product wc = new WrestlingClothes()
                {
                    prodName = prod_name,
                    prodCategory = prod_category,
                    prodPrice = prod_price,
                    prodImg = prod_image,
                    Material = prod_material

                };


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

        //public Product GetProduct(string prod_name)
        //{
        //    string sqlStatement = "SELECT * FROM wad_product WHERE prod_name = @prod_name";
        //    MySqlCommand command = new MySqlCommand(sqlStatement, conn);

        //    try
        //    {
        //        MySqlDataReader databaseReader;

        //        conn.Open();

        //        command.Parameters.AddWithValue("@prod_name", prod_name);

        //        databaseReader = command.ExecuteReader();

        //        DataAccessLayer.DTOs.ProductDTO product;

        //        while (databaseReader.Read())
        //        {



        //            product = new DataAccessLayer.DTOs.ProductDTO()
        //            {
        //                prodId = databaseReader.GetInt32("prod_id"),
        //                prodName = databaseReader.GetString("prod_name"),
        //                prodCategory = databaseReader.GetString("prod_category"),
        //                prodPrice = databaseReader.GetDouble("prod_price"),
        //                prodImg = databaseReader.GetString("prod_image")
        //            };
        //            //user.ID = id;
        //            return product;
        //        }

        //        //return (databaseReader.Read());
        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return null;
        //}
        public void DeleteProduct(Product product)
        {
            string sqlStatement = "DELETE FROM wad_product WHERE prod_name = @prod_name";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            try
            {
                MySqlDataReader databaseReader;

                connection.GetConnection().Open();

                command.Parameters.AddWithValue("@prod_name", product.prodName);

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

        public void EditProduct(int prod_id, string prod_name, string prod_category, double prod_price, string prod_image)
        {
            string sql = "UPDATE wad_product SET prod_name = @prod_name, prod_category = @prod_category, prod_price = @prod_price, prod_image = @prod_image WHERE prod_id = @prod_id;";
            MySqlCommand command = new MySqlCommand(sql, connection.GetConnection());

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());

                cmd.Parameters.AddWithValue("@prod_name", prod_name);
                cmd.Parameters.AddWithValue("@prod_category", prod_category);
                cmd.Parameters.AddWithValue("@prod_price", prod_price);
                cmd.Parameters.AddWithValue("@prod_image", prod_image);
                cmd.Parameters.AddWithValue("@prod_id", prod_id);

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
