namespace Lagerverwaltung.Core
{
	public sealed class Artikeltyp
    {
        public byte ArtikeltypID { get; }
        public string Name { get; set; }
        public int ErstelltAm { get; }
        public int GeaendertAm { get; }

        public Artikeltyp(byte artikeltyp_id, string name, int erstellt_am, int geaendert_am)
        {
            ArtikeltypID = artikeltyp_id;
            Name = name;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
        }
    }
}
