using System.Diagnostics.Contracts;

namespace Lagerverwaltung.Core
{
    public sealed class User
    {
        public ushort UserID { get; }
        public ushort RollenID { get; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Username { get; set; }
        public uint ErstelltAm { get; }
        public uint LetzterLogin { get; }
        public uint ZuletztGeaendert { get; }

        public User(ushort user_id, ushort rollen_id, string vorname, string nachname, string username, uint erstellt_am, uint letzter_login, uint zuletzt_geaendert)
        {
            Contract.Requires(user_id >= 1);
            Contract.Requires(rollen_id >= 1);
            Contract.Requires(vorname.Length <= 20);    // plus minimal Länge laut Data Dictionary später
            Contract.Requires(nachname.Length <= 20);   // plus minimal Länge laut Data Dictionary später
            Contract.Requires(username.Length <= 10);   // plus minimal Länge laut Data Dictionary später
            UserID = user_id;
            RollenID = rollen_id;
            Vorname = vorname;
            Nachname = nachname;
            Username = username;
            ErstelltAm = erstellt_am;
            LetzterLogin = letzter_login;
            ZuletztGeaendert = zuletzt_geaendert;
        }
    }
}
