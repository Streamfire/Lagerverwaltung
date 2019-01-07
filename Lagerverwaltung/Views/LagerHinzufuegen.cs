using System;
using System.Windows.Forms;
using Lagerverwaltung.Model;
using System.Collections.Generic;
using System.Linq;

namespace Lagerverwaltung.Views
{
    public partial class LagerHinzufuegen : MetroFramework.Forms.MetroForm
    {
        private Dictionary<long, Model.LagertypModel> _lagertypDict;

        public LagerHinzufuegen()
        {
            InitializeComponent();

            //DB Daten laden

            _lagertypDict = DB.SqlStatements.HoleLagertyp();

            //Form formatieren
            LagertypCombobox.ValueMember = "Lagertyp_ID";
            LagertypCombobox.DisplayMember = "Name";

            LagertypCombobox.DataSource = _lagertypDict.Values.ToArray();
        }

        private void AbbrechenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void LagerHinzufuegenButton_Click(object sender, EventArgs e)
		{
            if (LagertypCombobox.SelectedItem != null){
                if (LagerTextbox.Text.Equals("") || StandortTextbox.Text.Equals(""))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nicht alle benötigten Felder wurden ausgeführt!", "Fehler beim Hinzufügen des Lagers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DB.SqlStatements.ErstelleLager(LagerTextbox.Text, LagertypCombobox.SelectedText, BeschreibungTextbox.Text, Convert.ToInt64(LagertypCombobox.SelectedValue));
                    Close();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Es wurde kein Lagertyp ausgewählt!", "Fehler beim Hinzufügen des Lagers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
		}
    }
}
