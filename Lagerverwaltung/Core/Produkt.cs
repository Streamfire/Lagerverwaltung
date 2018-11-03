using System;

namespace Lagerverwaltung.Core
{
   public class Produkt
    {
        private int _id;
        private String _name;
        private Artikeltyp _artikeltyp;
        private DateTime _erstelltAm;
        private DateTime _geaendertAm;

        // Groesse des Paketes wird in Artikel gespeichert, um Datenkohärenz zu vermeiden
        // TODO: eventuell an die Abstrakten Klasse anpassen (Wert wäre im Moment mit abstrakter Klasse public?)
        private float _hoehe;
        private float _breite;
        private float _laenge;

        public Produkt(int id, String name, Artikeltyp artikeltyp, DateTime erstelltAm, DateTime geaendertAm, float hoehe, float breite, float laenge)
        {
            this._id = id;
            this._name = name;
            this._erstelltAm = erstelltAm;
            this._geaendertAm = geaendertAm;
            this._artikeltyp = artikeltyp;
            this._hoehe = hoehe;
            this._breite = breite;
            this._laenge = laenge;
        }
    }
}
