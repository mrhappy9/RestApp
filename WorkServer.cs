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
                command.CommandText = "INSERT INTO `rest`.`item` (`idposition`, `quant`, `total_rice`, `id_order`, `State`, `idcooker`, `details`) VALUES (@idposition, @quant, @total_rice, @id_order, 'Новый', 7, @details);";
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
        public void addtip(int id, int summ)
        {
            createConnection();

            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SELECT ectra FROM rest.employee where idemployee = @id;";
                command.Parameters.AddWithValue("@id", id);
                DataTable id_table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();


                adapter.SelectCommand = command;
                adapter.Fill(id_table);
                int a = Int32.Parse(id_table.Rows[0][0].ToString()) + summ;

                command.CommandText = "SET SQL_SAFE_UPDATES = 0; UPDATE rest.employee SET ectra = @sum  WHERE(idemployee = @id);";
                command.Parameters.AddWithValue("@sum", a);




                command.ExecuteNonQuery();
                loseConnection();

            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }

        public void finalord(int id, int sum, int disc, string way, string time, string text)
        {
            createConnection();

            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SET SQL_SAFE_UPDATES = 0;  UPDATE `rest`.`order` SET `payment` = @pay, `wayofpayment` = @way, `text` = @text, `state` = 'Оплачен',`time_control` = @time, `discount` = @disc WHERE(`idOrder` = @id);";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@pay", sum);
                command.Parameters.AddWithValue("@way", way);
                command.Parameters.AddWithValue("@time", time);
                command.Parameters.AddWithValue("@disc", disc);
                command.Parameters.AddWithValue("@text", text);
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
        
        public void addemployee(string name, string birth, int salary, string login, string pass, string cell)
        {

            createConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "INSERT INTO `rest`.`employee` (`Name`, `Dateofbirth`, `salary`, `hoursofwork`, `login`, `password`, `cellphone`, `Ectra`) VALUES(@name, @birth, @salary, '0', @login, @pass, @cell, '0');";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@birth", birth);
                command.Parameters.AddWithValue("@salary", salary);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@pass", pass);
                command.Parameters.AddWithValue("@cell", cell);
            
                command.ExecuteNonQuery();
                this.loseConnection();




            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }
        public void changeimployee(int id,string name, string birth, int salary, string login, string pass, string cell, string hw, int extr)
        {

            createConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SET SQL_SAFE_UPDATES = 0; UPDATE `rest`.`employee` SET `Name` = @name, `Dateofbirth` = @birth, `salary` = @salary, `hoursofwork` = @hw, `login` = @login, `password` = @pass, `cellphone` = @cell, `Ectra` = @extra WHERE (`idEmployee` = @id);";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@birth", birth);
                command.Parameters.AddWithValue("@salary", salary);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@pass", pass);
                command.Parameters.AddWithValue("@cell", cell);
                command.Parameters.AddWithValue("@extra", extr);
                command.Parameters.AddWithValue("@hw", hw);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                this.loseConnection();




            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }
        public void takingitem(int id, int id_cook)
        {

            createConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "UPDATE `rest`.`item` SET `State` = 'Обработан', `idcooker` = @id_cook WHERE (`idItem` = @id);";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@id_cook", id_cook);

                command.ExecuteNonQuery();
                this.loseConnection();




            }
            catch (MySqlException ex)
            {
                throw new Exception("Error executing with sql statement", ex);

            }

        }
        public DataTable selectemployee(string login)
        {
            createConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SELECT * FROM rest.Employee where login =@login";
                command.Parameters.AddWithValue("@login", login);
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
       
        public DataTable tablecook()
        {
            createConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = " SELECT Iditem as 'Номер позиции', position.name as Позиция, employee.name as Ответсвенный , state As Статус , details As Комментарий FROM rest.item" +
                " JOIN employee ON employee.Idemployee = item.idcooker"+
                " JOIN position ON position.Idposition = item.idposition";

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
        public DataTable masterreq()
        {
            createConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SELECT idemployee, name FROM rest.employee where job = 2";

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
        public DataTable newit()
        {
            createConnection();
            try
            {
                MySqlCommand command = new MySqlCommand(connString, connection);
                command.CommandText = "SELECT Iditem as 'Номер позиции', position.name as Позиция,  employee.name as Ответсвенный , state  As Статус ,details As Комментарий FROM rest.item " +
                    "JOIN employee ON employee.Idemployee = item.idcooker " +
                    "JOIN position ON position.Idposition = item.idposition " +
                    "where employee.name = 'Отсутствует'";

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
