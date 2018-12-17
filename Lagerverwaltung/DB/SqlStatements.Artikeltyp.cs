using System;
using System.Collections.Generic;
using System.Linq;
using Lagerverwaltung.Model;
using SqlKata.Execution;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        public static Dictionary<long, ArtikeltypModel> HoleArtikeltyp(long artikeltyp_id = -1, string name = "", int limit = -1)
        {
            var query = queryfactory.Query("artikeltyp").OrderBy("artikeltyp_id");
            if (artikeltyp_id > 0)
            {
                query.Where("artikeltyp_id", artikeltyp_id);
            }
            if (name.Length != 0)
            {
                query.Where("name", name);
            }
            if (limit > 0)
            {
                query.Limit(limit);
            }
            return query.Get<ArtikeltypModel>().ToDictionary(row => row.Artikeltyp_ID, row => row);
        }

        public static void ErstelleArtikeltyp(string name)
        {
            var query = queryfactory.Query("artikeltyp").Insert(new { name });
            OnDatabaseChanged(ModeltypEnum.ArtikeltypModel);
        }

        public static void LoescheArtikeltyp(long artikeltyp_id)
        {
            var query = queryfactory.Query("artikeltyp").Where("artikeltyp_id", artikeltyp_id).Delete();
            OnDatabaseChanged(ModeltypEnum.ArtikeltypModel);
        }

        public static void UpdateArtikeltyp(long artikeltyp_id, string name)
        {
            var zuletzt_geaendert = DateTime.Now;
            var query = queryfactory.Query("artikeltyp").Where("artikeltyp_id", artikeltyp_id).Update(new { name, zuletzt_geaendert });
            OnDatabaseChanged(ModeltypEnum.ArtikeltypModel);
        }
    }
}