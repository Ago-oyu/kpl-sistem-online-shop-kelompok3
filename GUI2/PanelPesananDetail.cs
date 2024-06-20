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
    public partial class PanelPesananDetail : Form
    {
        String pesananID;
        Pesanan pesanan;

        public PanelPesananDetail(String PesananID)
        {
            InitializeComponent();

            GetData();
        }

        private void PanelPesananDetail_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Trigger trigger = (Trigger)ubahStatus.SelectedIndex;

            StatusPesanan statusBaru = Transition.GetStatusPesanan(pesanan.Status, trigger);
            if (statusBaru == pesanan.Status)
                MessageBox.Show("update status gagal, transisi tidak valid");

            pesanan.Status = statusBaru;
            await pesanan.Push();

            GetData();
        }

        async void GetData()
        {
            pesanan = await Pesanan.Get(pesananID);
            namaProduk.Text = pesanan.Produk.Nama;
            namaPembeli.Text = pesanan.Pembeli.Nama;
            jumlahProduk.Text = pesanan.stok.ToString();
            totalHarga.Text = pesanan.totalHarga.ToString();
            alamatPembeli.Text = pesanan.Pembeli.Alamat;
            statusSaatIni.Text = pesanan.Status.ToString();
        }
    }
    public enum Trigger { terPacking, sampai, diterima }
    public class Transition
    {
        public static Transition[] Transitions = {
            new(StatusPesanan.packing, StatusPesanan.perjalanan, Trigger.terPacking),
            new(StatusPesanan.perjalanan, StatusPesanan.sampai, Trigger.sampai),
            new(StatusPesanan.sampai, StatusPesanan.diterima, Trigger.diterima),
        };

        public StatusPesanan CurrentState;
        public StatusPesanan NextState;
        public Trigger Trigger;
        public Transition(StatusPesanan currentState, StatusPesanan nextState, Trigger trigger)
        {
            CurrentState = currentState;
            NextState = nextState;
            Trigger = trigger;
        }

        public static StatusPesanan GetStatusPesanan(StatusPesanan currentState, Trigger trigger)
        {
            StatusPesanan nextState = currentState;
            for (int i = 0; i < Transitions.Length; i++)
            {
                if (Transitions[i].CurrentState == currentState && Transitions[i].Trigger == trigger)
                    nextState = Transitions[i].NextState;
            }
            return nextState;
        }
    }
}
