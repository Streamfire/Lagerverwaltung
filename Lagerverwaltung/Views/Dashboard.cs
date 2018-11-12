using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Lagerverwaltung.Core;

namespace Lagerverwaltung.Views
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
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
                new Lager(0, "Lager 0", "draußen", "tolles Ding", 0123456789, 0123456789, new Lagertyp(0, "Typ 0", 0123456789, 0123456789))
            };
            _lagerliste[0].Regalliste = new List<Regal>
            {
                new Regal(0, 0, "A", 5, 4, 0123456789, 0123456789, 10, 30, 10, 5, 4),
                new Regal(0, 0, "B", 5, 4, 0123456789, 0123456789, 10, 30, 10, 5, 4),
                new Regal(0, 0, "C", 5, 4, 0123456789, 0123456789, 10, 30, 10, 5, 4),
                new Regal(0, 0, "D", 5, 4, 0123456789, 0123456789, 10, 30, 10, 5, 4)
            };

            _lagerliste[0].Regalliste[0].Regalfachliste.Add(new Regalfach(0, 0,"00","bla", 0123456789, 0123456789, 5, 6, 12));
			_lagerliste[0].Regalliste[0].Regalfachliste.Add(new Regalfach(1, 0, "01", "blub", 0123456789, 0123456789, 5, 6, 12));


			_lagerliste[0].Regalliste[0].Regalfachliste[0].Paketliste.Add(new Paket(0, 0, "Paket1", "War Notwendig", 10, 1321, 1321, 1451, new Produkt(0, "Koks", "094328", 10.0f, 1000.0f, 123, 1234, new Artikeltyp(0, "Artikel1", 213, 214), 10, 10, 20)));
			_lagerliste[0].Regalliste[0].Regalfachliste[1].Paketliste.Add(new Paket(1, 0, "Paket2", "War Notwendiger ", 10, 1321, 1321, 1451, new Produkt(1, "Nutten", "094329", 10.0f, 1000.0f, 123, 1234, new Artikeltyp(1, "Artikel2", 213, 214), 10, 10, 20)));


			_lagerliste.Add(new Lager(1, "Lager 1", "drinnen", "tolles Ding", 0123456789, 0123456789, new Lagertyp(0, "Typ 0", 0123456789, 0123456789)));
            _lagerliste[1].Regalliste = new List<Regal>
            {
                new Regal(0, 1, "A", 5, 4, 0123456789, 0123456789, 10, 30, 10, 5, 4),
                new Regal(0, 1, "B", 5, 4, 0123456789, 0123456789, 10, 30, 10, 5, 4),
                new Regal(0, 1, "C", 5, 4, 0123456789, 0123456789, 10, 30, 10, 5, 4)
            };

            Verwaltung.UpdateForm(_lagerliste);
		}

		public static Historie Historie { get => _historie; set => _historie = value; }
		public static Regaleinsicht Regaleinsicht { get => _regaleinsicht; set => _regaleinsicht = value; }
		public static Suche Suche { get => _suche; set => _suche = value; }
		public static Verwaltung Verwaltung { get => _verwaltung; set => _verwaltung = value; }
		public static List<Lager> LagerListe { get => _lagerliste; set => _lagerliste = value; }

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
			if(Verwaltung!=null)
			{
				Verwaltung.Show();
			}
			else
			{
				Verwaltung = new Verwaltung();
				Verwaltung.Show();
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
				Suche.Show();
			}
			else
			{
				Suche = new Suche();
				Suche.Show();
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
				Regaleinsicht.Show();
			}
			else
			{
				Regaleinsicht = new Regaleinsicht();
				Regaleinsicht.Show();
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
				Historie.Show();
			}
			else
			{
				Historie = new Historie();
				Historie.Show();
			}
		}
	}
}
