using System;
using System.Collections.Generic;
using System.Linq;
using Lagerverwaltung.Model;
using SqlKata.Execution;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long,LagerModel> HoleLager(long lager_id=-1, long lagertyp_id=-1, int limit=-1)
        {
            var query = queryfactory.Query("lager").OrderBy("lager_id");
            if(lager_id>0)
            {
                query.Where("lager_id",lager_id);
            }
            if(lagertyp_id>0)
            {
                query.Where("lagertyp_id",lagertyp_id);
            }
            if(limit>0)
            {
                query.Limit(limit);
            }
            return query.Get<LagerModel>().ToDictionary(row => row.Lager_ID, row => row);
        }

        public static void ErstelleLager(string name, string standort, string beschreibung, long lagertyp_id)
        {
            var query = queryfactory.Query("lager").Insert(new { name, standort, beschreibung, lagertyp_id });
            SchreibeHistorieEintrag($"Neues Lager: {name} erstellt!");
            OnDatabaseChanged(ModeltypEnum.LagerModel);
        }

        public static void LoescheLager(long lager_id)
        {
            var lager = HoleLager(lager_id);

            var query = queryfactory.Query("lager").Where("lager_id", lager_id).Delete();
            SchreibeHistorieEintrag($"Lager ({lager_id}): {lager[0].Name} gelöscht!");
            OnDatabaseChanged(ModeltypEnum.LagerModel);
        }

        public static void UpdateLager(long lager_id, string name="", string standort="", string beschreibung="", long? lagertyp_id=null)
        {
            var lager = HoleLager(lager_id);

            var zuletzt_geaendert = DateTime.Now;
            var query = queryfactory.Query("lager").Where("lager_id", lager_id);
            Dictionary<string, object> _dict = new Dictionary<string, object>();

            if(name.Length != 0)
            {
                _dict.Add("name", name);
            }
            if (standort.Length != 0)
            {
                _dict.Add("standort", standort);
            }
            if (beschreibung.Length != 0)
            {
                _dict.Add("beschreibung", beschreibung);
            }
            if (lagertyp_id != null)
            {
                _dict.Add("lagertyp_id", lagertyp_id);
            }
            if (_dict.Count != 0)
            {
                _dict.Add("zuletzt_geaendert", zuletzt_geaendert);
                query.Update(_dict);
                SchreibeHistorieEintrag($"Lager ({lager_id}): {lager[0].Name} geändert!");
                OnDatabaseChanged(ModeltypEnum.LagerModel);
            }
        }
    }
}