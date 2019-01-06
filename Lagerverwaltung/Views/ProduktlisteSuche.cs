using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class ProduktlisteSuche : Form
    {
        private Dictionary<long, Model.ProduktModel> _dictProdukt;

        private BindingSource source = new BindingSource();

        public ProduktlisteSuche()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ClearSelection();

            DB.SqlStatements.DatabaseChanged += DataChanged;

            UpdateForm();

        }
		public void UpdateForm()
        {
            _dictProdukt = DB.SqlStatements.HoleProdukt();
            dataGridView1.DataSource = _dictProdukt.Values.ToArray();
        }

        private void DataChanged(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void Schliessen_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
