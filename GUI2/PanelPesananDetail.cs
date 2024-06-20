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

        public PanelPesananDetail()
        {
        }

        public PanelPesananDetail(String PesananID)
        {
            InitializeComponent();
        }

        private void PanelPesananDetail_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {

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
