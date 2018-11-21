﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Model
{
    public sealed class Regal : Base
    {
        public ushort RegalID { get; }
        public ushort LagerID { get; }
        public string Name { get; set; }
        public byte Zeilen { get; set; }
        public byte Spalten { get; set; }
        public DateTime ErstelltAm { get; }
        public DateTime GeaendertAm { get; }

        public float V_Wandstaerke { get; set; }
        public float H_Wandstaerke { get; set; }
        public override float Hoehe { get; set; }
        public override float Breite { get; set; }
        public override float Laenge { get; set; }

        public List<Regalfach> Regalfachliste { get; set; }

        private static List<Regal> _list = new List<Regal>();
        public static event EventHandler<EventArgs> RegalHinzugefuegt;
        public static event EventHandler<EventArgs> RegalEntfernt;

        public Regal(ushort regal_id, ushort lager_id, string name, byte zeilen, byte spalten, DateTime erstellt_am, DateTime geaendert_am, float hoehe, float breite, float laenge, float v_wandstaerke, float h_wandstaerke)
        {
            Contract.Requires(regal_id >= 1);
            Contract.Requires(lager_id >= 1);
            Contract.Requires(name.Length <= 15);   // plus minimal Länge laut Data Dictionary später
            Contract.Requires(zeilen >= 1);
            Contract.Requires(spalten >= 1);
            Contract.Requires(hoehe >= 0);
            Contract.Requires(breite >= 0);
            Contract.Requires(laenge >= 0);

            RegalID = regal_id;
            LagerID = lager_id;
            Name = name;
            Zeilen = zeilen;
            Spalten = spalten;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
            Hoehe = hoehe;
            Breite = breite;
            Laenge = laenge;
            V_Wandstaerke = v_wandstaerke;
            H_Wandstaerke = h_wandstaerke;
            Regalfachliste = new List<Regalfach>();

            Hinzufuegen(this);
        }

        public override float BerechneFlaeche()
        {
            return base.BerechneFlaeche();
        }

        public override float BerechneVolumen()
        {
            return base.BerechneVolumen();
        }

        private void Hinzufuegen(Regal tmp)
        {
            _list.Add(tmp);
            RegalHinzugefuegt?.Invoke(this, EventArgs.Empty);
        }

        public static bool Entfernen(ref Regal tmp)
        {
            if (_list.Remove(tmp))
            {
                RegalEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }
    }
}
