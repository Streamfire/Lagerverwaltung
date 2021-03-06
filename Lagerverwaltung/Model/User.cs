﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Lagerverwaltung.Model
{
    public sealed class User
    {
        public ushort UserID { get; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Username { get; set; }
        public DateTime ErstelltAm { get; }
        public DateTime LetzterLogin { get; }
        public DateTime ZuletztGeaendert { get; }

        private static Dictionary<ushort, User> _dict = new Dictionary<ushort, User>();
        public static event EventHandler<EventArgs> UserHinzugefuegt;
        public static event EventHandler<EventArgs> UserEntfernt;

        public User()
        {

        }

        public User(ushort user_id, string vorname, string nachname, string username, DateTime erstellt_am, DateTime letzter_login, DateTime zuletzt_geaendert)
        {
            Contract.Requires(user_id >= 1);
            Contract.Requires(vorname.Length <= 20);    // plus minimal Länge laut Data Dictionary später
            Contract.Requires(nachname.Length <= 20);   // plus minimal Länge laut Data Dictionary später
            Contract.Requires(username.Length <= 10);   // plus minimal Länge laut Data Dictionary später
            UserID = user_id;
            Vorname = vorname;
            Nachname = nachname;
            Username = username;
            ErstelltAm = erstellt_am;
            LetzterLogin = letzter_login;
            ZuletztGeaendert = zuletzt_geaendert;

            Hinzufuegen(this);
        }

        private void Hinzufuegen(User tmp)
        {
            _dict.Add(tmp.UserID,tmp);
            UserHinzugefuegt?.Invoke(this, EventArgs.Empty);
        }

        public static bool Entfernen(ref User tmp)
        {
            if (_dict.Remove(tmp.UserID))
            {
                UserEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }
    }
}
