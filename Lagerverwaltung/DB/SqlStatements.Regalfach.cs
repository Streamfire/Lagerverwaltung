using Lagerverwaltung.Model;
using SqlKata.Execution;
using System;
using System.Collections.Generic;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long, RegalfachModel> HoleRegalfach()
        {
            throw new NotImplementedException();
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
            var zuletzt_geändert = DateTime.Now;
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
                _dict.Add("zuletzt_geändert", zuletzt_geändert);
                query.Update(_dict);
                OnDatabaseChanged(ModeltypEnum.RegalfachModel);
            }
        }
    }
}