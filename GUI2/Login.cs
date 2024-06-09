﻿using System;
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

            Pembeli pembeli = new Pembeli();
            pembeli.Nama = inputUsername;
            pembeli.Password = inputPassword;

            LoginInfo info = new() { Email = inputUsername, Password = inputPassword };

            LoginOut<Pembeli> res = Pembeli.Login(info).Result;

            label1.Text = res.Status;
        }
    }
}
