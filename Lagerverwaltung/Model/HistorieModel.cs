using System;

namespace Lagerverwaltung.Model
{
    class HistorieModel
    {
        public long Log_ID { get; }
        public long User_ID { get; }
        public string LogText { get; }
        public DateTime Zeitstempel { get; }
    }
}
