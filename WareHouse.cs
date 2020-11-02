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
            infoBox.Text = "";
        }

        private void buttonAddGoods_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridAcceptanceGoods.Rows.Count-1; i++)
            {
                if (dataGridAcceptanceGoods[0, i].Value != null && dataGridAcceptanceGoods[1, i].Value != null &&
                    dataGridAcceptanceGoods[2, i].Value != null && dataGridAcceptanceGoods[3, i].Value != null &&
                    helpConvertFunc(dataGridAcceptanceGoods[1, i].Value.ToString(), dataGridAcceptanceGoods[2, i].Value.ToString()))
                { 
                    wServer.addGoods(dataGridAcceptanceGoods[0, i].Value.ToString(),
                                     Convert.ToInt32(dataGridAcceptanceGoods[1, i].Value.ToString()),
                                     Convert.ToInt32(dataGridAcceptanceGoods[2, i].Value.ToString()),
                                     dataGridAcceptanceGoods[3, i].Value.ToString());
                }
                else
                    MessageBox.Show("Заполните все ячейки при добавлении товара");
            }

            dataGridView1.Rows.Clear();
            dataGridAcceptanceGoods.Rows.Clear();
            infoBox.Text = "";
        }

        private bool helpConvertFunc(string number, string secondNumber)  // additional check out before filling up BD
        {
            return Int32.TryParse(number, out int clear_num) && Int32.TryParse(secondNumber, out int clear_s_num);
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

        private void buttonClearGoods_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridAcceptanceGoods.Rows.Clear();
            infoBox.Text = "";
        }

        private void buttonForecast_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                MessageBox.Show("Загрузите товары перед прогнозом");
            else
            {
                bool flag = false;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if(Convert.ToInt32(dataGridView1[2, i].Value.ToString()) <= 10)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        infoBox.Text = "Товары выделенные красным цветом должны быть заказаны в 1 очередь.";
                        flag = true;
                    }
                }
                if(!flag)
                    infoBox.Text = "Неопределены товары, нуждающиеся в срочном заказе.";
            }
        }
    }
}
