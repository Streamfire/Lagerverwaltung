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
    public partial class Produktliste : Form
    {
        public Produktliste()
        {
            InitializeComponent();
        }

        private void Schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
