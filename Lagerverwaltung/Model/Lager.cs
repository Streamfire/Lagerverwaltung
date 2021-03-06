﻿using System;
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
        private static Dictionary<string, ushort> _nameDict = new Dictionary<string, ushort>();
        public static event EventHandler<EventArgs> LagerHinzugefuegt;
        public static event EventHandler<EventArgs> LagerEntfernt;

        public static ReadOnlyDictionary<ushort, Lager> HoleListe => new ReadOnlyDictionary<ushort, Lager>(_dict);
        public static ReadOnlyDictionary<string, ushort> HoleNamensliste => new ReadOnlyDictionary<string, ushort>(_nameDict);

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
            _nameDict.Add(tmp.Name, tmp.LagerID);
            _dict.Add(tmp.LagerID,tmp);
            LagerHinzugefuegt?.Invoke(this, EventArgs.Empty);
		}

        public static bool Entfernen(ref Lager tmp)
        {
            if (_dict.Remove(tmp.LagerID) && _nameDict.Remove(tmp.Name))
            {
                LagerEntfernt?.Invoke(tmp, EventArgs.Empty);
				Views.Dashboard.Verwaltung.UpdateForm();
				tmp = null;
                return true;
            }
            return false;
        }

        public static void RegalHinzufuegen(ushort lagerID, Regal tmp)
        {
            _dict[lagerID].Regalliste.Add(tmp);
        }

        public static void Reset()
        {
            _dict.Clear();
            _nameDict.Clear();
        }

    }
}
