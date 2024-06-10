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
    public partial class PanelPembeli : Form
    {
        Pembeli p;
        List<Produk> lp;
        public PanelPembeli(Pembeli p)
        {
            InitializeComponent();

            this.p = p;
            welcomeLabel.Text = $"Selamat datang {p.Nama}";
            GetProduk();
        }

        async private void GetProduk()
        {
            lp = await Produk.GetPage();
            produkGridView.Rows.Clear(); ;
            foreach (Produk produk in lp)
            {
                produkGridView.Rows.Add(produk.Id, produk.IDPenjual, produk.Nama, produk.Harga, produk.Deskripsi);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GetProduk();
        }

        private async void selectProduk(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PanelProdukDetail ppd = new(produkGridView.SelectedRows[0].Cells["ID"].Value.ToString(),
                    produkGridView.SelectedRows[0].Cells["penjualId"].Value.ToString(),
                    p);
                ppd.ShowDialog();
            }
        }
    }
}