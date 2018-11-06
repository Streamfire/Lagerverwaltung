using System;

namespace Lagerverwaltung.Core
{
	public sealed class Lagertyp
    {
        public byte LagertypID { get; }
        public string Name { get; set; }
        public int Erstellt_Am { get; set; }
        public int Geaendert_Am { get; set; }


        public Lagertyp(byte lagertyp_id, string name, int erstellt_am, int geaendert_am)
        {
            LagertypID = lagertyp_id;
            Name = name;
            Erstellt_Am = erstellt_am;
            Geaendert_Am = geaendert_am;
        }
    }
}
