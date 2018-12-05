using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Lagerverwaltung.Core.Abstract;
using System.Globalization;

namespace Lagerverwaltung.Model
{
    public sealed class Suche : Base
    {
        public string ProduktName { get; set; }
        public uint ProduktID { get; set; }
        public float ProduktGewicht { get; set; }
        public float ProduktPreis { get; set; }
        public string ProduktZeichnungsnummer { get; set; }
        //Produkthoehe
        public override float Hoehe { get; set; }
        //Produktbreite
        public override float Breite { get; set; }
        //Produktlaeng
        public override float Laenge { get; set; }
        public DateTime ProduktErstelltAm { get; set; }
        public DateTime ProduktGeaendertAm { get; set; }


        public string PaketName { get; set; }
        public ushort PaketMenge { get; set; }
        public DateTime PaketHaltbarkeit { get; set; }
        public string PaketAnschaffungsgrund { get; set; }


        public string RegalName { get; set; }
        public string RegalfachName { get; set; }


        public uint Zeile { get; set; }


        public float Hoehe2 { get; set; }
        public float Breite2 { get; set; }
        public float Laenge2 { get; set; }
        public float ProduktPreis2 { get; set; }
        public float ProduktGewicht2 { get; set; }
        public DateTime ProduktErstelltAm2 { get; set; }
        public DateTime ProduktGeaendertAm2 { get; set; }
        public ushort PaketMenge2 { get; set; }
        public DateTime PaketHaltbarkeit2 { get; set; }



        public static event EventHandler<EventArgs> SucheHinzugefuegt;
        private static Dictionary<ulong, Suche> _dict = new Dictionary<ulong, Suche>();
        public static ReadOnlyDictionary<ulong, Suche> HoleSuchergebnisse => new ReadOnlyDictionary<ulong, Suche>(_dict);

        public Suche()
        {
            ProduktName = "";
            ProduktID = 0;
            ProduktGewicht = 0.0f;
            ProduktPreis = 0.0f;
            ProduktZeichnungsnummer = "";
            Hoehe = 0.0f;
            Breite = 0.0f;
            Laenge = 0.0f;
            ProduktErstelltAm = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            ProduktGeaendertAm = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            PaketName = "";
            PaketMenge = 0;
            PaketHaltbarkeit = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            PaketAnschaffungsgrund = "";

            RegalName = "";
            RegalfachName = "";

            Zeile = 0;

            Hoehe2 = 0.0f;
            Breite2 = 0.0f;
            Laenge2 = 0.0f;
            ProduktPreis2 = 0.0f;
            ProduktGewicht2 = 0.0f;
            ProduktErstelltAm2 = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            ProduktGeaendertAm2 = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            PaketMenge2 = 0;
            PaketHaltbarkeit2 = DateTime.ParseExact("1970-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }


        public Suche(   string produkt_name, uint produkt_id, float produkt_gewicht, float produkt_preis, string produkt_zeichnungsnummer, float hoehe, float breite, float laenge, DateTime produkt_erstellt_am, DateTime produkt_geaendert_am  ,
                        string paket_name, ushort paket_menge, DateTime paket_haltbarkeit, string paket_anschaffungsgrund, string regal_name, string regalfach_name, uint zeile                                                                  )
        {
            ProduktName = produkt_name;
            ProduktID = produkt_id;
            ProduktGewicht = produkt_gewicht;
            ProduktPreis = produkt_preis;
            ProduktZeichnungsnummer = produkt_zeichnungsnummer;
            Hoehe = hoehe;
            Breite = breite;
            Laenge = laenge;
            ProduktErstelltAm = produkt_erstellt_am;
            ProduktGeaendertAm = produkt_geaendert_am;

            PaketName = paket_name;
            PaketMenge = paket_menge;
            PaketHaltbarkeit = paket_haltbarkeit;
            PaketAnschaffungsgrund = paket_anschaffungsgrund;

            RegalName = regal_name;
            RegalfachName = regalfach_name;

            Zeile = zeile;


            Hinzufuegen(this);

            var test = _dict.Values;
        }

        private void Hinzufuegen(Suche tmp)
        {
            if (tmp != null)
            {
                if (!_dict.ContainsKey(Zeile))
                {
                    _dict.Add(tmp.Zeile, tmp);
                    SucheHinzugefuegt?.Invoke(tmp, EventArgs.Empty);
                }
                
            }
        }
    }
}
