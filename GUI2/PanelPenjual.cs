using Backend;
using DataTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
        private string selectedProdukID;
        string currentJumlahPesanan = "semua";

        public PanelPenjual(Penjual p)
        {
            InitializeComponent();

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
            refreshButton_Click(sender, e);
        }

        async private void GetProduk()
        {
            produkGridView.Rows.Clear();
            foreach (Produk produk in await ShopApiClient.Database.GetProdukList(p))
            {
                produkGridView.Rows.Add(produk.Id, produk.Nama, produk.Harga, produk.Deskripsi);
            }
            produkGridView.ClearSelection();
            selectedProdukID = null;
        }

        async private void GetPesanan()
        {
            pesananDataGridView.Rows.Clear();


            List<Pesanan> filteredList = await ShopApiClient.Database.GetPesananList(p, currentJumlahPesanan);

            foreach (Pesanan pesanan in filteredList)
            {
                pesananDataGridView.Rows.Add(pesanan.Pembeli.Nama, pesanan.Produk.Nama, pesanan.stok,
                    pesanan.totalHarga, pesanan.Pembeli.Alamat, pesanan.Produk.Id,
                    pesanan.Status
                );
            }
            pesananDataGridView.ClearSelection();
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
                PanelEditProduk ppd = new(selectedProdukID);
                ppd.ShowDialog();
                refreshButton_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in pesananDataGridView.Rows)
            {
                if (row.Cells["ProdukID"].Value.Equals(selectedProdukID))
                {
                    MessageBox.Show("Produk sedang dipesan. Selesaikan atau Batalkan pesanan.");
                    return;
                }
            }
            ShopApiClient.Database.DeleteProduk(selectedProdukID);
            refreshButton_Click(sender, e);
        }

        private void produkGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedProdukID = produkGridView.SelectedRows[0].Cells["ID"].Value.ToString();
            }
        }

        private void jumlahPesananComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentJumlahPesanan = jumlahPesananComboBox.Text.ToLower();
        }

        private void pesananDataGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedPesananID = pesananDataGridView.SelectedRows[0].Cells["ID"].Value.ToString();
                PanelPesananDetail panelPesananDetail = new PanelPesananDetail(selectedPesananID);
                panelPesananDetail.ShowDialog();
            }

        }
    }
}