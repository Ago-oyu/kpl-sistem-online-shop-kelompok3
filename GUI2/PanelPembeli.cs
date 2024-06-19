using DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PanelPembeli : Form
    {
        Pembeli p;
        string search = "";

        enum statusStok { Semua, Habis, Sedikit, Banyak }
        int[] batasStatus = { -1, 0, 10, int.MaxValue };

        statusStok currentStatusStok;
        public PanelPembeli(Pembeli p)
        {
            InitializeComponent();

            this.p = p;
            welcomeLabel.Text = $"Selamat datang {p.Nama}";

            currentStatusStok = statusStok.Semua;

            GetProduk();
            GetPesanan();
        }

        async private void GetProduk()
        {

            List<Produk> filteredList = new();

            produkGridView.Rows.Clear();
            if (currentStatusStok == statusStok.Semua)
            {

                filteredList = await ShopApiClient.Database.GetProdukList();

/*                foreach (Produk produk in await ShopApiClient.Database.GetProdukList())
                {
                    produkGridView.Rows.Add(produk.Id, produk.IDPenjual, produk.Nama, produk.Harga, produk.Deskripsi, produk.Stok);
                }
*/            }
            else
            {
                foreach (Produk produk in await ShopApiClient.Database.GetProdukList())
                {
/*                    if (produk.Stok <= batasStatus[(int)currentStatusStok] && produk.Stok > batasStatus[(int)currentStatusStok - 1])

                        filteredList.Add(produk);
*/                    
                    filteredList = filteredList.Where(
                        produk => produk.Stok <= batasStatus[(int)currentStatusStok] && produk.Stok > batasStatus[(int)currentStatusStok - 1]
                    ).ToList<Produk>();
                }
            }

            if (search.Length > 0)
            {
                filteredList = filteredList.Where(produk => Regex.IsMatch(produk.Nama, $".*{search}.*")).ToList<Produk>();
            }

            foreach (Produk produk in filteredList)
            {
                produkGridView.Rows.Add(produk.Id, produk.IDPenjual, produk.Nama, produk.Harga, produk.Deskripsi, produk.Stok);
            }
            produkGridView.ClearSelection();
        }

        async private void GetPesanan()
        {
            pesananDataGridView.Rows.Clear(); ;
            foreach (Pesanan pesanan in await ShopApiClient.Database.GetPesananList(p))
            {
                pesananDataGridView.Rows.Add(pesanan.Penjual.Nama, pesanan.Produk.Nama, pesanan.stok,
                    pesanan.totalHarga, pesanan.Pembeli.Alamat, pesanan.Status);
            }
            pesananDataGridView.ClearSelection();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ShopApiClient.Database.Refresh();
            GetProduk();
            GetPesanan();
        }

        private async void selectProduk(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PanelProdukDetail ppd = new(produkGridView.SelectedRows[0].Cells["ID"].Value.ToString(),
                    produkGridView.SelectedRows[0].Cells["penjualId"].Value.ToString(),
                    p);
                ppd.ShowDialog();
                refreshButton_Click(sender, e);
            }
        }

        private void PanelPembeli_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShopApiClient.Database.Reset();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(statusComboBox.Text, out currentStatusStok);
            GetProduk();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            search = searchTextBox.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            GetProduk();
        }
    }
}