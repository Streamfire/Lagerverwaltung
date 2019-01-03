using Lagerverwaltung.Model;
using SqlKata.Execution;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long, ProduktModel> HoleProdukt(long produkt_id = -1, string name = "", int limit = -1)
        {
            var query = queryfactory.Query("produkt").OrderBy("produkt_id");
            if (produkt_id > 0)
            {
                query.Where("produkt_id", produkt_id);
            }
            if (name.Length != 0)
            {
                query.Where("name", name);
            }
            if (limit > 0)
            {
                query.Limit(limit);
            }
            return query.Get<ProduktModel>().ToDictionary(row => row.Produkt_ID, row => row);
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

        public static void UpdateProdukt(long produkt_id, string name="", float? gewicht=null, float? preis=null, string zeichnungsnummer="", long? artikeltyp_id=null)
        {
            var zuletzt_geaendert = DateTime.Now;
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
            if (_dict.Count != 0)
            {
                _dict.Add("zuletzt_geaendert", zuletzt_geaendert);
                query.Update(_dict);
                OnDatabaseChanged(ModeltypEnum.ProduktModel);
            }
        }
    }
}