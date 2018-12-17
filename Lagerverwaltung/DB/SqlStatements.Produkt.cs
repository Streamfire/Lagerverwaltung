﻿using Lagerverwaltung.Model;
using SqlKata.Execution;
using System;
using System.Collections.Generic;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long,ProduktModel> HoleProdukt()
        {
            throw new NotImplementedException();
        }

        public static void ErstelleProdukt(string name, float gewicht, float preis, string zeichnungsnummer, long artikeltyp_id, long paket_id)
        {
            var query = queryfactory.Query("produkt").Insert(new { name, gewicht, preis, zeichnungsnummer, artikeltyp_id, paket_id });
            OnDatabaseChanged(ModeltypEnum.ProduktModel);
        }

        public static void LoescheProdukt(long produkt_id)
        {
            var query = queryfactory.Query("produkt").Where("produkt_id", produkt_id).Delete();
            OnDatabaseChanged(ModeltypEnum.ProduktModel);
        }

        public static void UpdateProdukt(long produkt_id, string name="", float? gewicht=null, float? preis=null, string zeichnungsnummer="", long? artikeltyp_id=null, long? paket_id=null)
        {
            var zuletzt_geändert = DateTime.Now;
            var query = queryfactory.Query("produkt").Where("produkt_id", produkt_id);
            Dictionary<string, object> _dict = new Dictionary<string, object>();

            if (name.Length != 0)
            {
                _dict.Add("name", name);
            }
            if (gewicht != null)
            {
                _dict.Add("gewicht", gewicht);
            }
            if (preis != null)
            {
                _dict.Add("preis", preis);
            }
            if (zeichnungsnummer.Length != 0)
            {
                _dict.Add("zeichnungsnummer", zeichnungsnummer);
            }
            if (artikeltyp_id != null)
            {
                _dict.Add("artikeltyp_id", artikeltyp_id);
            }
            if (paket_id != null)
            {
                _dict.Add("paket_id", paket_id);
            }
            if (_dict.Count != 0)
            {
                _dict.Add("zuletzt_geändert", zuletzt_geändert);
                query.Update(_dict);
                OnDatabaseChanged(ModeltypEnum.ProduktModel);
            }
        }
    }
}