using System.Collections.Generic;

namespace Lagerverwaltung.Core
{
    public sealed class Lager
    {
        public byte LagerID { get; }
        public string Name { get; set; }
        public string Standort { get; set; }
        public string Beschreibung { get; set; }
        public int ErstelltAm { get; }
        public int GeaendertAm { get; }
        public Lagertyp LagerTyp { get; set; }

        public List<Regal> Regalliste { get; set; }

        public Lager(byte lager_id, string name, string standort, string beschreibung, int erstellt_am, int geaendert_am, Lagertyp lagertyp)
        {
            LagerID = lager_id;
            Name = name;
            Standort = standort;
            Beschreibung = beschreibung;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
            LagerTyp = lagertyp;
            Regalliste = new List<Regal>();
        }
	}
}
