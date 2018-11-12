using System.Diagnostics.Contracts;

namespace Lagerverwaltung.Core
{
	public sealed class Lagertyp
    {
        public ushort LagertypID { get; }
        public string Name { get; set; }
        public uint ErstelltAm { get; set; }
        public uint GeaendertAm { get; set; }


        public Lagertyp(ushort lagertyp_id, string name, uint erstellt_am, uint geaendert_am)
        {
            Contract.Requires(lagertyp_id >= 1);
            Contract.Requires(name.Length <= 20);   // plus minimal Länge laut Data Dictionary später
            LagertypID = lagertyp_id;
            Name = name;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
        }
    }
}
