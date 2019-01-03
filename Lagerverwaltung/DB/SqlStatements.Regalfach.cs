using Lagerverwaltung.Model;
using SqlKata.Execution;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long, RegalfachModel> HoleRegalfach(long regalfach_id = -1, long regal_id =-1, string name="", int limit=-1)
        {
            var query = queryfactory.Query("regalfach").OrderBy("regalfach_id");
            if (regalfach_id > 0)
            {
                query.Where("regalfach_id", regalfach_id);
            }
            if (regal_id > 0)
            {
                query.Where("regal_id", regal_id);
            }
            if (name.Length != 0)
            {
                query.Where("name", name);
            }
            if (limit > 0)
            {
                query.Limit(limit);
            }
            return query.Get<RegalfachModel>().ToDictionary(row => row.Regalfach_ID, row => row);
        }

        public static void ErstelleRegalfach(string name, long regal_id, string bemerkung, float hoehe, float breite, float laenge)
        {
            var query = queryfactory.Query("regalfach").Insert(new { name, regal_id, bemerkung, hoehe, breite, laenge });
            OnDatabaseChanged(ModeltypEnum.RegalfachModel);
        }

        public static void LoescheRegalfach(long regalfach_id)
        {
            var query = queryfactory.Query("regalfach").Where("regalfach_id", regalfach_id).Delete();
            OnDatabaseChanged(ModeltypEnum.RegalfachModel);
        }

        public static void UpdateRegalfach(long regalfach_id, string name="", long? regal_id=null, string bemerkung="", float? hoehe=null, float? breite=null, float? laenge=null)
        {
            var zuletzt_geaendert = DateTime.Now;
            var query = queryfactory.Query("regalfach").Where("regalfach_id", regalfach_id);
            Dictionary<string, object> _dict = new Dictionary<string, object>();

            if (name.Length != 0)
            {
                _dict.Add("name", name);
            }
            if (regal_id != null)
            {
                _dict.Add("regal_id", regal_id);
            }
            if (bemerkung.Length != 0)
            {
                _dict.Add("bemerkung", bemerkung);
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
                OnDatabaseChanged(ModeltypEnum.RegalfachModel);
            }
        }
    }
}