using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        private async void button1_Click(object sender, EventArgs e)
        {
            inputUsername = usernameTextBox.Text;
            inputPassword = passwordTextBox.Text;

            LoginInfo logInf = new();

            logInf.Email = inputUsername;
            logInf.Password = inputPassword;

            if (usernameTextBox.Text.Length <= 0 || passwordTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Username/Password tidak boleh kosong");
                return;
            }

            if (pembeliRadioButton.Checked)
            {
                LoginOut<Pembeli> res = await Pembeli.Login(logInf);
                if (res.Info != null)
                {
                    PanelPembeli pPemp = new(res.Info);
                    this.Hide();
                    pPemp.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(res.Status);
                }
            }
            else if (penjualRadioButton.Checked)
            {
                LoginOut<Penjual> res = await Penjual.Login(logInf);
                if (res.Info != null)
                {
                    PanelPenjual pPenj = new(res.Info);
                    this.Hide();
                    pPenj.ShowDialog();
                    this.Show();
                } else
                {
                    MessageBox.Show(res.Status);
                }
            } 
            else
            {
                MessageBox.Show("Pilih tipe akun apa yang anda ingin pakai");
            }

        }
    }
}
