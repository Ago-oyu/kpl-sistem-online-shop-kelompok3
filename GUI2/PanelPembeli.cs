﻿using DataTypes;
using ShopManagementLib;
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
        string currentStatusStok = "semua";

        ShopRepository shopRepository = ShopRepository.GetShopRepository();

        public PanelPembeli(Pembeli p)
        {
            InitializeComponent();

            this.p = p;
            welcomeLabel.Text = $"Selamat datang {p.Nama}";
            GetProduk();
            GetPesanan();
        }

        async private void GetProduk()
        {
            produkGridView.Rows.Clear();

            List<Produk> filteredList = await shopRepository.GetProdukList();


            if (currentStatusStok != "semua")
            {
                filteredList = filteredList.Where(produk => produk.Status.ToString() == currentStatusStok).ToList();
            }


            if (search.Length > 0)
            {
                filteredList = filteredList.Where(produk => Regex.IsMatch(produk.Nama, $".*{search}.*")).ToList();
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
            foreach (Pesanan pesanan in await shopRepository.GetPesananList(p))
            {
                pesananDataGridView.Rows.Add(pesanan.Penjual.Nama, pesanan.Produk.Nama, pesanan.stok,
                    pesanan.totalHarga, pesanan.Pembeli.Alamat, pesanan.Status);
            }
            pesananDataGridView.ClearSelection();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            shopRepository.Refresh();
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
            shopRepository.Reset();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentStatusStok = statusComboBox.Text.ToLower();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            search = searchTextBox.Text;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            currentStatusStok = statusComboBox.Text.ToLower();

            GetProduk();
        }

        private void HomePage_Click(object sender, EventArgs e)
        {

        }         
    }
}