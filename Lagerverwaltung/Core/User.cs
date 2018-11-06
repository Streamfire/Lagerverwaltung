namespace Lagerverwaltung.Core
{
    public sealed class User
    {
        public byte UserID { get; }
        public byte RollenID { get; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int ErstelltAm { get; }
        public int LetzterLogin { get; }
        public int ZuletztGeaendert { get; }

        public User(byte user_id, byte rollen_id, string name, string username, int erstellt_am, int letzter_login, int zuletzt_geaendert)
        {
            UserID = user_id;
            RollenID = rollen_id;
            Name = name;
            Username = username;
            ErstelltAm = erstellt_am;
            LetzterLogin = letzter_login;
            ZuletztGeaendert = zuletzt_geaendert;
        }
    }
}
