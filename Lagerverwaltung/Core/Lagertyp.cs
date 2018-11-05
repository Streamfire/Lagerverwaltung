using System;

namespace Lagerverwaltung.Core
{
	public class Lagertyp
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime ErstelltAm { get; set; }
        public DateTime GeaendertAm { get; set; }


        public Lagertyp(int id, String name, DateTime erstelltAm, DateTime geaendertAm)
        {
            Id = id;
            Name = name;
            ErstelltAm = erstelltAm;
            GeaendertAm = geaendertAm;
        }
    }
}
