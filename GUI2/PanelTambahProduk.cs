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
using Backend;

namespace GUI
{
    public partial class PanelTambahProduk : Form
    {
        private Penjual penjual;
        public PanelTambahProduk(Penjual penjual)
        {
            InitializeComponent();
            this.penjual = penjual;
            hargaNumericUpDown.Maximum = 2147483647;
            stokNumericUpDown.Maximum = 2147483647;
        }

        private async void tambahBtn_Click(object sender, EventArgs e)
        {
            string namaProduk = namaProdukTextBox.Text;
            int hargaProduk = (int)hargaNumericUpDown.Value;
            string deskripsiProduk = deskripsiTextBox.Text;
            int stokProduk = (int)stokNumericUpDown.Value;
            Produk newProduk = new Produk()
            {
                Id = Produk.CreateGUID(),
                Nama = namaProduk,
                Harga = hargaProduk,
                Deskripsi = deskripsiProduk,
                Stok = stokProduk,
                IDPenjual = penjual.Id,
            };
            MessageBox.Show(await newProduk.Push());
            ShopApiClient.Database.AddProduk(newProduk);
            this.Close();
        }
    }
}
