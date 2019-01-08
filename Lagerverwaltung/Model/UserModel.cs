using System;

namespace Lagerverwaltung.Model
{
    class UserModel
    {
        public long User_ID { get; } = 0;
        public string Vorname { get; }
        public string Nachname { get; }
        public DateTime Erstellt_Am { get; }
        public DateTime Letzter_Login { get; }
        public DateTime Zuletzt_Geaendert { get; }
        public string Username { get; } = "Gast";
        public string Password { get; }
        public string Salt { get; }
    }
}