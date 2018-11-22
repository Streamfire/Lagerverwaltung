using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Model
{
    public sealed class Regalfach : Base
    {
        public ushort RegalfachID { get; }
        public ushort RegalID { get; }
        public string Name { get; set; }
        public string Bemerkung { get; set; }
        public DateTime Erstellt_Am { get; }
        public DateTime Geaendert_Am { get; }

        public override float Hoehe { get; set; }
        public override float Breite { get; set; }
        public override float Laenge { get; set; }

        public List<Paket> Paketliste { get; set; }

        private static Dictionary<ushort, Regalfach> _dict = new Dictionary<ushort, Regalfach>();
        public static event EventHandler<EventArgs> RegalfachHinzugefuegt;
        public static event EventHandler<EventArgs> RegalfachEntfernt;

        public Regalfach(ushort regalfach_id, ushort regal_id, string name, DateTime erstellt_am, DateTime geaendert_am, float hoehe, float breite, float laenge, string bemerkung="")
        {
            Contract.Requires(regalfach_id >= 1);
            Contract.Requires(regal_id >= 1);
            Contract.Requires(name.Length <= 15);   // plus minimal Länge laut Data Dictionary später
            Contract.Requires(hoehe >= 0);
            Contract.Requires(breite >= 0);
            Contract.Requires(laenge >= 0);

            RegalfachID = regalfach_id;
            RegalID = regal_id;
            Name = name;
            Erstellt_Am = erstellt_am;
            Geaendert_Am = geaendert_am;
            Hoehe = hoehe;
            Breite = breite;
            Laenge = laenge;
            Bemerkung = bemerkung;
            Paketliste = new List<Paket>();

            Hinzufuegen(this);
        }

        private void Hinzufuegen(Regalfach tmp)
        {
            _dict.Add(tmp.RegalfachID,tmp);
            RegalfachHinzugefuegt?.Invoke(this, EventArgs.Empty);
        }

        public static bool Entfernen(ref Regalfach tmp)
        {
            if (_dict.Remove(tmp.RegalfachID))
            {
                RegalfachEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }
    }
}
