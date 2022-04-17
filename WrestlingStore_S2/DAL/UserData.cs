using Modules;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class UserData : IUserDataManagement<User>
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

            command.Parameters.AddWithValue("@email", user.Email);

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

                    user = new User(databaseReader.GetInt32("id"), databaseReader.GetString("firstName"), databaseReader.GetString("lastName"), databaseReader.GetString("email"), databaseReader.GetString("adress"), databaseReader.GetString("password"), databaseReader.GetString("role"));
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


                    user = new User(databaseReader.GetInt32("id"), databaseReader.GetString("firstName"), databaseReader.GetString("lastName"), databaseReader.GetString("email"), databaseReader.GetString("adress"), databaseReader.GetString("password"), databaseReader.GetString("role"));
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

        public User GetUser(int id)
        {
            string sqlStatement = "SELECT * FROM wad_user where id = @id";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            try
            {
                MySqlDataReader databaseReader;

                connection.GetConnection().Open();

                command.Parameters.AddWithValue("@id", id);

                databaseReader = command.ExecuteReader();

                User user;

                while (databaseReader.Read())
                {
                    user = new User(databaseReader.GetInt32("id"), databaseReader.GetString("firstName"), databaseReader.GetString("lastName"), databaseReader.GetString("email"), databaseReader.GetString("adress"), databaseReader.GetString("password"), databaseReader.GetString("role"));
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

        public void AddUser(User u)
        {
            string sqlStatement = "INSERT INTO wad_user (firstName, lastName, email, adress,  password) VALUES (@firstName, @lastName,  @email , @adress, @password);";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            command.Parameters.AddWithValue("@firstName", u.FName);
            command.Parameters.AddWithValue("@lastname", u.LName);
            command.Parameters.AddWithValue("@email", u.Email);
            command.Parameters.AddWithValue("@adress", u.Adress);
            command.Parameters.AddWithValue("@password", u.Password);
            command.Parameters.AddWithValue("@role", "User");
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



        public void AddAdministrator(User u)
        {
            string sqlStatement = "INSERT INTO wad_user (firstName, lastName, email, adress,  password) VALUES (@firstName, @lastName,  @email , @adress, @password);";
            MySqlCommand command = new MySqlCommand(sqlStatement, connection.GetConnection());

            command.Parameters.AddWithValue("@firstName", u.FName);
            command.Parameters.AddWithValue("@lastname", u.LName);
            command.Parameters.AddWithValue("@email", u.Email);
            command.Parameters.AddWithValue("@adress", u.Adress);
            command.Parameters.AddWithValue("@password", u.Password);
            command.Parameters.AddWithValue("@role", "Administrator");
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

        public void EditUser(User u)
        {
            string sql = "UPDATE wad_user SET firstName = @firstName, lastName = @lastName, email = @email, adress = @adress, role = @role WHERE id = @id";
            MySqlCommand command = new MySqlCommand(sql, connection.GetConnection());

            MySqlCommand cmd = new MySqlCommand(sql, connection.GetConnection());
            cmd.Parameters.AddWithValue("@id", u.Id);
            command.Parameters.AddWithValue("@firstName", u.FName);
            command.Parameters.AddWithValue("@lastname", u.LName);
            command.Parameters.AddWithValue("@email", u.Email);
            command.Parameters.AddWithValue("@adress", u.Adress);
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
