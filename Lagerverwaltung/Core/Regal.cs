using System;
using System.Collections.Generic;
using Lagerverwaltung.Core.Abstract;
using Lagerverwaltung.Core.Interfaces;

namespace Lagerverwaltung.Core
{
    sealed class Regal : Base
    {
        private List<Regalfach> _regalfachliste;

        private int _id;
        private String _name;
        private int _lagerId;
        private int _zeilen;
        private int _spalten;
        private DateTime _erstelltAm;
        private DateTime _geaendertAm;


        public override float Höhe { get; set; }
        public override float Breite { get; set; }
        public override float Länge { get; set; }
        public float V_Wandstärke { get; set; }
        public float H_Wandstärke { get; set; }

        public Regal()
        {

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
