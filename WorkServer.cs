using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApp
{
    class WorkServer
    {
        private static string connString = "server=localhost;user=root;database=restapp;password=password;" +
                                              "Allow User Variables=True;";
        private MySqlConnection connection;
        public void createConnection()
        {
            connection = new MySqlConnection(connString);
            connection.Open();
        }
        public void loseConnection()
        {
            connection.Close();
        }

        public bool signIn(string login, string password)
        {
            createConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SELECT login, password FROM users WHERE login=@login AND password=@password;";
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return true;
                }
                return false;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);
            }
        }
    }
}
