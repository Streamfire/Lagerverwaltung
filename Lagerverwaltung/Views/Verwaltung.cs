using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Verwaltung : Form
	{
		public Verwaltung()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Wenn das Fenster geschlossen wird wird die Referenz im Dashboard auf null gesetzt.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void VerwaltungFormClosing(object sender, FormClosingEventArgs e)
		{
			Dashboard.Verwaltung = null;
		}
	}
}
