using System;
using System.Windows.Forms;
using Lagerverwaltung.Model;
using System.Collections.Generic;
using System.Linq;

namespace Lagerverwaltung.Views
{
    public partial class LagerHinzufuegen : Form
    {
        private Dictionary<long, Model.LagertypModel> _lagertypDict;

        private BindingSource source = new BindingSource();

        public LagerHinzufuegen()
        {
            InitializeComponent();

            //DB Daten laden

            _lagertypDict = DB.SqlStatements.HoleLagertyp();

            //Form formatieren
            comboBoxLagertyp.ValueMember = "Lagertyp_ID";
            comboBoxLagertyp.DisplayMember = "Name";

            comboBoxLagertyp.DataSource = _lagertypDict.Values.ToArray();
        }

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void ButtonLagerHinzufügen_Click(object sender, EventArgs e)
		{

            if (textBoxLagerName.Text.Equals("") || textBoxStandort.Text.Equals(""))
            {
                MessageBox.Show("Nicht alle benötigten Felder wurden ausgeführt!", "Fehler beim Hinzufügen des Lagers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DB.SqlStatements.ErstelleLager(textBoxLagerName.Text, comboBoxLagertyp.SelectedText, textBoxBeschreibung.Text, Convert.ToInt64(comboBoxLagertyp.SelectedValue));
                Close();
            }
		}

        private void LagerHinzufuegen_Load(object sender, EventArgs e)
        {


        }
    }
}
