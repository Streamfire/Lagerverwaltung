using System;
using System.Collections.Generic;

namespace Lagerverwaltung.Core
{
	public class Paket
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int RegalfachId { get; set; }
        public int Menge { get; set; }
        public Produkt Produkt { get; set; }
        public DateTime ErstelltAm { get; set; }
        public DateTime GeaendertAm { get; set; }
        public DateTime Haltbarkeit { get; set; }
        public String Anschaffungsgrund { get; set; }

        //Groesse-> siehe Produkt

        /*eventuell Daten für Paketdienst
        public String PaketdienstName { get; set; }
        public String PaketdienstNr { get; set; }
        */


        public Paket(int paketId, String name, int regalfachId, int menge, Produkt produkt, DateTime erstelltAm, DateTime geaendertAm, DateTime haltbarkeit, String anschaffungsgrund)
        {
            RegalfachId = regalfachId;
            Id = paketId;
            Name = name;
            Menge = menge;
            Produkt = produkt;
            ErstelltAm = erstelltAm;
            GeaendertAm = geaendertAm;
            Haltbarkeit = haltbarkeit;
            Anschaffungsgrund = anschaffungsgrund;
        }

    }
}
