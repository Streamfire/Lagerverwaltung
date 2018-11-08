﻿namespace Lagerverwaltung.Core
{
	public sealed class Paket
    {
        public long PaketID { get; }
        public int RegalfachID { get; }
        public string Name { get; set; }
        public string Anschaffungsgrund { get; set; }
        public int Menge { get; set; }
        public int ErstelltAm { get; }
        public int GeaendertAm { get; }

        public Produkt Produkt { get; set; }

        // Hoehe, Breite, Laenge?

        public Paket(long paket_id, int regalfach_id, string name, string anschaffungsgrund, int menge, int erstellt_am, int geaendert_am, Produkt produkt)
        {
            PaketID = paket_id;
            RegalfachID = regalfach_id;
            Name = name;
            Anschaffungsgrund = anschaffungsgrund;
            Menge = menge;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
            Produkt = produkt;
        }

    }
}