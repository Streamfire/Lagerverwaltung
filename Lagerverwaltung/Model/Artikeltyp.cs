using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Lagerverwaltung.Model
{
	public sealed class Artikeltyp
    {
        public ushort ArtikeltypID { get; }
        public string Name { get; set; }
        public DateTime ErstelltAm { get; }
        public DateTime GeaendertAm { get; }

        private static Dictionary<ushort, Artikeltyp> _dict = new Dictionary<ushort, Artikeltyp>();
        public static event EventHandler<EventArgs> ArtikeltypHinzugefuegt;
        public static event EventHandler<EventArgs> ArtikeltypEntfernt;

        public Artikeltyp(ushort artikeltyp_id, string name, DateTime erstellt_am, DateTime geaendert_am)
        {
            Contract.Requires(artikeltyp_id >= 1);
            Contract.Requires(name.Length <= 20);   // plus minimal Länge laut Data Dictionary später
            ArtikeltypID = artikeltyp_id;
            Name = name;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;

            Hinzufuegen(this);
        }

        private void Hinzufuegen(Artikeltyp tmp)
        {
            _dict.Add(tmp.ArtikeltypID,tmp);
            ArtikeltypHinzugefuegt?.Invoke(this, EventArgs.Empty);
        }

        public static bool Entfernen(ref Artikeltyp tmp)
        {
            if (_dict.Remove(tmp.ArtikeltypID))
            {
                ArtikeltypEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }
    }
}
