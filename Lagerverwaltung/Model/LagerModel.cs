using System;

namespace Lagerverwaltung.Model
{
    class LagerModel
    {
        public long Lager_ID { get; }
        public string Name { get; }
        public string Standort { get; }
        public DateTime Erstellt_Am { get; }
        public DateTime Zuletzt_Geändert { get; }
        public string Beschreibung { get; }
        public long Lagertyp_ID { get; }
    }
}
