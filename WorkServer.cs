using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

        public void addGoods(String nameGood, int quantity, int cost, String info)
        {
            createConnection();
            try
            {
                MySqlCommand getData = new MySqlCommand(connString, connection);
                getData.CommandText = $"UPDATE warehouse " +
                                      $"SET quantity=quantity+{quantity}, cost=cost+{cost}, info='{info}'" +
                                      $"WHERE name = '{nameGood}';";


                if (getData.ExecuteNonQuery() == 0)
                {
                    loseConnection();
                    createConnection();
                    try
                    {
                        Random rnd = new Random();

                        MySqlCommand getNewData = new MySqlCommand(connString, connection);
                        getNewData.CommandText = $"INSERT INTO warehouse (name, idposition, quantity, cost, info)  VALUES" +
                                                 $"('{nameGood}', {rnd.Next(100, Convert.ToInt32(Math.Pow(100, 2)))}, {quantity}, {cost}, '{info}')";
                        getNewData.ExecuteNonQuery();

                        loseConnection();
                    }
                    catch (MySqlException e)
                    {
                        throw new Exception("Error executing into inster sql statement", e);
                    }
                }
                loseConnection();
            }
            catch (MySqlException e)
            {
                throw new Exception("Error executing into inster sql statement", e);
            }
        }

        public void getBooksData(ComboBox cBox)
        {
            createConnection();
            try
            {
                MySqlCommand getData = new MySqlCommand(connString, connection);
                getData.CommandText = $"SELECT name FROM warehouse;";
                MySqlDataReader reader = getData.ExecuteReader();
                while (reader.Read())
                {
                    cBox.Items.Add(reader[0].ToString());
                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Error executing into inster sql statement", e);
            }
        }

        public void removeBook(string name)
        {
            createConnection();
            try
            {
                MySqlCommand deleteData = new MySqlCommand(connString, connection);
                deleteData.CommandText = $"DELETE FROM warehouse WHERE name = '{name}';";
                deleteData.ExecuteNonQuery();
                loseConnection();
            }
            catch (MySqlException e)
            {
                throw new Exception("Error executing into inster sql statement", e);
            }
        }
    }
}
