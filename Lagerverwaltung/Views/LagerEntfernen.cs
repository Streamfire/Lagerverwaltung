﻿using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class LagerEntfernen : Form
    {
        public LagerEntfernen()
        {
            InitializeComponent();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
