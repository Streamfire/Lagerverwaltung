using System;
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
        public DateTime ErstelltAm { get; }
        public DateTime LetzterLogin { get; }
        public DateTime ZuletztGeaendert { get; }

        public User(ushort user_id, ushort rollen_id, string vorname, string nachname, string username, DateTime erstellt_am, DateTime letzter_login, DateTime zuletzt_geaendert)
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
