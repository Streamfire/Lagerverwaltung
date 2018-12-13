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
    }
}