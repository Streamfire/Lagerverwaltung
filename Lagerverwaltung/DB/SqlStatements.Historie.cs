using Lagerverwaltung.Model;
using System.Collections.Generic;
using SqlKata.Execution;
using System.Linq;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long, HistorieModel> HoleHistorie(long log_id = -1, long user_id = -1, int limit = -1)
        {
            var query = queryfactory.Query("historie").OrderByDesc("log_id");
            if (log_id > 0)
            {
                query.Where("log_id", log_id);
            }
            if (user_id > 0)
            {
                query.Where("user_id", user_id);
            }
            if (limit > 0)
            {
                query.Limit(limit);
            }
            return query.Get<HistorieModel>().ToDictionary(row => row.Log_ID, row => row);
        }

        public static PaginationResult<HistorieModel> HoleHistorieSeite()
        {
            var query = queryfactory.Query("historie").OrderByDesc("log_id");
            return query.Paginate<HistorieModel>(1,25);
        }

        public static void SchreibeHistorieEintrag(string logtext)
        {
            var user_id = Controller.AuthenticationController.GlobalUser.User_ID; // workaround - Übergabe als Parameter immer besser, sonst Abhängigkeit!
            var zeitstempel = System.DateTime.Now;
            queryfactory.Query("historie").Insert(new { user_id, logtext, zeitstempel });
            OnDatabaseChanged(ModeltypEnum.HistorieModel);
        }
    }
}