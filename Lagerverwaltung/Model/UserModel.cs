using System;

namespace Lagerverwaltung.Model
{
    class UserModel
    {
        public long User_ID { get; }
        public string Vorname { get; }
        public string Nachname { get; }
        public DateTime Erstellt_Am { get; }
        public DateTime Letzter_Login { get; }
        public DateTime Zuletzt_Geaendert { get; }
        public string Username { get; }
        public string Password { get; }
        public string Salt { get; }
    }
}
