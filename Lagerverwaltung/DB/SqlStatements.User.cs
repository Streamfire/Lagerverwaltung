using System.Collections.Generic;
using System.Linq;
using Lagerverwaltung.Model;
using SqlKata.Execution;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long, UserModel> HoleUser(long user_id = -1, string username ="", int limit = -1)
        {
            var query = queryfactory.Query("user").OrderBy("user_id");
            if (user_id > 0)
            {
                query.Where("user_id", user_id);
            }
            if (username.Length != 0)
            {
                query.Where("username", username);
            }
            if (limit > 0)
            {
                query.Limit(limit);
            }
            return query.Get<UserModel>().ToDictionary(row => row.User_ID, row => row);
        }
    }
}