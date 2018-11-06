using Npgsql;

namespace Lagerverwaltung.Core
{
    public sealed class DatabaseFactory
    {
        private static DatabaseFactory _factory;
        private static NpgsqlConnection _connection;

        public static DatabaseFactory GetFactory()
        {
            if(_factory==null)
            {
                _factory = new DatabaseFactory();
            }
            return _factory;
        }

        public static NpgsqlConnection GetConnection()
        {
            if (_connection == null)
            {
                var connString = "Host=127.0.0.1;Username=postgres;Password=;Database=postgres";
                try
                {
                    _connection = new NpgsqlConnection(connString);
                    _connection.Open();
                }
                catch (System.Exception)
                {

                    throw;
                }

            }
            return _connection;
        }

        public static void CloseConnection()
        {
            _connection.Close();
        }
    }
}
