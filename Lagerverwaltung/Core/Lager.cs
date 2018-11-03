using System;
using System.Collections.Generic;

namespace Lagerverwaltung.Core
{
    public class Lager
    {
		private List<Regal> regalliste;

		private int _id;
        private String _name;
        private String _standort;
        private String _beschreibung;
        private DateTime _erstelltAm;
        private DateTime _geaendertAm;
        private Lagertyp _lagertyp;
        
        public Lager(int id, String name, String standort, String beschreibung, DateTime erstelltAm, DateTime geaendertAm, Lagertyp lagertyp)
        {
            this._id = id;
            this.Name = name;
            this._standort = standort;
            this._beschreibung = beschreibung;
            this._erstelltAm = erstelltAm;
            this._geaendertAm = geaendertAm;
            this._lagertyp = lagertyp;
        }

		public List<Regal> Regalliste { get => regalliste; set => regalliste = value; }
		public string Name { get => _name; set => _name = value; }
	}
}
