using Lagerverwaltung.Model;
using SqlKata.Execution;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long, PaketModel> HolePaket(long paket_id = -1, long regalfach_id = -1, string name = "", int limit=-1)
        {
            var query = queryfactory.Query("paket").OrderBy("paket_id");
            if (paket_id > 0)
            {
                query.Where("paket_id", paket_id);
            }
            if (regalfach_id > 0)
            {
                query.Where("regalfach_id", regalfach_id);
            }
            if (name.Length != 0)
            {
                query.Where("name", name);
            }
            if (limit > 0)
            {
                query.Limit(limit);
            }
            return query.Get<PaketModel>().ToDictionary(row => row.Paket_ID, row => row);
        }

        public static void ErstellePaket(string name, long regalfach_id, long produkt_id, short menge, DateTime haltbarkeit, string anschaffungsgrund, float hoehe, float breite, float laenge)
        {
            var query = queryfactory.Query("paket").Insert(new { name, regalfach_id, produkt_id, menge, haltbarkeit, anschaffungsgrund, hoehe, breite, laenge });
            SchreibeHistorieEintrag($"Neues Paket: {name} erstellt!");
            OnDatabaseChanged(ModeltypEnum.PaketModel);
        }

        public static void LoeschePaket(long paket_id)
        {
            var paket = HolePaket(paket_id);

            var query = queryfactory.Query("paket").Where("paket_id", paket_id).Delete();
            //SchreibeHistorieEintrag($"Paket ({paket_id}): {paket[0].Name} gelöscht!");
            OnDatabaseChanged(ModeltypEnum.PaketModel);
        }

        public static void UpdatePaket(long paket_id, string name="", long? regalfach_id=null, long? produkt_id=null, short? menge=null, DateTime? haltbarkeit=null, string anschaffungsgrund="", float? hoehe=null, float? breite=null, float? laenge=null)
        {
            var paket = HolePaket(paket_id);

            var zuletzt_geaendert = DateTime.Now;
            var query = queryfactory.Query("paket").Where("paket_id", paket_id);
            Dictionary<string, object> _dict = new Dictionary<string, object>();

            if (name.Length != 0)
            {
                _dict.Add("name", name);
            }
            if (regalfach_id != null)
            {
                _dict.Add("regalfach_id", regalfach_id);
            }
            if (produkt_id != null)
            {
                _dict.Add("produkt_id", produkt_id);
            }
            if (menge != null)
            {
                _dict.Add("menge", menge);
            }
            if(haltbarkeit != null)
            {
                _dict.Add("haltbarkeit", haltbarkeit);
            }
            if(anschaffungsgrund.Length != 0)
            {
                _dict.Add("anschaffungsgrund", anschaffungsgrund);
            }
            if (hoehe != null)
            {
                _dict.Add("hoehe", hoehe);
            }
            if (breite != null)
            {
                _dict.Add("breite", breite);
            }
            if (laenge != null)
            {
                _dict.Add("laenge", laenge);
            }
            if (_dict.Count != 0)
            {
                _dict.Add("zuletzt_geaendert", zuletzt_geaendert);
                query.Update(_dict);
                SchreibeHistorieEintrag($"Paket ({paket_id}): {paket[0].Name} geändert!");
                OnDatabaseChanged(ModeltypEnum.PaketModel);
            }
        }
    }
}