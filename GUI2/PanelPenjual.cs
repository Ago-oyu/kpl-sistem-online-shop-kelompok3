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


            HargaNumericUpDown.Maximum = 1000000000000;
            stokNumericUpDown.Minimum = 1000000000000;
            this.p = p;
            welcomeLabel.Text = $"Selamat datang {p.Nama}";
            AwaitGetProduk();

        }

        async private void tambahProdukButton_Click(object sender, EventArgs e)
        {
            string namaProduk = namaTextBox.Text;
            int hargaProduk = (int)HargaNumericUpDown.Value;
            string deskripsiProduk = deskripsiTextBox.Text;
            int stokProduk = (int)stokNumericUpDown.Value;
            Produk newProduk = new Produk()
            {
                Id = Produk.CreateGUID(),
                Nama = namaProduk,
                Harga = hargaProduk,
                Deskripsi = deskripsiProduk,
                Stok = stokProduk,
                IDPenjual = p.Id
            };
            MessageBox.Show(await newProduk.Push());
            AwaitGetProduk();
        }

        async private void AwaitGetProduk()
        {
            produkGridView.Rows.Clear(); ;
            foreach (Produk produk in await Produk.GetPage())
            {
                if (p.Id == produk.IDPenjual)
                {
                    produkGridView.Rows.Add(produk.Nama, produk.Harga, produk.Deskripsi);
                }
            }
       }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            AwaitGetProduk();
        }
    }
}