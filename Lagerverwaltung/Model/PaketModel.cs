using System;

namespace Lagerverwaltung.Model
{
    class PaketModel
    {
        public long Paket_ID { get; }
        public string Name { get; }
        public DateTime Erstellt_Am { get; }
        public DateTime Zuletzt_Geaendert { get; }
        public long Regalfach_ID { get; }
        public long Produkt_ID { get; }
        public short Menge { get; }
        public DateTime Haltbarkeit { get; }
        public string Anschaffungsgrund { get; }
        public float Hoehe { get; }
        public float Breite { get; }
        public float Laenge { get; }
    }
}
