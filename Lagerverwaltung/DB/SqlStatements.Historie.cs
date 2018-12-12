using Lagerverwaltung.Model;
using System.Collections.Generic;
using SqlKata.Execution;
using System.Linq;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long, HistorieModel> HoleHistorie(long log_id=-1, long user_id=-1, int limit=-1)
        {
            var query = queryfactory.Query("historie").OrderBy("log_id");
            if(log_id>0)
            {
                query.Where("log_id",log_id);
            }
            if (user_id > 0)
            {
                query.Where("user_id",user_id);
            }
            if(limit>0)
            {
                query.Limit(limit);
            }
            return query.Get<HistorieModel>().ToDictionary(row => row.Log_ID, row => row);
        }
    }
}