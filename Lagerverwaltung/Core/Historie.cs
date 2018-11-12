using System;

namespace Lagerverwaltung.Core
{
    public class Historie
    {
        public ulong LogID { get; }
        public ushort UserID { get; }
        public string LogText { get; }
        public DateTime Zeitstempel { get; }

        public Historie(ulong log_id, ushort user_id, string logtext, DateTime zeitstempel)
        {
            LogID = log_id;
            UserID = user_id;
            LogText = logtext;
            Zeitstempel = zeitstempel;
        }
    }
}
