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
        string currentStatusStok = "";

        public PanelPembeli(Pembeli p)
        {
            InitializeComponent();

            this.p = p;
            welcomeLabel.Text = $"Selamat datang {p.Nama}";
            currentStatusStok = "Semua";
/*            statusComboBox.SelectedIndex = 0;
*/            GetProduk();
            GetPesanan();

        }

        async private void GetProduk()
        {

            List<Produk> filteredList = new();

            produkGridView.Rows.Clear();

            MessageBox.Show(currentStatusStok);

            filteredList = await ShopApiClient.Database.GetProdukList();


            if (currentStatusStok != "Semua")
            {

                filteredList = filteredList.Where(produk => produk.Status.ToString() == currentStatusStok).ToList<Produk>();
            }

/*            currentStatusStok = "habis";
            MessageBox.Show((filteredList[0].Status.ToString() == currentStatusStok).ToString());
*/

            if (search.Length > 0)
            {
                filteredList = filteredList.Where(produk => Regex.IsMatch(produk.Nama, $".*{search}.*")).ToList<Produk>();
            }

            foreach (Produk produk in filteredList)
            {
                produkGridView.Rows.Add(produk.Id, produk.IDPenjual, produk.Nama, produk.Harga, produk.Deskripsi, produk.Stok, produk.Status);
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
            currentStatusStok = statusComboBox.Text.ToLower();
            GetProduk();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            search = searchTextBox.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            /*            Enum.TryParse(statusComboBox.Text, out currentStatusStok);
            *//*            currentStatusStok = statusComboBox.Text;
            */

            GetProduk();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {

        }
    }
}