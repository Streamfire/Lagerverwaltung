using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Suche : Form
	{
		public Suche()
		{
			InitializeComponent();
		}


		/// <summary>
		/// Wenn das Fenster geschlossen wird wird die Referenz im Dashboard auf null gesetzt.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SucheFormClosing(object sender, FormClosingEventArgs e)
		{
			Dashboard.Suche = null;
		}

        private void buttonAbbrechen_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        
    }
}
