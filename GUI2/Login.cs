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


            if (pembeliRadioButton.Checked)
            {
                LoginOut<Pembeli> res = await Pembeli.Login(logInf);
                MessageBox.Show(res.Status + " Pembe");
/*                PanelPembeli pPenj = new(res.Info);
*/            }
            else
            {
                LoginOut<Penjual> res = await Penjual.Login(logInf);
                MessageBox.Show(res.Status + " Penj");
                if (res.Info != null)
                {
                    PanelPenjual pPenj = new(res.Info);
                    pPenj.Show();
                    this.Hide();

                }
            }
        }
    }
}
