using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lagerverwaltung.Views
{
    public partial class LagerEntfernen : MetroFramework.Forms.MetroForm
    {
        private Dictionary<long, Model.LagerModel> _lagerDict;
        private Dictionary<long, Model.RegalModel> _regalDict;
        private Dictionary<long, Model.RegalfachModel> _regalfachDict;
        private Dictionary<long, Model.PaketModel> _paketDict;

        private static long[] regalKeys;
        private static long[][] regalfachKeys;
        private static long[][] paketKeys;

        public LagerEntfernen()
        {

            InitializeComponent();


            _lagerDict = DB.SqlStatements.HoleLager();

            LagerCombobox.ValueMember = "Lager_ID";
            LagerCombobox.DisplayMember = "Name";

            LagerCombobox.DataSource = _lagerDict.Values.ToArray();
        }

        private void AbbrechenButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HinzufuegenButton_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Wollen sie das ausgewählte Lager wirklich entfernen?", "Lager entfernen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                regalKeys = DB.SqlStatements.HoleRegal(-1, Convert.ToInt64(LagerCombobox.SelectedValue)).Keys.ToArray();

                regalfachKeys = new long[regalKeys.Length][];
                for (int i = 0; i < regalKeys.Length; i++)
                {
                    regalfachKeys[i] = DB.SqlStatements.HoleRegalfach(-1, regalKeys[i]).Keys.ToArray();
                }

                int regalfachCount = 0;
                for (int i = 0; i < regalfachKeys.GetLength(0); i++)
                {
                    regalfachCount += regalfachKeys[i].Length;
                }
                paketKeys = new long[regalfachCount][];

                int k = 0;
                for (int i = 0; i < regalfachKeys.GetLength(0); i++)
                {
                    for (int j = 0; j < regalfachKeys[i].Length; j++)
                    {
                        paketKeys[k] = DB.SqlStatements.HolePaket(-1, regalfachKeys[i][j]).Keys.ToArray();

                        k++;
                    }
                }


                if (paketKeys.GetLength(0) != 0)
                {
                    for (int i = 0; i < paketKeys.GetLength(0); i++)
                    {
                        if (paketKeys[i].Length != 0)
                        {
                            for (int j = 0; j < paketKeys[i].Length; j++)
                            {
                                DB.SqlStatements.LoeschePaket(paketKeys[i][j]);
                            }
                        }
                    }
                }

                if (regalfachKeys.GetLength(0) != 0)
                {
                    for (int i = 0; i < regalfachKeys.GetLength(0); i++)
                    {
                        if (regalfachKeys[i].Length != 0)
                        {
                            for (int j = 0; j < regalfachKeys[i].Length; j++)
                            {
                                DB.SqlStatements.LoescheRegalfach(regalfachKeys[i][j]);
                            }
                        }
                    }
                }

                if (regalKeys.Length != 0)
                {
                    for (int i = 0; i < regalKeys.Length; i++)
                    {

                        DB.SqlStatements.LoescheRegal(regalKeys[i]);
                    }
                }

                DB.SqlStatements.LoescheLager(Convert.ToInt64(LagerCombobox.SelectedValue));

                Close();
            }
            else
            {

            }
        }
    }
}