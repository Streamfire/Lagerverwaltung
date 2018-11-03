using System;

namespace Lagerverwaltung.Core
{
	public class Artikeltyp
    {
        private int _id;
        private String _name;
        private DateTime _erstelltAm;
        private DateTime _geaendertAm;

        public Artikeltyp(int id, String name, DateTime erstelltAm, DateTime geaendertAm)
        {
            this._id = id;
            this._name = name;
            this._erstelltAm = erstelltAm;
            this._geaendertAm = geaendertAm;
        }
    }
}
