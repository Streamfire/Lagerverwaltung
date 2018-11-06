using System;

namespace Lagerverwaltung.Core
{
    public sealed class Rolle
    {
        [Flags]
        public enum RechteEnum
        {
            // So in der Art. Mal sehen was wir brauchen.
            Keine = 0,
            Lesen = 1,
            Schreiben = 2,
            Ausführen = 4
        }

        public byte RollenID { get; }
        public string Name { get; set; }
        public string Rechte { get; set; }
        public int ErstelltAm { get; }
        public int ZuletztGeaendert { get; }

        public Rolle(byte rollen_id, string name, string rechte, int erstellt_am, int zuletzt_geaendert)
        {
            RollenID = rollen_id;
            Name = name;
            Rechte = rechte;
            ErstelltAm = erstellt_am;
            ZuletztGeaendert = zuletzt_geaendert;
        }
    }
}
