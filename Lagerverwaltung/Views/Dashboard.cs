using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Lagerverwaltung.Model;

namespace Lagerverwaltung.Views
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();

			Verwaltung = new Verwaltung();
			Suche = new Suche();
			Regaleinsicht = new Regaleinsicht();
			Historie = new Historie();


			ProduktListe = Model.Produkt.GetProdukts();
			ArtikeltypListe = Model.Artikeltyp.GetArtikeltyps();
		}
		public Dashboard(bool adminuser)
		{
			InitializeComponent();
			_adminuser = adminuser;

			Verwaltung = new Verwaltung();
			Suche = new Suche();
			Regaleinsicht = new Regaleinsicht();
			Historie = new Historie();

            //Testdaten
            _lagerliste = new List<Lager>
            {
                new Lager(0, "Lager 0", new DateTime(), new DateTime(), 0,"draußen", "tolles Ding")
            };
            _lagerliste[0].Regalliste = new List<Regal>
            {
                new Regal(0, 0, "A", 5, 4, new DateTime(), new DateTime(), 10, 30, 10, 5, 4),
                new Regal(0, 0, "B", 5, 4, new DateTime(), new DateTime(), 10, 30, 10, 5, 4),
                new Regal(0, 0, "C", 5, 4, new DateTime(), new DateTime(), 10, 30, 10, 5, 4),
                new Regal(0, 0, "D", 5, 4, new DateTime(), new DateTime(), 10, 30, 10, 5, 4)
            };

            _lagerliste[0].Regalliste[0].Regalfachliste.Add(new Regalfach(0, 0,"00", new DateTime(), new DateTime(), 5, 6, 12, "bla"));
			_lagerliste[0].Regalliste[0].Regalfachliste.Add(new Regalfach(1, 0, "01", new DateTime(), new DateTime(), 5, 6, 12, "blub"));


			_lagerliste[0].Regalliste[0].Regalfachliste[0].Paketliste.Add(new Paket(0, 0, "Paket1", 10, new DateTime(), new DateTime(), new DateTime(), 0,5,10,8, "War Notwendig"));
			_lagerliste[0].Regalliste[0].Regalfachliste[1].Paketliste.Add(new Paket(1, 0, "Paket2", 10, new DateTime(), new DateTime(), new DateTime(), 0, 5, 10, 8, "War Notwendiger "));


			_lagerliste.Add(new Lager(1, "Lager 1", new DateTime(), new DateTime(), 1, "drinnen", "tolles Ding"));
            _lagerliste[1].Regalliste = new List<Regal>
            {
                new Regal(0, 1, "A", 5, 4, new DateTime(), new DateTime(), 10, 30, 10, 5, 4),
                new Regal(0, 1, "B", 5, 4, new DateTime(), new DateTime(), 10, 30, 10, 5, 4),
                new Regal(0, 1, "C", 5, 4, new DateTime(), new DateTime(), 10, 30, 10, 5, 4)
            };

            _lagerliste.Add(new Lager(2, "Lager 2", new DateTime(), new DateTime(), 0, "Berlin", "viel besser als die Anderen"));

            //TEST
            ProduktListe = new List<Produkt> {
                
                new Model.Produkt(0, "DeWalt Schrauber", "DT71572-QZ", 0.581f, 11.99f, new DateTime(), new DateTime(), 0, 400, 600, 800),
                new Model.Produkt(1, "Scheppach Dekupiersägeblatt-Set", "6206P", 0.200f, 19.99f, new DateTime(), new DateTime(), 0, 1000, 2000, 500),
                new Model.Produkt(2, "Erbauer T144DP Stichsägeblatt", "7153K", 0.055f, 2.19f, new DateTime(), new DateTime(), 0, 300, 100, 100),
                new Model.Produkt(3, "Ponal SUPER 3 Holzleim", "PN 15S 120", 0.12f, 6.89f, new DateTime(), new DateTime(), 0, 500, 500, 500)

            };

            ArtikeltypListe = new List<Artikeltyp>
            {
                //TEST
                new Model.Artikeltyp(0, "bla", new DateTime(), new DateTime()),
                new Model.Artikeltyp(1, "blubb", new DateTime(), new DateTime()),
                new Model.Artikeltyp(2, "blablubb", new DateTime(), new DateTime()),
                new Model.Artikeltyp(3, "bliblubbbla", new DateTime(), new DateTime())
            };

			
            Verwaltung.UpdateForm(Model.Lager.HoleListe);
		}

		public static Historie Historie { get => _historie; set => _historie = value; }
		public static Regaleinsicht Regaleinsicht { get => _regaleinsicht; set => _regaleinsicht = value; }
		public static Suche Suche { get => _suche; set => _suche = value; }
		public static Verwaltung Verwaltung { get => _verwaltung; set => _verwaltung = value; }
		public static List<Lager> LagerListe { get => _lagerliste; set => _lagerliste = value; }
        public static List<Produkt> ProduktListe { get ; set; }
        public static List<Artikeltyp> ArtikeltypListe { get; set; }
        public static string CurrentLager { get; set; }
        public static string CurrentRegal { get; set; }


		private bool _adminuser= false;
		private static List<Lager> _lagerliste;
		private static Historie _historie = null;
		private static Regaleinsicht _regaleinsicht = null;
		private static Suche _suche = null;
		private static Verwaltung _verwaltung=null;

		private void DashFormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Verwaltung öffnen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Button1_Click(object sender, EventArgs e)
		{
			if (Verwaltung != null)
			{

				Verwaltung.UpdateForm(Model.Lager.HoleListe);
				Verwaltung.ShowDialog();
			}
			else
			{
				Verwaltung = new Verwaltung();
				Verwaltung.UpdateForm(Model.Lager.HoleListe);
				Verwaltung.ShowDialog();

			}
		}

		/// <summary>
		/// Suche öffnen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Button2_Click(object sender, EventArgs e)
		{
			if (Suche != null)
			{
				Suche.ShowDialog();
			}
			else
			{
				Suche = new Suche();
				Suche.ShowDialog();
			}
		}

		/// <summary>
		/// Regaleinsicht öffnen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Button3_Click(object sender, EventArgs e)
		{
			if (Regaleinsicht != null)
			{
				Regaleinsicht.ShowDialog();
			}
			else
			{
				Regaleinsicht = new Regaleinsicht();
				Regaleinsicht.ShowDialog();
			}
		}

		/// <summary>
		/// Historie öffnen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Button4_Click(object sender, EventArgs e)
		{
			if (Historie != null)
			{
				Historie.ShowDialog();
			}
			else
			{
				Historie = new Historie();
				Historie.ShowDialog();
			}
		}

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
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
            this.Close();
        }
    }
}
