using System;

namespace Lagerverwaltung.Core
{
	public sealed class Paket
    {
        public long PaketID { get; }
        public int RegalfachID { get; }
        public string Name { get; set; }
        public string Anschaffungsgrund { get; set; }
        public int Menge { get; set; }
        public int Erstellt_Am { get; }
        public int Geaendert_Am { get; }

        public Produkt Produkt { get; set; }

        // Hoehe, Breite, Laenge?

        public Paket(long paket_id, int regalfach_id, string name, string anschaffungsgrund, int menge, int erstellt_am, int geaendert_am, Produkt produkt)
        {
            PaketID = paket_id;
            RegalfachID = regalfach_id;
            Name = name;
            Anschaffungsgrund = anschaffungsgrund;
            Menge = menge;
            Erstellt_Am = erstellt_am;
            Geaendert_Am = geaendert_am;
            Produkt = produkt;
        }

    }
}
