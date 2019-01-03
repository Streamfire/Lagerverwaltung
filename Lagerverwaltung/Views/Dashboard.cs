using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Lagerverwaltung.Model;

namespace Lagerverwaltung.Views
{
	public partial class Dashboard : Form
	{
        public static Verwaltung Verwaltung { get; set; }
        public static List<Produkt> ProduktListe { get; set; }
        public static List<Artikeltyp> ArtikeltypListe { get; set; }
        public static long CurrentLagerID { get; set; } = -1;
        public static long CurrentRegalID { get; set; } = -1;

        private bool _adminuser = false;

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

		private void Button1_Click(object sender, EventArgs e)
		{
            // Getter & Setter entfernen, aber noch zu tief in den anderen Klassen verankert!
            using (var verwaltung = new Verwaltung())
            {
                verwaltung.ShowDialog();
            }
		}

		private void Button2_Click(object sender, EventArgs e)
		{
            using (var suche = new Suche())
            {
                suche.ShowDialog();
            }
		}

		private void Button3_Click(object sender, EventArgs e)
		{
            using (var regaleinsicht = new Regaleinsicht())
            {
                regaleinsicht.ShowDialog();
            }
        }

		private void Button4_Click(object sender, EventArgs e)
		{
            using (var historie = new Historie())
            {
                historie.ShowDialog();
            }
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
            DialogResult dialog = MessageBox.Show("Möchten Sie das Programm beenden?", "Programm beenden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes)
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
    }
}
