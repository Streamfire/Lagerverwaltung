using System;

namespace Lagerverwaltung.Model
{
    class ArtikeltypModel
    {
        public long Artikeltyp_ID { get; }
        public string Name { get; }
        public DateTime Zuletzt_Geändert { get; }
        public DateTime Erstellt_Am { get; }
    }
}
