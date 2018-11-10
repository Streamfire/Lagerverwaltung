using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Controller
{
    class PaketHinzufuegenController
    {
        public static bool ValidateData(string paketbezeichnung, string anschaffungsgrund, DateTime haltbarkeit, string hoehe, string breite, string laenge)
        {

            if (!ValidatePaketbezeichnung(paketbezeichnung)) return false;
            if (!ValidateAnschaffungsgrund(anschaffungsgrund)) return false;
            if (!ValidateHaltbarkeit(haltbarkeit)) return false;
            if (!ValidateHoehe(hoehe)) return false;
            if (!ValidateBreite(breite)) return false;
            if (!ValidateLaenge(laenge)) return false;

            return true;
        }

        private static bool ValidatePaketbezeichnung(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            return true;
        }

        private static bool ValidateAnschaffungsgrund(string eingabe)
        {
            return true;
        }

        private static bool ValidateHaltbarkeit(DateTime eingabe)
        {
            //Validierung darauf, dass Haltbarkeit in der Zukunft liegt
            if (eingabe.CompareTo(DateTime.Now) <= 0) return false;

            return true;
        }

        private static bool ValidateHoehe(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            //Validierung, ob Wert nur Zahlen enthaelt
            try
            {
                float wert = Convert.ToSingle(eingabe);

                //Validierung, ob Wert kleiner gleich 0 ist
                if (wert <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Höhe enthält das falsche Format: {0}", eingabe);
            }

            return true;
        }

        private static bool ValidateBreite(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            //Validierung, ob Wert nur Zahlen enthaelt
            try
            {
                float wert = Convert.ToSingle(eingabe);

                //Validierung, ob Wert kleiner gleich 0 ist
                if (wert <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Breite enthält das falsche Format: {0}",eingabe);
            }

            return true;
        }

        private static bool ValidateLaenge(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            //Validierung, ob Wert nur Zahlen enthaelt
            try
            {
                float wert = Convert.ToSingle(eingabe);

                //Validierung, ob Wert kleiner gleich 0 ist
                if (wert <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Länge enthält das falsche Format: {0}", eingabe);
            }

            return true;
        }
    }
}
