namespace Lagerverwaltung.Core
{
	public sealed class Lagertyp
    {
        public byte LagertypID { get; }
        public string Name { get; set; }
        public int ErstelltAm { get; set; }
        public int GeaendertAm { get; set; }


        public Lagertyp(byte lagertyp_id, string name, int erstellt_am, int geaendert_am)
        {
            LagertypID = lagertyp_id;
            Name = name;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
        }
    }
}
