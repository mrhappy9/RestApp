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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WorkServer workServer = new WorkServer();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }

        private void entranceButton_Click(object sender, EventArgs e)
        {
            workServer.createConnection();
            if(isCorrectInputData(passwordBox.Text, loginBox.Text) && 
               workServer.signIn(loginBox.Text, passwordBox.Text))
            {
                switchWarning(false);
                clearTextFields();
                MessageBox.Show("Ok");
            }
            else
            {
                switchWarning(true);
                clearTextFields();
            }

            workServer.loseConnection();
        }

        private bool isCorrectInputData(string password, string login)
        {
            if (password != "" && login != "")
                return true;
            return false;
        }

        private void switchWarning(bool flag)
        {
            if (flag)
                warningLabel.Text = warningLabel.Tag.ToString();
            else
                warningLabel.Text = "";
        }

        private void clearTextFields()
        {
            passwordBox.Text = loginBox.Text = "";
        }
    }
}
