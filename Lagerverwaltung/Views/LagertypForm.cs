﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class LagertypForm : MetroFramework.Forms.MetroForm
    {
        public LagertypForm()
        {
            InitializeComponent();
        }

        private void MetroButtonOkay_Click(object sender, EventArgs e)
        {

        }

        private void MetroButtonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        
        }
    }
}
