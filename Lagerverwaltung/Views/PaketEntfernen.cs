using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Lagerverwaltung.Views
{
    public partial class PaketEntfernen : MetroFramework.Forms.MetroForm
    {
        public long RegalfachID { get; set; } = -1;
        private Dictionary<long, Model.PaketModel> _dictPaket;
        //private Dictionary<long, Model.ProduktModel> _dictProdukt;
        private Model.ProduktModel _produkt;

        public PaketEntfernen()
        {
            InitializeComponent();
            DB.SqlStatements.DatabaseChanged += DataChanged;
        }

        private void PaketEntfernen_Load(object sender, EventArgs e)
        {
            if (RegalfachID >= 0)
            {
                _dictPaket = DB.SqlStatements.HolePaket(-1, RegalfachID, "", -1);

                //Pakete in Combobox eintragen
                ComboBoxPaketEntfernen.ValueMember = "Paket_ID";
                ComboBoxPaketEntfernen.DisplayMember = "Name";

                ComboBoxPaketEntfernen.DataSource = new BindingSource().DataSource = _dictPaket.Values.ToArray();

                if (_dictPaket.Count > 0)
                {
                    ComboBoxPaketEntfernen.SelectedIndex = 0;
                }
            }
        }

        private void ComboBoxPaketEntfernen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxPaketEntfernen.SelectedIndex >= 0)
            {
                _produkt = DB.SqlStatements.HoleProdukt(((Model.PaketModel)ComboBoxPaketEntfernen.SelectedItem).Produkt_ID, "", 1).First().Value;

                LabelMenge.Text = _dictPaket[(long)ComboBoxPaketEntfernen.SelectedValue].Menge.ToString();
                LabelProdukt.Text = _produkt.Name;
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
            DB.SqlStatements.LoeschePaket((long)ComboBoxPaketEntfernen.SelectedValue);
            Close();
        }


    }
}
