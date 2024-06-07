using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        String inputUsername;
        String inputPassword;

        public Login()
        {
            InitializeComponent();
            this.Show();
        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputUsername = usernameTextBox.Text;
            inputPassword = passwordTextBox.Text;


        }
    }
}
