using System;
using System.Collections.Generic;
using System.Linq;
using Lagerverwaltung.Model;
using SqlKata.Execution;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long,RegalModel> HoleRegal(long regal_id=-1, long lager_id=-1, string name="", int limit=-1)
        {
            var query = queryfactory.Query("regal").OrderBy("regal_id");
            if (regal_id > 0)
            {
                query.Where("regal_id", regal_id);
            }
            if (lager_id > 0)
            {
                query.Where("lager_id", lager_id);
            }
            if(name.Length != 0)
            {
                query.Where("name", name);
            }
            if (limit > 0)
            {
                query.Limit(limit);
            }
            return query.Get<RegalModel>().ToDictionary(row => row.Regal_ID, row => row);
        }

        public static long ErstelleRegal(string name, long lager_id, short zeilen, short spalten, float hoehe, float breite, float laenge, float v_wandstaerke, float h_wandstaerke)
        {
            var query = queryfactory.Query("regal").Insert(new { name, lager_id, zeilen, spalten, hoehe, breite, laenge, v_wandstaerke, h_wandstaerke });

            //Da InsertGetId<> nix zurückgibt: 
            var queryID = queryfactory.Query("regal").OrderByDesc("erstellt_am").Limit(1);

            OnDatabaseChanged(ModeltypEnum.LagerModel);

            return queryID.Get<RegalModel>().First().Regal_ID;
        }

        public static void LoescheRegal(long regal_id)
        {
            var query = queryfactory.Query("regal").Where("regal_id", regal_id).Delete();
            OnDatabaseChanged(ModeltypEnum.RegalModel);
        }

        public static void UpdateRegal(long regal_id, string name="", long? lager_id=null, short? zeilen=null, short? spalten=null, float? hoehe=null, float? breite=null, float? laenge=null, float? v_wandstaerke=null, float? h_wandstaerke=null)
        {
            var zuletzt_geaendert = DateTime.Now;
            var query = queryfactory.Query("regal").Where("regal_id", regal_id);
            Dictionary<string, object> _dict = new Dictionary<string, object>();

            if (name.Length != 0)
            {
                _dict.Add("name", name);
            }
            if(lager_id != null)
            {
                _dict.Add("lager_id", lager_id);
            }
            if (zeilen != null)
            {
                _dict.Add("zeilen", zeilen);
            }
            if (spalten != null)
            {
                _dict.Add("spalten", spalten);
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
            if (v_wandstaerke != null)
            {
                _dict.Add("v_wandstaerke", v_wandstaerke);
            }
            if (h_wandstaerke != null)
            {
                _dict.Add("h_wandstaerke", h_wandstaerke);
            }
            if (_dict.Count != 0)
            {
                _dict.Add("zuletzt_geaendert", zuletzt_geaendert);
                query.Update(_dict);
                OnDatabaseChanged(ModeltypEnum.RegalModel);
            }
        }
    }
}