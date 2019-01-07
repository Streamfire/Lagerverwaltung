using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Lagerverwaltung.Model;

namespace Lagerverwaltung.Views
{
	public partial class Dashboard : MetroFramework.Forms.MetroForm
	{
        public static Verwaltung Verwaltung { get; set; }
        public static List<Produkt> ProduktListe { get; set; }
        public static List<Artikeltyp> ArtikeltypListe { get; set; }
        public static long CurrentLagerID { get; set; } = -1;
        public static long CurrentRegalID { get; set; } = -1;

        private bool _adminuser = false;

        Form suche = null;
        Form verwaltung = null;
        Form historie = null;
        Form regaleinsicht = null;

        public Dashboard(bool adminuser)
		{
			InitializeComponent();
			_adminuser = adminuser;

            ProduktListe = Produkt.GetProdukts();
            ArtikeltypListe = Artikeltyp.GetArtikeltyps();
		}

        private void DashFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void VerwaltungKachel_Click(object sender, EventArgs e)
		{
            if (verwaltung == null || verwaltung.IsDisposed == true)
            {
                verwaltung = new Verwaltung();
                verwaltung.Show();
            }
            else
            {

            }
            // Getter & Setter entfernen, aber noch zu tief in den anderen Klassen verankert!
            /*
            using (var verwaltung = new Verwaltung())
            {
                verwaltung.ShowDialog();
            }*/

        }

		private void SucheKachel_Click(object sender, EventArgs e)
		{
            if (suche == null ||suche.IsDisposed == true)
            {
                suche = new Suche();
                suche.Show();
            }
            else
            {
                
            }
            /*
            using (var suche = new Suche())
            {
                suche.ShowDialog();
            }*/
		}

		private void RegaleinsichtKachel_Click(object sender, EventArgs e)
		{
            if (regaleinsicht == null || regaleinsicht.IsDisposed == true)
            {
                regaleinsicht = new Regaleinsicht();
                regaleinsicht.Show();
            }
            else
            {

            }
            /*
            using (var regaleinsicht = new Regaleinsicht())
            {
                regaleinsicht.ShowDialog();
            }*/
        }

		private void HistorieKachel_Click(object sender, EventArgs e)
		{
            if (historie == null || historie.IsDisposed == true)
            {
                historie = new Historie();
                historie.Show();
            }
            else
            {

            }
            /*
            using (var historie = new Historie())
            {
                historie.ShowDialog();
            }*/
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var aboutbox = new AboutBox())
            {
                aboutbox.ShowDialog();
            }
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Möchten Sie das Programm beenden?", "Programm schließen", MessageBoxButtons.YesNo,MessageBoxIcon.Information,150);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void BeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NutzerHinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var nutzerhinzufuegen = new NutzerHinzufuegen())
            {
                nutzerhinzufuegen.ShowDialog();
            }
        }

        private void LagertypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var lagertyp = new LagertypForm())
            {
                lagertyp.ShowDialog();
            }
        }

        private void RegaltypToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var regaltyp = new ArtikeltypForm())
            {
                regaltyp.ShowDialog();
            }
        }
    }
}
