﻿using System;
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
                ComboBoxPaketEntfernen.ValueMember = "Paket_ID";
                ComboBoxPaketEntfernen.DisplayMember = "Name";

                ComboBoxPaketEntfernen.DataSource = new BindingSource().DataSource = _dictPaket.Values.ToArray();

                if(_dictPaket.Count > 0)
                    ComboBoxPaketEntfernen.SelectedIndex = 0;
            }
        }

        private void ComboBoxPaketEntfernen_SelectedIndexChanged(object sender, EventArgs e)
        {

            LabelMenge.Text = _dictPaket[(long)ComboBoxPaketEntfernen.SelectedValue].Menge.ToString();
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
