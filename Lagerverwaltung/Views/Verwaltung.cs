using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class Verwaltung : Form
	{
		public Verwaltung()
		{
            InitializeComponent();

            // Muss unbedingt geändert werden!
            DB.LagerSQL.HoleAlleLager();
            DB.RegalSQL.HoleAlleRegale();
            DB.RegalfachSQL.HoleAlleRegalfach();
            DB.PaketSQL.HoleAllePakete();
            DB.ProduktSQL.HoleAlleProdukte();

            UpdateForm(Model.Lager.HoleListe);
		}

        private void ButtonRegalHinzufuegen_Click(object sender, System.EventArgs e)
        {
            new RegalHinzufügen().ShowDialog();
        }

        private void ButtonLagerHinzufuegen_Click(object sender, System.EventArgs e)
        {
            new LagerHinzufuegen().ShowDialog();
        }

        private void ButtonPaketHinzufuegen_Click(object sender, System.EventArgs e)
        {
            new PaketHinzufuegen().ShowDialog();
        }
        private void ButtonPaketEntfernen_Click(object sender, System.EventArgs e)
        {
            new PaketEntfernen().ShowDialog();
        }
        private void ButtonRegalEntfernen_Click(object sender, System.EventArgs e)
        {
            new RegalAendern_Entfernen().ShowDialog();
        }
        private void ButtonLagerEntfernen_Click(object sender, System.EventArgs e)
        {
            new LagerEntfernen().ShowDialog();
        }
        private void ButtonZurück_Click(object sender, System.EventArgs e)
        {
            Model.Lager.Reset();
            Model.Regal.Reset();
            Model.Regalfach.Reset();
            Model.Paket.Reset();
            Model.Produkt.Reset();
            Close();
        }

        private void ButtonPaketUmlagern_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonLagerungOptimieren_Click(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
