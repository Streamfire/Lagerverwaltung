using System;
using System.Diagnostics.Contracts;

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

        public ushort RollenID { get; }
        public string Name { get; set; }
        public string Rechte { get; set; }
        public uint ErstelltAm { get; }
        public uint ZuletztGeaendert { get; }

        public Rolle(ushort rollen_id, string name, string rechte, uint erstellt_am, uint zuletzt_geaendert)
        {
            Contract.Requires(rollen_id >= 1);
            Contract.Requires(name.Length <= 10);   // plus minimal Länge laut Data Dictionary später
            Contract.Requires(rechte.Length >= 1);  // plus minimal Länge laut Data Dictionary später
            RollenID = rollen_id;
            Name = name;
            Rechte = rechte;
            ErstelltAm = erstellt_am;
            ZuletztGeaendert = zuletzt_geaendert;
        }
    }
}
