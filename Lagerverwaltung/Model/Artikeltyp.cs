using System;
using System.Diagnostics.Contracts;

namespace Lagerverwaltung.Model
{
	public sealed class Artikeltyp
    {
        public ushort ArtikeltypID { get; }
        public string Name { get; set; }
        public DateTime ErstelltAm { get; }
        public DateTime GeaendertAm { get; }

        public Artikeltyp(ushort artikeltyp_id, string name, DateTime erstellt_am, DateTime geaendert_am)
        {
            Contract.Requires(artikeltyp_id >= 1);
            Contract.Requires(name.Length <= 20);   // plus minimal Länge laut Data Dictionary später
            ArtikeltypID = artikeltyp_id;
            Name = name;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
        }
    }
}
