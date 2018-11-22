using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Historie : Form
	{
		public Historie()
		{
			InitializeComponent();

            var items = Model.Historie.HoleListe;
            var source = new BindingSource
            {
                DataSource = items.Values
            };
            dataGridView1.DataSource = source;
		}

		/// <summary>
		/// Wenn das Fenster geschlossen wird wird die Referenz im Dashboard auf null gesetzt.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HistorieFormClosing(object sender, FormClosingEventArgs e)
		{
			Dashboard.Historie = null;
		}
    }
}
