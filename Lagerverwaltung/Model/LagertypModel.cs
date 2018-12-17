using System;

namespace Lagerverwaltung.Model
{
    class LagertypModel
    {
        public long Lagertyp_ID { get; }
        public string Name { get; }
        public DateTime Zuletzt_Geaendert { get; }
        public DateTime Erstellt_Am { get; }
    }
}
