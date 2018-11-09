using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class PaketHinzufügen : Form
    {
        public PaketHinzufügen()
        {
            InitializeComponent();
        }
        public static Produktliste Produktliste { get => _produktliste; set => _produktliste = value; }
        private static Produktliste _produktliste = null;

        private void buttonProduktAuswaehlen_Click(object sender, EventArgs e)
        {
            if (Produktliste != null)
            {
                Produktliste.ShowDialog(this);

            }
            else
            {
                Produktliste = new Produktliste();
                Produktliste.ShowDialog();
            }
        }
        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}