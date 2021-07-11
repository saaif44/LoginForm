using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoginF(); 
        }
        private void LoginF()
        {
            string id = UserText.Text;
            string pass = PassText.Text;

            if (id == "admin" && pass == "1234")
            {
                this.Hide();
                logged log = new logged();
                log.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetR();
        }
        private void ResetR()
        {
            UserText.Text = "";
            PassText.Text = "";
        }

        private void PassText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginF();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                ResetR();
            }
        }
    }
}
