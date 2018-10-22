using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Regaleinsicht : Form
	{
		public Regaleinsicht()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Wenn das Fenster geschlossen wird wird die Referenz im Dashboard auf null gesetzt.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RegalFormClosing(object sender, FormClosingEventArgs e)
		{
			Dashboard.Regaleinsicht = null;
		}
	}
}
