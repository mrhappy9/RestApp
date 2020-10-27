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
    public partial class WareHouse : Form
    {
        WorkServer wServer = new WorkServer();
        public WareHouse()
        {
            InitializeComponent();
        }

        private void WareHouse_Load(object sender, EventArgs e)
        {

        }

        private void showPrompt()
        {

        }

        private void allProductsButton_Click(object sender, EventArgs e)
        {
            wServer.completeGridTable(allProductsButton.Tag.ToString(), dataGridView1);
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridAcceptanceGoods.Rows.Clear();
        }

        private void buttonAddGoods_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridAcceptanceGoods.Rows.Count-1; i++)
            {
                MessageBox.Show(dataGridAcceptanceGoods[0, i].Value.ToString() + " " +
                                Convert.ToInt32(dataGridAcceptanceGoods[1, i].Value.ToString()) + " " +
                                Convert.ToInt32(dataGridAcceptanceGoods[2, i].Value.ToString()) + " " +
                                Convert.ToInt32(dataGridAcceptanceGoods[3, i].Value.ToString()) + " " +
                                dataGridAcceptanceGoods[4, i].Value.ToString());
                wServer.addGoods(dataGridAcceptanceGoods[0, i].Value.ToString(),
                                 Convert.ToInt32(dataGridAcceptanceGoods[1, i].Value.ToString()),
                                 Convert.ToInt32(dataGridAcceptanceGoods[2, i].Value.ToString()),
                                 Convert.ToInt32(dataGridAcceptanceGoods[3, i].Value.ToString()),
                                 dataGridAcceptanceGoods[4, i].Value.ToString());
               
               /* for (int j = 0; j < dataGridAcceptanceGoods.Columns.Count; j++)
                {
                    if (dataGridAcceptanceGoods[j, i].Value == null)
                        MessageBox.Show("sf");
                    else
                    {
                        
                        textBox1.Text += dataGridAcceptanceGoods[j, i].Value.ToString();
                    }
                }
                */
            }
        }
    }
}
