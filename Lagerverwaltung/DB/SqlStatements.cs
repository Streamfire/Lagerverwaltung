using Lagerverwaltung.Core;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        private static readonly QueryFactory queryfactory;
        static SqlStatements()
        {
            var conn = DatabaseFactory.GetFactory().GetConnection();
            var compiler = new PostgresCompiler();
            queryfactory = new QueryFactory(conn,compiler);
        }
    }
}
