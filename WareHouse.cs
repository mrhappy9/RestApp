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
    }
}
