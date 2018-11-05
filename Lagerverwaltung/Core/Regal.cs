using System;
using System.Collections.Generic;
using Lagerverwaltung.Core.Abstract;
using Lagerverwaltung.Core.Interfaces;

namespace Lagerverwaltung.Core
{
    sealed public class Regal : Base
    {
        public List<Regalfach> Regalfachliste { get; set; }
        public int Id { get; set; }
        public String Name { get; set; }
        public int LagerId { get; set; }
        public int Zeilen { get; set; }
        public int Spalten { get; set; }
        public DateTime ErstelltAm { get; set; }
        public DateTime GeaendertAm { get; set; }

        public override float Hoehe { get; set; }
        public override float Breite { get; set; }
        public override float Laenge { get; set; }
        public float V_Wandstaerke { get; set; }
        public float H_Wandstaerke { get; set; }

		public Regal()
        {
		    Id=0;
		    Name="Regal 0";
		    LagerId= 0;
		    Zeilen=5;
		    Spalten=6;
		    Regalfachliste = new List<Regalfach>();	
		}

        public Regal(int id, String name, int lagerId, int zeilen, int spalten, DateTime erstelltAm, DateTime geaendertAm, float hoehe, float breite, float laenge, float v_wandstaerke, float h_wandstaerke)
        {
            Id = id;
            Name = name;
            LagerId = lagerId;
            Zeilen = zeilen;
            Spalten = spalten;
            ErstelltAm = erstelltAm;
            GeaendertAm = geaendertAm;
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
