using System;
using System.Collections.Generic;

namespace Lagerverwaltung.Core
{
    public class Lager
    {
		public List<Regal> Regalliste { get; set; }

        public int Id { get; set; }
        public String Name { get; set; }
        public String Standort { get; set; }
        public String Beschreibung { get; set; }
        public DateTime ErstelltAm { get; set; }
        public DateTime GeaendertAm { get; set; }
        public Lagertyp LagerTyp { get; set; }

        public Lager(int id, String name, String standort, String beschreibung, DateTime erstelltAm, DateTime geaendertAm, Lagertyp lagertyp)
        {
            Id = id;
            Name = name;
            Standort = standort;
            Beschreibung = beschreibung;
            ErstelltAm = erstelltAm;
            GeaendertAm = geaendertAm;
            LagerTyp = lagertyp;
        }
	}
}
