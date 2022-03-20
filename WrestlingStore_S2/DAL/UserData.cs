using Modules;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class UserData
    {
        private ConnectionDB connection;

        public UserData()
        {
            connection = new ConnectionDB();
        }

        public void DeleteUser(User user)
        {
            string sqlStatement = "DELETE FROM wad_user WHERE email = @email;";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            command.Parameters.AddWithValue("@email", user.email);

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
        public List<User> GetAllUsers()
        {
            string sqlStatement = "SELECT * FROM wad_user ";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());
            List<User> users = new List<User>();
            try
            {
                MySqlDataReader databaseReader;

                connection.GetConnection().Open();
                databaseReader = command.ExecuteReader();

                User user;

                while (databaseReader.Read())
                {


                    user = new User()
                    {
                        id = databaseReader.GetInt32("id"),
                        fName = databaseReader.GetString("firstName"),
                        lName = databaseReader.GetString("lastName"),
                        email = databaseReader.GetString("email"),
                        adress = databaseReader.GetString("adress"),
                        password = databaseReader.GetString("password"),
                        role = databaseReader.GetString("role")
                    };
                    users.Add(user);
                }
                return users;
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

        public User ReadUser(string email, string password)
        {
            string sqlStatement = "SELECT * FROM wad_user where email = @email and password = @password";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            try
            {
                MySqlDataReader databaseReader;

                connection.GetConnection().Open();

                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password);

                databaseReader = command.ExecuteReader();

                User user;

                while (databaseReader.Read())
                {


                    user = new User()
                    {
                        id = databaseReader.GetInt32("id"),
                        fName = databaseReader.GetString("firstName"),
                        lName = databaseReader.GetString("lastName"),
                        email = databaseReader.GetString("email"),
                        adress = databaseReader.GetString("adress"),
                        password = databaseReader.GetString("password"),
                        role = databaseReader.GetString("role")
                    };
                    return user;
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

        public void AddUser(string firstName, string lastName, string email, string adress, string password)
        {
            string sqlStatement = "INSERT INTO wad_user (firstName, lastName, email, adress,  password) VALUES (@firstName, @lastName,  @email , @adress, @password);";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastname", lastName);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@adress", adress);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@role", "User");
            try
            {
                int n;

                connection.GetConnection().Open();

                n = command.ExecuteNonQuery();
                User user = new User()
                {
                    fName = firstName,
                    lName = lastName,
                    email = email,
                    adress = adress,
                    password = password,
                    role = "User"
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



        public void AddAdministrator(string firstName, string lastName, string email, string adress, string password)
        {
            string sqlStatement = "INSERT INTO wad_user (firstName, lastName, email, adress,  password) VALUES (@firstName, @lastName,  @email , @adress, @password);";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastname", lastName);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@adress", adress);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@role", "Administrator");
            try
            {
                int n;

                connection.GetConnection().Open();

                n = command.ExecuteNonQuery();
                User user = new User()
                {
                    fName = firstName,
                    lName = lastName,
                    email = email,
                    adress = adress,
                    password = password,
                    role = "Administrator"
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

        public void EditUser(int id, string fName, string lName, string email, string adress, string role)
        {
            string sql = "UPDATE wad_user SET firstName = @firstName, lastName = @lastName, email = @email, adress = @adress, role = @role WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, connection.GetConnection());

            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            cmd.Parameters.AddWithValue("@firstName", fName);
            cmd.Parameters.AddWithValue("@lastName", lName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@adress", adress);
            cmd.Parameters.AddWithValue("@role", role);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {

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
