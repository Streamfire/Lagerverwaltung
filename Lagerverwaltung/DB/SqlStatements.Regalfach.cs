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

        public static void ErstelleRegalfach()
        {
            throw new NotImplementedException();
        }

        public static void LoescheRegalfach(long regalfach_id)
        {
            var query = queryfactory.Query("regalfach").Where("regalfach_id", regalfach_id).Delete();
            OnDatabaseChanged(ModeltypEnum.RegalfachModel);
        }

        public static void UpdateRegalfach()
        {
            throw new NotImplementedException();
        }
    }
}