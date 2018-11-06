using System;
using System.Collections.Generic;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Core
{
    public sealed class Lager
    {
        public byte LagerID { get; }
        public string Name { get; set; }
        public string Standort { get; set; }
        public string Beschreibung { get; set; }
        public int Erstellt_Am { get; }
        public int Geaendert_Am { get; }
        public Lagertyp LagerTyp { get; set; }

        public List<Regal> Regalliste { get; set; }

        public Lager(byte lager_id, string name, string standort, string beschreibung, int erstellt_am, int geaendert_am, Lagertyp lagertyp)
        {
            LagerID = lager_id;
            Name = name;
            Standort = standort;
            Beschreibung = beschreibung;
            Erstellt_Am = erstellt_am;
            Geaendert_Am = geaendert_am;
            LagerTyp = lagertyp;
        }
	}
}
