using System;
using System.Diagnostics.Contracts;

namespace Lagerverwaltung.Model
{
	public sealed class Lagertyp
    {
        public ushort LagertypID { get; }
        public string Name { get; set; }
        public DateTime ErstelltAm { get; set; }
        public DateTime GeaendertAm { get; set; }


        public Lagertyp(ushort lagertyp_id, string name, DateTime erstellt_am, DateTime geaendert_am)
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
