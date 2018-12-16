using Lagerverwaltung.Model;
using SqlKata.Execution;
using System;
using System.Collections.Generic;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long,ProduktModel> HoleProdukt()
        {
            throw new NotImplementedException();
        }

        public static void ErstelleProdukt()
        {
            throw new NotImplementedException();
        }

        public static void LoescheProdukt(long produkt_id)
        {
            var query = queryfactory.Query("produkt").Where("produkt_id", produkt_id).Delete();
            OnDatabaseChanged(ModeltypEnum.ProduktModel);
        }

        public static void UpdateProdukt()
        {
            throw new NotImplementedException();
        }
    }
}