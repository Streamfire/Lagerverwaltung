using System.Collections.Generic;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Core
{
    public sealed class Regalfach : Base
    {
        public int RegalfachID { get; }
        public byte RegalID { get; }
        public string Name { get; set; }
        public string Bemerkung { get; set; }
        public int Erstellt_Am { get; }
        public int Geaendert_Am { get; }

        public override float Hoehe { get; set; }
        public override float Breite { get; set; }
        public override float Laenge { get; set; }

        public List<Paket> Paketliste { get; set; }
    
        public Regalfach(int regalfach_id, byte regal_id, string name, string bemerkung, int erstellt_am, int geaendert_am, float hoehe, float breite, float laenge)
        {
            RegalfachID = regalfach_id;
            RegalID = regal_id;
            Name = name;
            Bemerkung = bemerkung;
            Erstellt_Am = erstellt_am;
            Geaendert_Am = geaendert_am;
            Hoehe = hoehe;
            Breite = breite;
            Laenge = laenge;
            Paketliste = new List<Paket>();
        }
    }
}
