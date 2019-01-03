using System;

namespace Lagerverwaltung.Model
{
    class ProduktModel
    {
        public long Produkt_ID { get; }
        public string Name { get; }
        public DateTime Erstellt_Am { get; }
        public DateTime Zuletzt_Geaendert { get; }
        public float Gewicht { get; }
        public float Preis { get; }
        public string Zeichnungsnummer { get; }
        public long Artikeltyp_ID { get; }
    }
}
