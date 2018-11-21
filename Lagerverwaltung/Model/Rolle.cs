using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Lagerverwaltung.Model
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
        public DateTime ErstelltAm { get; }
        public DateTime ZuletztGeaendert { get; }

        private static List<Rolle> _list = new List<Rolle>();
        public static event EventHandler<EventArgs> RolleHinzugefuegt;
        public static event EventHandler<EventArgs> RolleEntfernt;

        public Rolle(ushort rollen_id, string name, string rechte, DateTime erstellt_am, DateTime zuletzt_geaendert)
        {
            Contract.Requires(rollen_id >= 1);
            Contract.Requires(name.Length <= 10);   // plus minimal Länge laut Data Dictionary später
            Contract.Requires(rechte.Length >= 1);  // plus minimal Länge laut Data Dictionary später
            RollenID = rollen_id;
            Name = name;
            Rechte = rechte;
            ErstelltAm = erstellt_am;
            ZuletztGeaendert = zuletzt_geaendert;

            Hinzufuegen(this);
        }

        private void Hinzufuegen(Rolle tmp)
        {
            _list.Add(tmp);
            RolleHinzugefuegt?.Invoke(this, EventArgs.Empty);
        }

        public static bool Entfernen(ref Rolle tmp)
        {
            if (_list.Remove(tmp))
            {
                RolleEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }
    }
}
