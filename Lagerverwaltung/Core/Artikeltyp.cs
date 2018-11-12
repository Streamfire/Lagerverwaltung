using System.Diagnostics.Contracts;

namespace Lagerverwaltung.Core
{
	public sealed class Artikeltyp
    {
        public ushort ArtikeltypID { get; }
        public string Name { get; set; }
        public uint ErstelltAm { get; }
        public uint GeaendertAm { get; }

        public Artikeltyp(ushort artikeltyp_id, string name, uint erstellt_am, uint geaendert_am)
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
