using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Lagerverwaltung.Model
{
	public sealed class Lagertyp
    {
        public ushort LagertypID { get; }
        public string Name { get; set; }
        public DateTime ErstelltAm { get; set; }
        public DateTime GeaendertAm { get; set; }

        private static List<Lagertyp> _list = new List<Lagertyp>();
        public static event EventHandler<EventArgs> LagertypHinzugefuegt;
        public static event EventHandler<EventArgs> LagertypEntfernt;

        public Lagertyp(ushort lagertyp_id, string name, DateTime erstellt_am, DateTime geaendert_am)
        {
            Contract.Requires(lagertyp_id >= 1);
            Contract.Requires(name.Length <= 20);   // plus minimal Länge laut Data Dictionary später
            LagertypID = lagertyp_id;
            Name = name;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;

            Hinzufuegen(this);
        }

        private void Hinzufuegen(Lagertyp tmp)
        {
            _list.Add(tmp);
            LagertypHinzugefuegt?.Invoke(this, EventArgs.Empty);
        }

        public static bool Entfernen(ref Lagertyp tmp)
        {
            if (_list.Remove(tmp))
            {
                LagertypEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }
    }
}
