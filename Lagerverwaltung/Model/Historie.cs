using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lagerverwaltung.Model
{
    public sealed class Historie
    {
        public ulong LogID { get; }
        public ushort UserID { get; }
        public string LogText { get; }
        public DateTime Zeitstempel { get; }

        private static Dictionary<ulong,Historie> _dict = new Dictionary<ulong,Historie>();
        public static event EventHandler<EventArgs> HistorieHinzugefuegt;
        public static event EventHandler<EventArgs> HistorieEntfernt;

        public static ReadOnlyDictionary<ulong, Historie> HoleListe => new ReadOnlyDictionary<ulong, Historie>(_dict);

        public Historie(ulong log_id, ushort user_id, string logtext, DateTime zeitstempel)
        {
            LogID = log_id;
            UserID = user_id;
            LogText = logtext;
            Zeitstempel = zeitstempel;

            Hinzufuegen(this);

            var test = _dict.Values;
        }

        private void Hinzufuegen(Historie tmp)
        {
            if(tmp != null)
            {
                _dict.Add(tmp.LogID,tmp);
                HistorieHinzugefuegt?.Invoke(tmp, EventArgs.Empty);
            }
        }

        public static bool Entfernen(ref Historie tmp)
        {
            if(_dict.Remove(tmp.LogID))
            {
                HistorieEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }

        public static void Reset()
        {
            _dict.Clear();
        }
    }
}
