using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class ProduktlisteSuche : MetroFramework.Forms.MetroForm
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

            _dictProdukt = DB.SqlStatements.HoleProdukt();

            UpdateForm();

        }
		public void UpdateForm()
        {
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

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxProdukt.Text))
            {
                _dictProdukt = DB.SqlStatements.HoleProdukt(-1, textBoxProdukt.Text);
                UpdateForm();
            }
            else
            {
                _dictProdukt = DB.SqlStatements.HoleProdukt();
                UpdateForm();
            }
        }
    }
}
