namespace Lagerverwaltung.Core
{
    public sealed class User
    {
        public byte UserID { get; }
        public byte RollenID { get; }
        public string Name { get; set; }
        public string Username { get; set; }
        public int Erstellt_Am { get; }
        public int Letzter_Login { get; }
        public int Zuletzt_Geaendert { get; }

        public User(byte user_id, byte rollen_id, string name, string username, int erstellt_am, int letzter_login, int zuletzt_geaendert)
        {
            UserID = user_id;
            RollenID = rollen_id;
            Name = name;
            Username = username;
            Erstellt_Am = erstellt_am;
            Letzter_Login = letzter_login;
            Zuletzt_Geaendert = zuletzt_geaendert;
        }
    }
}
