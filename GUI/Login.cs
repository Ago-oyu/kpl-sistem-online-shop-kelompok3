﻿using System;
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
        public Login()
        {
            InitializeComponent();
        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();

        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
