using System;
using System.Collections.Generic;
using System.Linq;
using Lagerverwaltung.Model;
using SqlKata.Execution;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long,LagertypModel> HoleLagertyp(long lagertyp_id=-1,string name="", int limit=-1)
        {
            var query = queryfactory.Query("lagertyp").OrderBy("lagertyp_id");
            if(lagertyp_id>0)
            {
                query.Where("lagertyp_id",lagertyp_id);
            }
            if(name.Length != 0)
            {
                query.Where("name", name);
            }
            if(limit > 0)
            {
                query.Limit(limit);
            }
            return query.Get<LagertypModel>().ToDictionary(row => row.Lagertyp_ID,row => row);
        }

        public static void ErstelleLagertyp(string name)
        {
            var query = queryfactory.Query("lagertyp").Insert(new { name });
            OnDatabaseChanged(ModeltypEnum.LagertypModel);
        }

        public static void LoescheLagertyp(long lagertyp_id)
        {
            var query = queryfactory.Query("lagertyp").Where("lagertyp_id", lagertyp_id).Delete();
            OnDatabaseChanged(ModeltypEnum.LagertypModel);
        }

        public static void UpdateLagertyp(long lagertyp_id, string name)
        {
            var zuletzt_geändert = DateTime.Now;
            var query = queryfactory.Query("lagertyp").Where("lagertyp_id", lagertyp_id).Update(new { name, zuletzt_geändert });
            OnDatabaseChanged(ModeltypEnum.LagertypModel);
        }
    }
}