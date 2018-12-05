using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Suche : Form
	{
        private ReadOnlyDictionary<ulong, Model.Suche> readonly_dict;

        private List<Model.Suche> _result = new List<Model.Suche>();
        private BindingSource source = new BindingSource();

        public Suche()
		{
			InitializeComponent();

            readonly_dict = Model.Suche.HoleSuchergebnisse;

            UpdateDataGridView();

        }
        private void UpdateDataGridView(List<Model.Historie> list = null)
        {
            if (list == null)
            {
                source.DataSource = readonly_dict.Values;
            }
            else
            {
                source.DataSource = list;
            }
            dataGridView1.DataSource = source;
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
            this.Hide();
        }

        
    }
}
