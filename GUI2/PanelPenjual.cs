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
            GetProduk();
            GetPesanan();
        }

        async private void tambahProdukButton_Click(object sender, EventArgs e)
        {
            PanelTambahProduk panelTambahProduk = new PanelTambahProduk(p);
            this.Hide();
            panelTambahProduk.ShowDialog();
            this.Show();
            GetProduk();
        }

        async private void GetProduk()
        {
            produkGridView.Rows.Clear(); ;
            foreach (Produk produk in await ShopApiClient.Database.GetProdukList(p))
            {
                produkGridView.Rows.Add(produk.Id, produk.Nama, produk.Harga, produk.Deskripsi);
            }
        }

        async private void GetPesanan()
        {
            produkGridView.Rows.Clear(); ;
            foreach (Pesanan pesanan in await ShopApiClient.Database.GetPesananList(p))
            {
                pesananDataGridView.Rows.Add(pesanan.Pembeli.Nama, pesanan.Produk.Nama, pesanan.stok, pesanan.totalHarga, pesanan.Pembeli.Alamat);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ShopApiClient.Database.Refresh();
            GetProduk();
            GetPesanan();
        }

        private void PanelPenjual_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShopApiClient.Database.Reset();
        }

        private void produkGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PanelEditProduk ppd = new(produkGridView.SelectedRows[0].Cells["ID"].Value.ToString());
                ppd.ShowDialog();
            }
        }

        private void produkGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void namaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}