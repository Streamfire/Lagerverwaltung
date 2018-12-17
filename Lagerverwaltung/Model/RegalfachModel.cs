using System;

namespace Lagerverwaltung.Model
{
    class RegalfachModel
    {
        public long Regalfach_ID { get; }
        public string Name { get; }
        public DateTime Erstellt_Am { get; }
        public DateTime Zuletzt_Geaendert { get; }
        public long Regal_ID { get; }
        public string Bemerkung { get; }
        public float Hoehe { get; }
        public float Breite { get; }
        public float Laenge { get; }
    }
}
