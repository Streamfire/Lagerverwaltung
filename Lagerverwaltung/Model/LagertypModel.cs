using Lagerverwaltung.Core;

namespace Lagerverwaltung.Model
{
    public static class LagertypModel
    {
        // Funktioniert, aber Exception Handling fehlt!
        public static bool ErstelleLagertyp(string name)
        {
            var conn = DatabaseFactory.GetFactory().GetConnection();

            using (var cmd = new Npgsql.NpgsqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO lagertyp (name) VALUES (@name)";
                cmd.Parameters.AddWithValue("name",name);
                int result = cmd.ExecuteNonQuery();
                System.Console.WriteLine("Affected Rows: {0}", result.ToString()); //Testzwecken
                return result==0 ? false : true;
            }
        }
    }
}
