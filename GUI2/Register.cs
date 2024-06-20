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
        // Variabel untuk menyimpan input dari pengguna
        string inputUsername, inputEmail, inputPassword, inputUlangi, inputAlamatOrNamaToko, inputPeran;

        // Konstruktor untuk form Register
        public Register()
        {
            InitializeComponent();
        }

        // Event handler untuk tombol "Close"
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler untuk tombol "Register"
        async private void btnRegister_Click(object sender, EventArgs e)
        {
            // Mendapatkan input dari TextBox yang ada di form
            inputUsername = usernameTextBox.Text;
            inputEmail = emailTextBox.Text;
            inputPassword = passwordTextBox.Text;
            inputUlangi = ulangiTextBox.Text;
            inputAlamatOrNamaToko = ArNTTextBox.Text;

            string pass;

            // Validasi apakah password dan ulangi password sama
            if (inputPassword.Equals(inputUlangi))
            {
                pass = inputPassword;
            }
            else
            {
                // Menampilkan pesan kesalahan jika password tidak sama
                MessageBox.Show("Pengulangan password salah");
                return;
            }

            // cek apakah password valid (Tipe generic user tidak penting)
            string passwordValid = User<Pembeli>.ValidasiPassword(pass);
            if (!string.IsNullOrWhiteSpace(passwordValid))
            {
                // Menampilkan pesan kesalahan jika password tidak valid
                MessageBox.Show(passwordValid);
                return;
            }
            // Cek apakah RadioButton untuk Pembeli dipilih
            if (PembeliRadioButton.Checked)
            {
                // Membuat objek Pembeli baru
                Pembeli newUser = new(inputEmail, pass)
                {
                    Nama = inputUsername,
                    Email = inputEmail,
                    Id = Pembeli.CreateGUID(),
                    Alamat = inputAlamatOrNamaToko
                };
                // Menampilkan pesan hasil registrasi
                MessageBox.Show(await newUser.Register());
            }
            else
            {
                // Membuat objek Penjual baru
                Penjual newUser = new(inputEmail, pass)
                {

                    Nama = inputUsername,
                    Email = inputEmail,
                    Id = Pembeli.CreateGUID(),
                    NamaToko = inputAlamatOrNamaToko

                };
                // Menampilkan pesan hasil registrasi
                MessageBox.Show(await newUser.Register());
            }

        }
        // Event handler untuk perubahan pilihan RadioButton penjual
        private void penjualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Menampilkan TextBox dan Label dengan teks "Nama Toko"
            ShowRB("Nama Toko");
        }
        // Event handler untuk perubahan pilihan RadioButton pembeli
        private void PembeliRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Menampilkan TextBox dan Label dengan teks "Alamat"
            ShowRB("Alamat");
        }
        // Method untuk menampilkan TextBox dan Label dengan teks tertentu
        private void ShowRB(string label)
        {
            ArNTTextBox.Show();
            label5.Show();
            label5.Text = label;
        }

    }
}
