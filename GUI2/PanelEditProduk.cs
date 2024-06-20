using DataTypes;
using ShopManagementLib;
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
    public partial class PanelEditProduk : Form
    {
        Produk produk;

        public PanelEditProduk(string produkId)
        {
            InitializeComponent();

            InitField(produkId);
        }

        async void InitField(string id)
        {
            produk = await Produk.Get(id);

            namaTextBox.Text = produk.Nama;
            HargaNumericUpDown.Value = produk.Harga;
            deskripsiTextBox.Text = produk.Deskripsi;
            stokNumericUpDown.Value = produk.Stok;
        }

        private async void updateProdukButton_Click(object sender, EventArgs e)
        {
/*            string namaProduk = namaTextBox.Text;
            int hargaProduk = (int)HargaNumericUpDown.Value;
            string deskripsiProduk = deskripsiTextBox.Text;
            int stokProduk = (int)stokNumericUpDown.Value;
*/
            produk.Nama = namaTextBox.Text;
            produk.Harga = (int)HargaNumericUpDown.Value;
            produk.Deskripsi = deskripsiTextBox.Text;
            produk.Stok = (int)stokNumericUpDown.Value;

            await produk.Push();

            MessageBox.Show($"Detail {produk.Nama} telah diubah");

            ShopRepository.GetShopRepository().Refresh();
            this.Dispose();
        }

        private void batalButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
