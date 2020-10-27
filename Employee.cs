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
    public partial class Employee : Form
    {
        int id;
        WorkServer workServer = new WorkServer();
        public Employee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = FIO.Text;
            string datebirth =year.Text+"-"+month.Text+"-"+ day.Text;
            int ZP = Int32.Parse(salary.Text);
            string log = login.Text;
            string pass = password.Text;
            string cell = cell_phone.Text;
     
            workServer.addemployee(name, datebirth, ZP, log, pass, cell);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = FIO.Text;
            string datebirth = year.Text + "-" + month.Text + "-" + day.Text;
            int ZP = Int32.Parse(salary.Text);
            string log = login.Text;
            string pass = password.Text;
            string cell = cell_phone.Text;
            int tip1 = Int32.Parse(tip.Text);
            string hou = hours.Text;
            workServer.changeimployee(id, name, datebirth, ZP, log, pass, cell, hou, tip1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable DT = workServer.selectemployee(search.Text);
            FIO.Text = DT.Rows[0][1].ToString();
            id = Int32.Parse(DT.Rows[0][0].ToString());

            day.Text = DT.Rows[0][2].ToString()[0].ToString()+ DT.Rows[0][2].ToString()[1].ToString();
            month.Text = DT.Rows[0][2].ToString()[3].ToString() + DT.Rows[0][2].ToString()[4].ToString();
            year.Text = DT.Rows[0][2].ToString()[6].ToString() + DT.Rows[0][2].ToString()[7].ToString() + DT.Rows[0][2].ToString()[8].ToString() + DT.Rows[0][2].ToString()[9].ToString();
            salary.Text = DT.Rows[0][3].ToString();
            login.Text = DT.Rows[0][5].ToString();
            password.Text = DT.Rows[0][6].ToString();
            cell_phone.Text = DT.Rows[0][7].ToString();
            tip.Text = DT.Rows[0][8].ToString();
            hours.Text = DT.Rows[0][4].ToString();
        }
    }
}
