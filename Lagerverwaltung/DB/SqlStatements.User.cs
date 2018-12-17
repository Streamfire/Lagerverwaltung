using System;
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

        public static void ErstelleUser(string vorname, string nachname, string username, string password, string salt)
        {
            var query = queryfactory.Query("user").Insert(new { vorname, nachname, username, password, salt });
            OnDatabaseChanged(ModeltypEnum.UserModel);
        }

        public static void LoescheUser(long user_id)
        {
            var query = queryfactory.Query("user").Where("user_id", user_id).Delete();
            OnDatabaseChanged(ModeltypEnum.UserModel);
        }

        public static void UpdateUser(long user_id, string vorname ="", string nachname="", string username="", string password="", string salt="", DateTime? letzter_login=null)
        {
            var zuletzt_geaendert = DateTime.Now;
            var query = queryfactory.Query("user").Where("user_id", user_id);
            Dictionary<string, object> _dict = new Dictionary<string, object>();

            if(vorname.Length != 0)
            {
                _dict.Add("vorname", vorname);
            }
            if(nachname.Length != 0)
            {
                _dict.Add("nachname", nachname);
            }
            if(username.Length != 0)
            {
                _dict.Add("username", username);
            }
            if(password.Length != 0 && salt.Length != 0)
            {
                _dict.Add("password", password);
                _dict.Add("salt", salt);
            }
            if (letzter_login != null)
            {
                _dict.Add("letzter_login", letzter_login);
            }
            if(_dict.Count != 0)
            {
                _dict.Add("zuletzt_geaendert", zuletzt_geaendert);
                query.Update(_dict);
                OnDatabaseChanged(ModeltypEnum.UserModel);
            }
        }
    }
}