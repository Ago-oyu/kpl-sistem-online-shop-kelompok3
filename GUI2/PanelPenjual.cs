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

        }

        async private void tambahProdukButton_Click(object sender, EventArgs e)
        {
            string namaProduk = namaTextBox.Text;
            int hargaProduk = (int)HargaNumericUpDown.Value;
            string deskripsiProduk = deskripsiTextBox.Text;
            int stokProduk = (int)stokNumericUpDown.Value;
            Produk newProduk = new Produk()
            {
                Id = DataTypes.Produk.CreateGUID(),
                Nama = namaProduk,
                Harga = hargaProduk,
                Deskripsi = deskripsiProduk,
                Stok = stokProduk,
                IDPenjual = p.Id
            };
            
            // (Nanti) Tambahin error condintion
            ShopApiClient.Database.AddProduk(newProduk);
            MessageBox.Show(await newProduk.Push());
            GetProduk();
        }

        async private void GetProduk()
        {
            produkGridView.Rows.Clear(); ;
            foreach (Produk produk in await ShopApiClient.Database.GetProdukList(p))
            {
                produkGridView.Rows.Add(produk.Nama, produk.Harga, produk.Deskripsi);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ShopApiClient.Database.Refresh();
            GetProduk();
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