using System;
using System.Collections.Generic;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Core
{
    public class Regalfach : Base
    {
        public List<Paket> Paketliste { get; set; }

        public int Id { get; set; }
        public String Name { get; set; }
        public int RegalId { get; set; }
        public DateTime ErstelltAm { get; set; }
        public DateTime GeaendertAm { get; set; }
        public String Bemerkung { get; set; }

        public override float Hoehe { get; set; }
        public override float Breite { get; set; }
        public override float Laenge { get; set; }

        public Regalfach(int id, String name, int regalId, DateTime erstelltAm, DateTime geaendertAm, String bemerkung, float hoehe, float breite, float laenge)
        {
            Id = id;
            Name = name;
            RegalId = regalId;
            ErstelltAm = erstelltAm;
            GeaendertAm = geaendertAm;
            Bemerkung = bemerkung;
            Hoehe = hoehe;
            Breite = breite;
            Laenge = laenge;
        }
    }
}
