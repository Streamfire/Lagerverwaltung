using Lagerverwaltung.Core;
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
    public partial class RegalHinzufügen : Form
    {
        public RegalHinzufügen()
        {
            InitializeComponent();
			
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void buttonRegalHinzufuegen_Click(object sender, EventArgs e)
		{
			byte zeilen = Convert.ToByte(this.textBoxZeilen.Text);
			byte spalten = Convert.ToByte(this.textBoxSpalten.Text);

			Regal n = new Regal(0, 0, this.textBoxRegalName.Text,zeilen,spalten, 123, 123, 0, 0, 0, 0, 0);

			for (int z = 0; z < zeilen; z++)
			{
				for (int s = 0; s <spalten;  s++)
				{
					n.Regalfachliste.Add(new Regalfach((ushort)(z * s + s), 0, "" + z + ";" + s, 12, 12, 0, 0, 0, ""));

				}
			}


			

			Dashboard.LagerListe[Dashboard.Verwaltung.getActiveTabIndex()].Regalliste.Add(n);

			Dashboard.Verwaltung.UpdateForm(Dashboard.LagerListe);
			this.Close();
		}
	}
}
