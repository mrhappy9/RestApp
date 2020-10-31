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
                wServer.addGoods(dataGridAcceptanceGoods[0, i].Value.ToString(),
                                 Convert.ToInt32(dataGridAcceptanceGoods[1, i].Value.ToString()),
                                 Convert.ToInt32(dataGridAcceptanceGoods[2, i].Value.ToString()),
                                 dataGridAcceptanceGoods[3, i].Value.ToString());
            }

            dataGridView1.Rows.Clear();
            dataGridAcceptanceGoods.Rows.Clear();
        }

        private void itemsBox_MouseClick(object sender, MouseEventArgs e)
        {
            itemsBox.Items.Clear();
            wServer.getBooksData(itemsBox);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            wServer.getBooksData(itemsBox);
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            if (itemsBox.SelectedItem != null) 
            { 
                wServer.removeBook(itemsBox.SelectedItem.ToString());
                itemsBox.SelectedItem = null;
                MessageBox.Show("Выбранный товар был списан", "Успешно!");
            }
            else
                MessageBox.Show("Выберите корректную позицию товара для списания", "Внимание!");
        }
    }
}
