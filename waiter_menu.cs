using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestApp
{
    public partial class waiter_menu : Form
    {
        int numb_prder = 0;
        WorkServer workServer = new WorkServer();
        int q = 0;
        List<int> mas = new List<int>();
        public waiter_menu()
        {
            InitializeComponent();
            DataTable menu = workServer.menureq();
            int i = 0;
            while (i < menu.Rows.Count)
            {
                menuch.Items.Add(menu.Rows[i][1].ToString());
                i++;
            }

            DataTable waiter1 = workServer.id_waiter_req();
            i = 0;
            while (i < waiter1.Rows.Count)
            {
                waiter.Items.Add(waiter1.Rows[i][1].ToString());
                i++;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (q==0)
            {
                string state = "Зарегистрирован";
                int id_wait = 0;
                string name_wainter = waiter.SelectedItem.ToString();
                DataTable id_waiter = workServer.id_waiter_req();
                while (i < id_waiter.Rows.Count)
                {
                    if (name_wainter == id_waiter.Rows[i][1].ToString())
                    {
                        id_wait = Int32.Parse(id_waiter.Rows[i][0].ToString());
                    }
                    i++;
                }
                
                numb_prder = workServer.addorder(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), state, id_wait);
                order.Text += "Чек № " + numb_prder.ToString() + '\r' + '\n';
                order.Text += "Дата: " + DateTime.Now.ToShortDateString()+ "    Время регистрации: " + DateTime.Now.ToShortTimeString() + '\r' + '\n';
            }
            
            q += 1;
            DataTable menutab = workServer.menureq();
            i = 0;
            string com = details.Text;
            int amounttext = Int32.Parse(amount.Value.ToString());
            string name = menuch.SelectedItem.ToString();
            int total_price = 0;
            int idposition = 0;
            while (i < menutab.Rows.Count)
            {
                if (name == menutab.Rows[i][1].ToString())
                {
                    total_price = amounttext * Int32.Parse(menutab.Rows[i][2].ToString());
                    idposition = Int32.Parse(menutab.Rows[i][0].ToString());
                }
                i++;
            }
            string item = q.ToString() + " " + name + " " + amounttext.ToString() + "шт " + total_price.ToString() + "руб ";
            order.Text += item + '\r' + '\n';
            mas.Add(workServer.additem(idposition.ToString(), amounttext.ToString(), total_price, numb_prder, com));
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            int sum = workServer.sumreq(numb_prder);
            order.Text +="ИТОГО:  " +sum.ToString() + " руб " + '\r' + '\n';
            workServer.rleaseorder(numb_prder, order.Text, sum.ToString());
            q = 0;
        }

        private void new_order_Click(object sender, EventArgs e)
        {
            if ((q == 0) && (numb_prder == 0))
            {
                q = 0;
                numb_prder = 0;
                order.Clear();
                amount.Value = 1;
                waiter.SelectedIndex = 0;
                menuch.SelectedIndex = 0;
                details.Clear();
            }
            else
                MessageBox.Show("Чек не аннулирован");
        }

        private void errase_Click(object sender, EventArgs e)
        {
            if ((q != 0) && (numb_prder != 0))
                workServer.delord(numb_prder);
            q = 0;
            numb_prder = 0;
        }

        private void apply_edit_Click(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           DataTable table = workServer.orderreq(Int32.Parse(choise.Text));
            order.Text = table.Rows[0][0].ToString();
            sumforpay1.Text = table.Rows[0][1].ToString();
        }

        private void pay1_Click(object sender, EventArgs e)
        {

        }
    }
}
