using System;

namespace Lagerverwaltung.Core
{
    class Lagertyp
    {
        private int _id;
        private String _name;
        private DateTime _erstelltAm;
        private DateTime _geaendertAm;


        public Lagertyp(int id, String name, DateTime erstelltAm, DateTime geaendertAm)
        {
            this._id = id;
            this._name = name;
            this._erstelltAm = erstelltAm;
            this._geaendertAm = geaendertAm;
        }
    }
}
