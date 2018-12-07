using System;
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
    public partial class PasswortAendern : Form
    {
        public PasswortAendern()
        {
            InitializeComponent();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
