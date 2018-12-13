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
    }
}