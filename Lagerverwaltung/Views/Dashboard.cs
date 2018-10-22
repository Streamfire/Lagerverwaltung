using System;
using System.Windows.Forms;

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
		}

		public static Historie Historie { get => _historie; set => _historie = value; }
		public static Regaleinsicht Regaleinsicht { get => _regaleinsicht; set => _regaleinsicht = value; }
		public static Suche Suche { get => _suche; set => _suche = value; }
		public static Verwaltung Verwaltung { get => _verwaltung; set => _verwaltung = value; }



		private bool _adminuser= false;
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
		private void button1_Click(object sender, EventArgs e)
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
		private void button2_Click(object sender, EventArgs e)
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
		private void button3_Click(object sender, EventArgs e)
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
		private void button4_Click(object sender, EventArgs e)
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
