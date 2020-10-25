using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace RestApp
{
    class WorkServer
    {
        private static string connString = "server=localhost;user=root;database=rest;password=danilara;" +
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
                command.CommandText = "SELECT login, password FROM rest.employee WHERE login=@login AND password=@password;";
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

        public DataTable menureq()
        {
            createConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SELECT * FROM rest.position;";
                DataTable menu_table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();


                adapter.SelectCommand = command;
                adapter.Fill(menu_table);
                return menu_table;

            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }
        public DataTable id_waiter_req()
        {
            createConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SELECT idEmployee, name FROM rest.employee;";
                DataTable id_table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();


                adapter.SelectCommand = command;
                adapter.Fill(id_table);
                return id_table;

            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }
        public int addorder(string date, string time_order, string state, int id_waiter)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "INSERT INTO `rest`.`order` (`date`, `time_order`, `state`, `idwaiter`) VALUES(@date, @time_order, @state, @id_waiter);";
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@time_order", time_order);
                command.Parameters.AddWithValue("@state", state);
                command.Parameters.AddWithValue("@id_waiter", id_waiter);
                DataTable id = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();


                this.createConnection();
                command.ExecuteNonQuery();
                this.loseConnection();

                command.CommandText = "SELECT * FROM rest.order ORDER BY idOrder DESC;";
                adapter.SelectCommand = command;
                adapter.Fill(id);
                int idselect = Int32.Parse(id.Rows[0][0].ToString());
                return idselect;

    

            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }

        public int additem(string idposition, string quant, int total_rice, int id_order,string details)
        {
            
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "INSERT INTO `rest`.`item` (`idposition`, `quant`, `total_rice`, `id_order`, `State`, `idcooker`, `details`) VALUES (@idposition, @quant, @total_rice, @id_order, 0, 1, @details);";
                command.Parameters.AddWithValue("@idposition", idposition);
                command.Parameters.AddWithValue("@quant", quant);
                command.Parameters.AddWithValue("@total_rice", total_rice);
                command.Parameters.AddWithValue("@id_order", id_order);
                command.Parameters.AddWithValue("@details", details);

                MySqlDataAdapter adapter = new MySqlDataAdapter();


                this.createConnection();
                command.ExecuteNonQuery();
                this.loseConnection();

                DataTable id = new DataTable();
                command.CommandText = "SELECT * FROM rest.item ORDER BY iditem DESC;";
                adapter.SelectCommand = command;
                adapter.Fill(id);
                int idselect = Int32.Parse(id.Rows[0][0].ToString());
                return idselect;


            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }

        public void rleaseorder(int id, string text, string total)
        {
            createConnection();

            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SET SQL_SAFE_UPDATES = 0; UPDATE `rest`.`order` SET `state` = 'В производстве', `total` = @total, `text` = @text  WHERE(`idOrder` = @id);";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@text", text);
                command.Parameters.AddWithValue("@total", total);

                MySqlDataAdapter adapter = new MySqlDataAdapter();



                command.ExecuteNonQuery();
                loseConnection();

            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }
        public void delord(int id)
        {
            createConnection();

            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SET SQL_SAFE_UPDATES = 0; UPDATE `rest`.`order` SET `state` = 'Аннулирован'  WHERE(`idOrder` = @id);";
                command.Parameters.AddWithValue("@id", id);

                MySqlDataAdapter adapter = new MySqlDataAdapter();



                command.ExecuteNonQuery();
                loseConnection();

            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }

        public int  sumreq(int id)
        {

            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SELECT sum(total_rice) FROM rest.item where id_order = @id;";
                command.Parameters.AddWithValue("@id", id);
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                return Int32.Parse(table.Rows[0][0].ToString());

            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }
        public int itreq(int id)
        {

            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SELECT * FROM rest.item where id_order = @id;";
                command.Parameters.AddWithValue("@id", id);
                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                return Int32.Parse(table.Rows[0][0].ToString());

            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }
        public DataTable orderreq(int id)
        {
            createConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SELECT text, total FROM rest.order where idorder =@id";
                command.Parameters.AddWithValue("@id", id);
                DataTable id_table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();


                adapter.SelectCommand = command;
                adapter.Fill(id_table);
                return id_table;

            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }
    }
}
