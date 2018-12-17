using System;

namespace Lagerverwaltung.Model
{
    class RegalModel
    {
        public long Regal_ID { get; }
        public string Name { get; }
        public DateTime Erstellt_Am { get; }
        public DateTime Zuletzt_Geaendert { get; }
        public long Lager_ID { get; }
        public short Zeilen { get; }
        public short Spalten { get; }
        public float Höhe { get; }
        public float Breite { get; }
        public float Länge { get; }
        public float V_Wandstaerke { get; }
        public float H_Wandstaerke { get; }
    }
}
