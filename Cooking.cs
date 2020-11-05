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
    public partial class Cooking : Form
    {
        WorkServer wServer = new WorkServer();
        public Cooking()
        {
            InitializeComponent();
        }

        private void cookBox_MouseClick(object sender, MouseEventArgs e)
        {
            cookBox.Items.Clear();
            wServer.getCookData(cookBox);
        }
        private void orderBox_MouseClick(object sender, MouseEventArgs e)
        {
            orderBox.Items.Clear();
            wServer.getOrderData(orderBox); 
        }
        private void orderInfoBox_MouseClick(object sender, MouseEventArgs e)
        {
            orderInfoBox.Items.Clear();
            wServer.getOrderInfoData(orderInfoBox);
        }
        private void Cooking_Load(object sender, EventArgs e)
        {
            wServer.getCookData(cookBox);
            wServer.getOrderData(orderBox);
            wServer.getOrderInfoData(orderInfoBox);
            wServer.completeGridTableForCooking(dataGridViewCook);
            wServer.completedataGridViewInfoPurchase(dataGridViewInfoPurchase);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if(cookBox.SelectedItem != null && orderBox.SelectedItem != null)
            {
                wServer.applyPurchase(cookBox.SelectedItem.ToString(), Convert.ToInt32(orderBox.SelectedItem.ToString()));
                cookBox.Items.Clear();
                orderBox.Items.Clear();
                Cooking_Load(new object(), new EventArgs());
            }
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            if (orderInfoBox.SelectedItem != null)
            {
                if (dataGridViewInfoPurchase.Rows.Count < 1)
                    MessageBox.Show("Пока ни один заказ не начал готовится");
                else
                {
                    for (int i = 0; i < dataGridViewInfoPurchase.Rows.Count; i++)
                    {
                        if (dataGridViewInfoPurchase[0, i].Value.ToString() == orderInfoBox.SelectedItem.ToString())
                        {
                            dataGridViewInfoPurchase.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                            wServer.updateItem(Convert.ToInt32(orderInfoBox.SelectedItem.ToString()));
                            orderInfoBox.Items.Clear();
                            break;
                        }
                    }
                }
            }
        }
    }
}
