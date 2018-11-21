using System;
using System.Collections.Generic;

namespace Lagerverwaltung.Model
{
    public sealed class Historie
    {
        public ulong LogID { get; }
        public ushort UserID { get; }
        public string LogText { get; }
        public DateTime Zeitstempel { get; }

        private static List<Historie> _list = new List<Historie>();
        public static event EventHandler<EventArgs> HistorieHinzugefuegt;
        public static event EventHandler<EventArgs> HistorieEntfernt;

        public Historie(ulong log_id, ushort user_id, string logtext, DateTime zeitstempel)
        {
            LogID = log_id;
            UserID = user_id;
            LogText = logtext;
            Zeitstempel = zeitstempel;

            Hinzufuegen(this);
        }

        private void Hinzufuegen(Historie tmp)
        {
            if(tmp != null)
            {
                _list.Add(tmp);
                HistorieHinzugefuegt?.Invoke(tmp, EventArgs.Empty);
            }
        }

        public static bool Entfernen(ref Historie tmp)
        {
            if(_list.Remove(tmp))
            {
                HistorieEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }
    }
}
