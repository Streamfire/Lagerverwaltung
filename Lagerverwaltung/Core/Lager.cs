using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Lagerverwaltung.Core
{
    public sealed class Lager
    {
        public ushort LagerID { get; }
        public string Name { get; set; }
        public string Standort { get; set; }
        public string Beschreibung { get; set; }
        public uint ErstelltAm { get; }
        public uint GeaendertAm { get; }
        public Lagertyp LagerTyp { get; set; }

        public List<Regal> Regalliste { get; set; }

        public Lager(ushort lager_id, string name, uint erstellt_am, uint geaendert_am, Lagertyp lagertyp, string standort = "", string beschreibung = "")
        {
            Contract.Requires(lager_id >= 1);
            Contract.Requires(name.Length <= 20);   // plus minimal Länge laut Data Dictionary später
            Contract.Requires(standort.Length <= 20);
            Contract.Requires(beschreibung.Length <= 50);
            LagerID = lager_id;
            Name = name;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
            LagerTyp = lagertyp;
            Standort = standort;
            Beschreibung = beschreibung;
            Regalliste = new List<Regal>();
        }
	}
}
