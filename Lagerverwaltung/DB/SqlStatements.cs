using System;
using Lagerverwaltung.Core;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace Lagerverwaltung.DB
{
    static partial class SqlStatements
    {
        private static readonly QueryFactory queryfactory;

		/// <summary>
		/// Eventhandler der alle Subscriber ueber Aenderungen an der Datenbank informiert.
		/// </summary>
        public static event EventHandler<EventArgs> DatabaseChanged;

		static SqlStatements()
        {
            var conn = DatabaseFactory.GetFactory().GetConnection();
            var compiler = new PostgresCompiler();
            queryfactory = new QueryFactory(conn,compiler);
        }

        private static void OnDatabaseChanged(ModeltypEnum typ)
        {
            DatabaseChanged?.Invoke(typ, EventArgs.Empty);
        }

		/// <summary>
		/// Enumeration ueber die Modeltypen.
		/// </summary>
        public enum ModeltypEnum
        {
            ArtikeltypModel,
            HistorieModel,
            LagerModel,
            LagertypModel,
            PaketModel,
            ProduktModel,
            RegalfachModel,
            RegalModel,
            UserModel
        }
    }
}
