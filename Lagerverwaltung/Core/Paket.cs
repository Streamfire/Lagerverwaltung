using System;
using System.Collections.Generic;

namespace Lagerverwaltung.Core
{
    class Paket
    {
        private int _id;
        private String _name;
        private int _regalfachId;
        private int _menge;
        private Produkt _produkt;
        private DateTime _erstelltAm;
        private DateTime _geaendertAm;
        private DateTime _haltbarkeit;
        private DateTime _lieferfrist;

        //Groesse-> siehe Produkt

        /*eventuell Daten für Paketdienst
        private String _paketdienstName;
        private String _paketdienstNr;
        */


        public Paket(int paketId, String name, int regalfachId, int menge, Produkt produkt, DateTime erstelltAm, DateTime geaendertAm, DateTime haltbarkeit, DateTime lieferfrist)
        {
            this._regalfachId = regalfachId;
            this._id = paketId;
            this._name = name;
            this._menge = menge;
            this._produkt = produkt;
            this._erstelltAm = erstelltAm;
            this._geaendertAm = geaendertAm;
            this._haltbarkeit = haltbarkeit;
            this._lieferfrist = lieferfrist;
        }

    }
}
