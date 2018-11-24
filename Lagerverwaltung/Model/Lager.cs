using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace Lagerverwaltung.Model
{
    public sealed class Lager
    {
        public ushort LagerID { get; }
        public string Name { get; set; }
        public string Standort { get; set; }
        public string Beschreibung { get; set; }
        public DateTime ErstelltAm { get; }
        public DateTime GeaendertAm { get; }
        public ushort LagerTyp { get; set; }

        public List<Regal> Regalliste { get; set; }

        private static Dictionary<ushort, Lager> _dict = new Dictionary<ushort, Lager>();
        public static event EventHandler<EventArgs> LagerHinzugefuegt;
        public static event EventHandler<EventArgs> LagerEntfernt;

        public static ReadOnlyDictionary<ushort, Lager> HoleListe => new ReadOnlyDictionary<ushort, Lager>(_dict);

        public Lager(ushort lager_id, string name, DateTime erstellt_am, DateTime geaendert_am, ushort lagertyp, string standort = "", string beschreibung = "")
        {
            Contract.Requires(lager_id >= 1);
            Contract.Requires(name.Length <= 20);   // plus minimal Länge laut Data Dictionary später
            Contract.Requires(standort.Length <= 20);
            Contract.Requires(beschreibung.Length <= 50);
            LagerID = lager_id;
            Name = name;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
            LagerTyp = lagertyp;
            Standort = standort;
            Beschreibung = beschreibung;
            Regalliste = new List<Regal>();

            Hinzufuegen(this);
        }

        private void Hinzufuegen(Lager tmp)
        {
            _dict.Add(tmp.LagerID,tmp);
            LagerHinzugefuegt?.Invoke(this, EventArgs.Empty);
        }

        public static bool Entfernen(ref Lager tmp)
        {
            if (_dict.Remove(tmp.LagerID))
            {
                LagerEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }

        public static void RegalHinzufuegen(ushort lagerID, Regal tmp)
        {
            _dict[lagerID].Regalliste.Add(tmp);
        }

        //Zeitaufwändig (zumindest bei vielen Einträgen), daher evt. später andere Lösung finden (z.b. doppeltes Dictionary [Key: names, Value: IDs])
        //Rückgabe Int, da bei falscher Ausgabe -1 ausgegeben wird
        public static int GetIDByName(string lagername)
        {   
            foreach (KeyValuePair<ushort, Lager> entry in _dict)
            {
                if (entry.Value.Name == lagername)
                {
                    return entry.Key;
                }
            }

            return -1; 
        }
    }
}
