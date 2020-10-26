using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestApp
{
    class WorkServer
    {
        private static string connString = "server=localhost;user=root;database=rest;password=password;" +
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

        public void completeGridTable(string table, DataGridView dataGrid)
        {
            createConnection();
            try 
            { 
                MySqlCommand getData = new MySqlCommand(connString, connection);
                getData.CommandText = $"SELECT * FROM {table};";
                MySqlDataReader reader = getData.ExecuteReader();
                dataGrid.Rows.Clear();
                while (reader.Read())
                {
                    dataGrid.Rows.Add(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                      reader[4].ToString(), reader[5].ToString());
                }
                loseConnection();
            }
            catch (MySqlException e)
            {
                throw new Exception("Error executing into inster sql statement", e);
            }
        }
    }
}
