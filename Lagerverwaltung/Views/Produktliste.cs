using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class Produktliste : MetroFramework.Forms.MetroForm
    {
        private Dictionary<long, Model.ProduktModel> _dictProdukt;

        private BindingSource source = new BindingSource();

        public Produktliste()
        {
            InitializeComponent();

            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            UpdateForm();

        }
		public void UpdateForm()
        {
            _dictProdukt = DB.SqlStatements.HoleProdukt();
            dataGridView1.DataSource = _dictProdukt.Values.ToArray();

            //dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;

            dataGridView1.Columns[4].Visible = false;

            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            dataGridView1.Columns[11].Visible = false;
        }

        private void Schliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Produkt_hinzufuegen_Click(object sender, EventArgs e)
        {
            using (var produkthinzufuegen = new ProduktHinzufuegen())
            {
                produkthinzufuegen.Besitzer = this;
                produkthinzufuegen.ShowDialog();
            }
        }

        /// <summary>
        /// Übergibt Produktame und Produkt-ID an PaketHinzufügen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Auswaehlen_Click(object sender, EventArgs e)
		{
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["name"].Value);

            PaketHinzufuegen.Auswahl = a;

            PaketHinzufuegen.ProduktID = Convert.ToInt64(selectedRow.Cells["produkt_id"].Value);

            Close();
		}

        /// <summary>
        /// Übergibt die ausgewählten Produktdaten an ProduktÄndern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            ProduktAendern.produkt_id = Convert.ToString(selectedRow.Cells["produkt_id"].Value);
            ProduktAendern.name = Convert.ToString(selectedRow.Cells["name"].Value);
            ProduktAendern.zeichnungsnummer = Convert.ToString(selectedRow.Cells["zeichnungsnummer"].Value);
            ProduktAendern.gewicht = Convert.ToString(selectedRow.Cells["gewicht"].Value);
            ProduktAendern.preis = Convert.ToString(selectedRow.Cells["preis"].Value);
            ProduktAendern.hoehe = Convert.ToString(selectedRow.Cells["hoehe"].Value);
            ProduktAendern.breite = Convert.ToString(selectedRow.Cells["breite"].Value);
            ProduktAendern.laenge = Convert.ToString(selectedRow.Cells["laenge"].Value);
            ProduktAendern.artikeltyp_id = Convert.ToString(selectedRow.Cells["artikeltyp_id"].Value);

            using (var produktaendern = new ProduktAendern())
            {
                produktaendern.Besitzer = this;
                produktaendern.ShowDialog();
            }
        }
    }

    
}
