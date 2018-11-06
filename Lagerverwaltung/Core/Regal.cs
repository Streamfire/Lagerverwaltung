using System;
using System.Collections.Generic;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Core
{
    public sealed class Regal : Base
    {
        public byte RegalID { get; }
        public byte LagerID { get; }
        public string Name { get; set; }
        public byte Zeilen { get; set; }
        public byte Spalten { get; set; }
        public int Erstellt_Am { get; }
        public int Geaendert_Am { get; }

        public float V_Wandstaerke { get; set; }
        public float H_Wandstaerke { get; set; }
        public override float Hoehe { get; set; }
        public override float Breite { get; set; }
        public override float Laenge { get; set; }

        public List<Regalfach> Regalfachliste { get; set; }
        
        public Regal(byte regal_id, byte lager_id, string name, byte zeilen, byte spalten, int erstellt_am, int geaendert_am, float hoehe, float breite, float laenge, float v_wandstaerke, float h_wandstaerke)
        {
            RegalID = regal_id;
            LagerID = lager_id;
            Name = name;
            Zeilen = zeilen;
            Spalten = spalten;
            Erstellt_Am = erstellt_am;
            Geaendert_Am = geaendert_am;
            Hoehe = hoehe;
            Breite = breite;
            Laenge = laenge;
            V_Wandstaerke = v_wandstaerke;
            H_Wandstaerke = h_wandstaerke;
    }

        public override float BerechneFlaeche()
        {
            return base.BerechneFlaeche();
        }

        public override float BerechneVolumen()
        {
            return base.BerechneVolumen();
        }
    }
}
