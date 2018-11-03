using System;
using System.Collections.Generic;

namespace Lagerverwaltung.Core
{
    public class Regalfach
    {
        private List<Paket> _paketliste;

        private int _id;
        private String _name;
        private int _regalId;
        private DateTime _erstelltAm;
        private DateTime _geaendertAm;

        // TODO: eventuell an die Abstrakten Klasse anpassen (Wert wäre im Moment mit abstrakter Klasse public?)
        private float _hoehe;
        private float _breite;
        private float _laenge;

        public Regalfach(int id, String name, int regalId, DateTime erstelltAm, DateTime geaendertAm, float hoehe, float breite, float laenge)
        {
            this._id = id;
            this._name = name;
            this._regalId = regalId;
            this._erstelltAm = erstelltAm;
            this._geaendertAm = geaendertAm;
            this._hoehe = hoehe;
            this._breite = breite;
            this._laenge = laenge;
        }
    }
}
