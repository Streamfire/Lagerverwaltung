using Lagerverwaltung.Model;
using SqlKata.Execution;
using System;
using System.Collections.Generic;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long, PaketModel> HolePaket()
        {
            throw new NotImplementedException();
        }

        public static void ErstellePaket()
        {
            throw new NotImplementedException();
        }

        public static void LoeschePaket(long paket_id)
        {
            var query = queryfactory.Query("paket").Where("paket_id", paket_id).Delete();
            OnDatabaseChanged(ModeltypEnum.PaketModel);
        }

        public static void UpdatePaket()
        {
            throw new NotImplementedException();
        }
    }
}