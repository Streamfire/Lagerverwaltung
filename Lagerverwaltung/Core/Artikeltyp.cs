using System;

namespace Lagerverwaltung.Core
{
	public sealed class Artikeltyp
    {
        public byte ArtikeltypID { get; }
        public string Name { get; set; }
        public int Erstellt_Am { get; }
        public int Geaendert_Am { get; }

        public Artikeltyp(byte artikeltyp_id, string name, int erstellt_am, int geaendert_am)
        {
            ArtikeltypID = artikeltyp_id;
            Name = name;
            Erstellt_Am = erstellt_am;
            Geaendert_Am = geaendert_am;
        }
    }
}
