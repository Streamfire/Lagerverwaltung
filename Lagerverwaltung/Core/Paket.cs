using System.Diagnostics.Contracts;
using Lagerverwaltung.Core.Abstract;

namespace Lagerverwaltung.Core
{
	public sealed class Paket : Base
    {
        public ulong PaketID { get; }
        public ushort RegalfachID { get; }
        public string PaketBezeichnung { get; set; }
        public string Anschaffungsgrund { get; set; }
        public ushort Menge { get; set; }
        public uint ErstelltAm { get; }
        public uint GeaendertAm { get; }
        public uint Haltbarkeit { get; set; }

        public Produkt Produkt { get; set; }

        public override float Hoehe { get; set; }
        public override float Breite { get; set; }
        public override float Laenge { get; set; }

        public Paket(ulong paket_id, ushort regalfach_id, string paketBezeichnung, ushort menge, uint erstellt_am, uint geaendert_am, uint haltbarkeit, Produkt produkt, float hoehe, float breite, float laenge, string anschaffungsgrund)
        {
            Contract.Requires(paket_id >= 1);
            Contract.Requires(regalfach_id >= 1);
            Contract.Requires(paketBezeichnung.Length <= 15);   // plus minimal Länge laut Data Dictionary später
            Contract.Requires(menge >= 1);
            Contract.Requires(anschaffungsgrund.Length <= 50);
            Contract.Requires(hoehe >= 0);
            Contract.Requires(breite >= 0);
            Contract.Requires(laenge >= 0);
            PaketID = paket_id;
            RegalfachID = regalfach_id;
            Menge = menge;
            PaketBezeichnung = paketBezeichnung;
            ErstelltAm = erstellt_am;
            GeaendertAm = geaendert_am;
            Haltbarkeit = haltbarkeit;
            Produkt = produkt;
            Anschaffungsgrund = anschaffungsgrund;
        }

    }
}
