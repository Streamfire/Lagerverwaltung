using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Model
{
	public sealed class Paket : Base
    {
        public uint PaketID { get; }
        public ushort RegalfachID { get; }
        public uint ProduktID { get; }
        public string Name { get; set; }
        public string Anschaffungsgrund { get; set; }
        public ushort Menge { get; set; }
        public DateTime ErstelltAm { get; }
        public DateTime GeaendertAm { get; }
        public DateTime Haltbarkeit { get; set; }
        public override float Hoehe { get; set; }
        public override float Breite { get; set; }
        public override float Laenge { get; set; }

        private static List<Paket> _list = new List<Paket>();
        public static event EventHandler<EventArgs> PaketHinzugefuegt;
        public static event EventHandler<EventArgs> PaketEntfernt;

        public Paket(uint paket_id, ushort regalfach_id, string name, ushort menge, DateTime erstellt_am, DateTime geaendert_am, DateTime haltbarkeit, uint produkt_id, float hoehe, float breite, float laenge, string anschaffungsgrund)
        {
            Contract.Requires(paket_id >= 1);
            Contract.Requires(regalfach_id >= 1);
            Contract.Requires(name.Length <= 15);   // plus minimal Länge laut Data Dictionary später
            Contract.Requires(menge >= 1);
            Contract.Requires(anschaffungsgrund.Length <= 50);
            Contract.Requires(hoehe >= 0);
            Contract.Requires(breite >= 0);
            Contract.Requires(laenge >= 0);
            PaketID = paket_id;
            RegalfachID = regalfach_id;
            Menge = menge;
            Name = name;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
            Haltbarkeit = haltbarkeit;
            ProduktID = produkt_id;
            Anschaffungsgrund = anschaffungsgrund;

            Hinzufuegen(this);
        }

        private void Hinzufuegen(Paket tmp)
        {
            _list.Add(tmp);
            PaketHinzugefuegt?.Invoke(this, EventArgs.Empty);
        }

        public static bool Entfernen(ref Paket tmp)
        {
            if (_list.Remove(tmp))
            {
                PaketEntfernt?.Invoke(tmp, EventArgs.Empty);
                tmp = null;
                return true;
            }
            return false;
        }
    }
}
