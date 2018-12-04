using System;
using System.Windows.Forms;
using Lagerverwaltung.Model;

namespace Lagerverwaltung.Views
{
    public partial class LagerHinzufuegen : Form
    {
        public LagerHinzufuegen()
        {
            InitializeComponent();

            //DB Daten laden
            DB.LagertypSQL.HoleAlleLagertyp();

            //Form formatieren
            comboBoxLagertyp.ValueMember = "LagertypID";
            comboBoxLagertyp.DisplayMember = "Name";

            comboBoxLagertyp.DataSource = new BindingSource(Lagertyp.HoleListe.Values,null);

            comboBoxLagertyp.SelectedItem = 0;
            
        }

        private void ButtonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void ButtonLagerHinzufügen_Click(object sender, EventArgs e)
		{

            if (textBoxLagerName.Text.Equals("") || textBoxStandort.Text.Equals(""))
            {
                MessageBox.Show("Nicht alle benötigten Felder wurden ausgeführt!", "Fehler beim Hinzufügen des Lagers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Lager in DB einfügen
                DB.LagerSQL.ErstelleLager(textBoxLagerName.Text, (short)Lagertyp.HoleNamensliste[comboBoxLagertyp.Text], textBoxStandort.Text, textBoxBeschreibung.Text);

                //TODO: Entfernen, sobald das Hauptfenster nur noch die Daten aus der DB liest 
                new Lager((ushort)Lager.HoleListe.Count, textBoxLagerName.Text, new DateTime(), new DateTime(), 0, this.textBoxStandort.Text, this.textBoxBeschreibung.Text);
                //END TODO


                //Dashboard.Verwaltung.UpdateForm(Model.Lager.HoleListe);
                this.Close();
            }
		}

        private void LagerHinzufuegen_Load(object sender, EventArgs e)
        {


        }
    }
}
