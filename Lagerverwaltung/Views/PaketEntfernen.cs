using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Lagerverwaltung.Views
{
    public partial class PaketEntfernen : Form
    {
        public long RegalfachID { get; set; } = -1;
        private Dictionary<long, Model.PaketModel> _dictPaket;

        public PaketEntfernen()
        {
            InitializeComponent();
            DB.SqlStatements.DatabaseChanged += DataChanged;

            if (RegalfachID >= 0)
            {
                _dictPaket =  DB.SqlStatements.HolePaket(-1, RegalfachID, "", -1);

                //Pakete in Combobox eintragen
                comboBoxPaketEntfernen.ValueMember = "Paket_ID";
                comboBoxPaketEntfernen.DisplayMember = "Name";

                comboBoxPaketEntfernen.DataSource = new BindingSource().DataSource = _dictPaket.Values.ToArray();
            }

        }

        private void DataChanged(object sender, EventArgs e)
        {
            var type = (DB.SqlStatements.ModeltypEnum)sender;
        }

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAuslagern_Click(object sender, EventArgs e)
        {

        }
    }
}
