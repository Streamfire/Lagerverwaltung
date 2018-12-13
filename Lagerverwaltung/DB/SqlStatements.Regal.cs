using System.Collections.Generic;
using System.Linq;
using Lagerverwaltung.Model;
using SqlKata.Execution;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long,RegalModel> HoleRegal(long regal_id=-1, long lager_id=-1, int limit=-1)
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
            if (limit > 0)
            {
                query.Limit(limit);
            }
            return query.Get<RegalModel>().ToDictionary(row => row.Regal_ID, row => row);
        }
    }
}