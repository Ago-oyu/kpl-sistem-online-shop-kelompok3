using DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PanelProdukDetail : Form
    {
        Produk produk;
        Pembeli pembeli;
        Penjual penjual;

        public PanelProdukDetail(string produkId, string penjualId, Pembeli pembeli)
        {
            InitializeComponent();

            GetData(produkId, penjualId);
            this.pembeli = pembeli;

        }

        async private void GetData(string produkId, string penjualId)
        {
            produk = await Produk.Get(produkId);
            penjual = await Penjual.Get(penjualId);

            NamaTokoLabel.Text = penjual.NamaToko;
            NamaPenjualLabel.Text = penjual.Nama;
            NamaProdukLabel.Text = produk.Nama;
            HargaProdukLabel.Text = produk.Harga.ToString();
            StokProdukLabel.Text = produk.Stok.ToString();
            DeskripsiProdukLabel.Text = produk.Deskripsi;

            StokNumericUpDown.Maximum = produk.Stok;
            TotalHargaLabel.Text = produk.Harga.ToString();
        }

        private async void pesanProduk_Click(object sender, EventArgs e)
        {
            Pesanan newPesanan = new()
            {
                ProdukID = produk.Id,
                PembeliID = pembeli.Id,
                PenjualID = penjual.Id,

                stok = (int)StokNumericUpDown.Value,
                totalHarga = produk.Harga * (int)StokNumericUpDown.Value
            };

/*            MessageBox.Show(JsonSerializer.Serialize<Pesanan>(newPesanan));
*/            MessageBox.Show(await newPesanan.Push());

            this.Dispose();
        }

        private void updateTotalHarga(object sender, EventArgs e)
        {
            TotalHargaLabel.Text = (produk.Harga * (int)StokNumericUpDown.Value).ToString();
        }
    }
}
