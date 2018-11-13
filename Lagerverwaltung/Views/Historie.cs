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

            var task = new Task(() => Test());
            task.Start();
		}

        public void Test()
        {
            var source = new BindingSource();
            try
            {
                var historie = DB.HistorieSQL.HoleHistorie();
                source.DataSource = historie;
                dataGridView1.DataSource = source;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Bitte vorher die PostgreSQL Datenbank starten um die Historie zu füllen!", "Hinweis", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
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
