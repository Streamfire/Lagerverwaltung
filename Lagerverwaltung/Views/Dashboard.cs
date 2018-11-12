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
				Verwaltung.ShowDialog();
			}
			else
			{
				Verwaltung = new Verwaltung();
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
	}
}
