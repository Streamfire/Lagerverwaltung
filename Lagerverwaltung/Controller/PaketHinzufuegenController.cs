using System;

namespace Lagerverwaltung.Controller
{
    class PaketHinzufuegenController
    {
		/// <summary>
		/// Funktion um die Pakethinzufuegedaten zu prüfen.
		/// </summary>
		/// <param name="paketbezeichnung"></param>
		/// <param name="anschaffungsgrund"></param>
		/// <param name="haltbarkeit"></param>
		/// <param name="hoehe"></param>
		/// <param name="breite"></param>
		/// <param name="laenge"></param>
		/// <returns></returns>
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

		/// <summary>
		/// Funktion um die Paketbezeichnung zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidatePaketbezeichnung(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            return true;
        }

		/// <summary>
		/// Funktion um den Anschaffungsgrund zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateAnschaffungsgrund(string eingabe)
        {
            return true;
        }

		/// <summary>
		/// Funktion um die Haltbarkeit zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateHaltbarkeit(DateTime eingabe)
        {
            //Validierung darauf, dass Haltbarkeit in der Zukunft liegt
            if (eingabe.CompareTo(DateTime.Now) <= 0) return false;

            return true;
        }

		/// <summary>
		/// Funktion um die Hoehe zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
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
                Console.WriteLine("Höhe enthält das falsche Format: {0}", e);
            }

            return true;
        }

		/// <summary>
		/// Funktion um die Breite zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
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
                Console.WriteLine("Breite enthält das falsche Format: {0}",e);
            }

            return true;
        }

		/// <summary>
		/// Funktion um die Laenge zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
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
                Console.WriteLine("Länge enthält das falsche Format: {0}", e);
            }

            return true;
        }
    }
}
