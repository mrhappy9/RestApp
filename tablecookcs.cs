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
    public partial class tablecookcs : Form
    {
        WorkServer workServer = new WorkServer();
        DataTable cook;
        public tablecookcs()
        {
            int i = 0;
            InitializeComponent();
            cook= workServer.masterreq();
            i = 0;
            while (i < cook.Rows.Count)
            {
                master.Items.Add(cook.Rows[i][1].ToString());
                i++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable ds = workServer.tablecook();
            dataGridView1.DataSource = ds;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            string name = master.SelectedItem.ToString();
            int i = 0;
            int id = 0;
            while (i < cook.Rows.Count)
            {
                if ( name== cook.Rows[i][1].ToString())
                {
                    id = Int32.Parse(cook.Rows[i][0].ToString());
                }
                i++;
            }

            workServer.takingitem(Int32.Parse(idpos.Text), id);
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DataTable ds = workServer.newit();
            dataGridView1.DataSource = ds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
