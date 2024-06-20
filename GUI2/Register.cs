using Backend;
using DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class Register : Form
    {

        string inputUsername, inputEmail, inputPassword, inputUlangi, inputAlamatOrNamaToko, inputPeran;
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async private void registerButton_Click(object sender, EventArgs e)
        {
            inputUsername = usernameTextBox.Text;
            inputEmail = emailTextBox.Text;
            inputPassword = passwordTextBox.Text;
            inputUlangi = ulangiTextBox.Text;
            inputAlamatOrNamaToko = ArNTTextBox.Text;

            string pass;

            if (inputPassword.Equals(inputUlangi))
            {
                pass = inputPassword;
            }
            else
            {
                MessageBox.Show("Pengulangan password salah");
                return;
            }

            string passwordValid = User<Pembeli>.ValidasiPassword(pass);
            if (!string.IsNullOrWhiteSpace(passwordValid))
            {
                MessageBox.Show(passwordValid);
                return;
            }

            if (PembeliRadioButton.Checked)
            {
                Pembeli newUser = new(inputEmail, pass)
                {
                    Nama = inputUsername,
                    Email = inputEmail,
                    Id = Pembeli.CreateGUID(),
                    Alamat = inputAlamatOrNamaToko
                };

                MessageBox.Show(await newUser.Register());
            }
            else
            {
                Penjual newUser = new(inputEmail, pass)
                {

                    Nama = inputUsername,
                    Email = inputEmail,
                    Id = Pembeli.CreateGUID(),
                    NamaToko = inputAlamatOrNamaToko

                };

                MessageBox.Show(await newUser.Register());
            }

        }

        private void penjualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ShowRB("Nama Toko");
        }

        private void PembeliRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ShowRB("Alamat");
        }

        private void ShowRB(string label)
        {
            ArNTTextBox.Show();
            label5.Show();
            label5.Text = label;
        }

    }
}
