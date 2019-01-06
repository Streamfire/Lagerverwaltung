namespace Lagerverwaltung.Controller
{
    class ProduktHinzufuegenController
    {
        public static bool ValidateData(string name, string zeichnungsnummer, string gewicht, string preis, string hoehe, string breite, string laenge)
        {

            if (!ValidateName(name)) return false;
            if (!ValidateZeichnungsnummer(zeichnungsnummer)) return false;
            if (!ValidateGewicht(gewicht)) return false;
            if (!ValidatePreis(preis)) return false;

            return true;
        }

        private static bool ValidateName(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            return true;
        }

        private static bool ValidateZeichnungsnummer(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            return true;
        }

        private static bool ValidateGewicht(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            return true;
        }

        private static bool ValidatePreis(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            return true;
        }
        private static bool ValidateHoehe(string eingabe)
        {
            if (eingabe.Equals("")) return false;

            return true;
        }
        private static bool ValidateBreite(string eingabe)
        {
            if (eingabe.Equals("")) return false;

            return true;
        }
        private static bool ValidateLaenge(string eingabe)
        {
            if (eingabe.Equals("")) return false;

            return true;
        }
    }
}
