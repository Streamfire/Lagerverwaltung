using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
	public partial class Regaleinsicht : Form
	{
		public Regaleinsicht()
		{
			InitializeComponent();
        }

        /// <summary>
        /// Wenn das Fenster geschlossen wird wird die Referenz im Dashboard auf null gesetzt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegalFormClosing(object sender, FormClosingEventArgs e)
		{
			Dashboard.Regaleinsicht = null;
		}

        private void Regaleinsicht_Load(object sender, System.EventArgs e)
        {
            //Daten initialisieren

            comboBoxLager.ValueMember = "LagerID";
            comboBoxLager.DisplayMember = "Name";

            comboBoxRegal.ValueMember = "RegalID";
            comboBoxRegal.DisplayMember = "Name";

            //DB Daten laden



            comboBoxLager.DataSource = new BindingSource(Model.Lager.HoleListe.Values, null);

        }

        private void UpdateComboboxRegal()
        {
            comboBoxRegal.DataSource = new BindingSource(((Model.Lager)comboBoxLager.SelectedItem).Regalliste, null);

            string currentRegal;

            //Eventuell Fehler, falls das ausgewählte Regal nicht in dem Lager enthalten ist
            if ((currentRegal = Dashboard.CurrentRegal) != null) comboBoxRegal.SelectedValue = Model.Regal.HoleNamensliste[currentRegal];
            else comboBoxRegal.SelectedIndex = 0;
        }

        private void UpdateGridView()
        {
            
        }

        private void ButtonZurueck_Click(object sender, System.EventArgs e)
        {
            Hide();
        }

        private void Regaleinsicht_Shown(object sender, System.EventArgs e)
        {

            //Auswahl Lager 1, Regal 1 oder bei Auswahl in Lagerverwaltung -> Auswahl des bereits ausgewählten Regals
            string currentLager;

            if ((currentLager = Dashboard.CurrentLager) != null) comboBoxLager.SelectedValue = Model.Lager.HoleNamensliste[currentLager];
            else comboBoxLager.SelectedIndex = 0;

            UpdateComboboxRegal();
        }
    }
}
