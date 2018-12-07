using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Collections.ObjectModel;

namespace Lagerverwaltung.Model
{
	public sealed class Lagertyp
    {
        public ushort LagertypID { get; }
        public string Name { get; set; }
        public DateTime ErstelltAm { get; set; }
        public DateTime GeaendertAm { get; set; }

        private static Dictionary<ushort, Lagertyp> _dict = new Dictionary<ushort, Lagertyp>();

        public static ReadOnlyDictionary<ushort, Lagertyp> HoleListe => new ReadOnlyDictionary<ushort, Lagertyp>(_dict);

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
            _dict.Add(tmp.LagertypID,tmp);
            LagertypHinzugefuegt?.Invoke(this, EventArgs.Empty);
        }

        public static bool Entfernen(ref Lagertyp tmp)
        {
            if (_dict.Remove(tmp.LagertypID))
            {
                LagertypEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }
    }
}
