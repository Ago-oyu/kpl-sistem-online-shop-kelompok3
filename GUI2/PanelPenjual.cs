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

namespace GUI
{
    public partial class PanelPenjual : Form
    {
        private Penjual p;
        public PanelPenjual(Penjual p)
        {
            InitializeComponent();

            produkGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            produkGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.p = p;
            welcomeLabel.Text = $"Selamat datang {p.Nama}";
        }

        async private void tambahProdukButton_Click(object sender, EventArgs e)
        {
            string namaProduk = namaTextBox.Text;
            int hargaProduk = (int)HargaNumericUpDown.Value;
            string deskripsiProduk = deskripsiTextBox.Text;
            int stokProduk = (int)stokNumericUpDown.Value;
            Produk newProduk = new Produk()
            {
                Id = Database.CreateGUID(),
                Nama = namaProduk,
                Harga = hargaProduk,
                Deskripsi = deskripsiProduk,
                Stok = stokProduk,
                TokoPenjual = p.NamaToko,
                NamaPenjual = p.Nama
            };
            MessageBox.Show(await newProduk.Push());
        }
    }
}
