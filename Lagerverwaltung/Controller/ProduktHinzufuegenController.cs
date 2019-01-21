namespace Lagerverwaltung.Controller
{
    class ProduktHinzufuegenController
    {
		/// <summary>
		/// Funktion um die Eingabedaten des Produkthinzufuegens zu prüfen.
		/// </summary>
		/// <param name="name"> Produktname</param>
		/// <param name="zeichnungsnummer">Zeichnungsnummer</param>
		/// <param name="gewicht">Gewicht</param>
		/// <param name="preis">Preis</param>
		/// <param name="hoehe">Hoehe</param>
		/// <param name="breite">Breite</param>
		/// <param name="laenge">Laenge</param>
		/// <returns></returns>
        public static bool ValidateData(string name, string zeichnungsnummer, string gewicht, string preis, string hoehe, string breite, string laenge)
        {

            if (!ValidateName(name)) return false;
            if (!ValidateZeichnungsnummer(zeichnungsnummer)) return false;
            if (!ValidateGewicht(gewicht)) return false;
            if (!ValidatePreis(preis)) return false;

            return true;
        }

		/// <summary>
		/// Funktion um den Namen zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateName(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            return true;
        }

		/// <summary>
		/// Funktion um die Zeichnungsnummer zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateZeichnungsnummer(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            return true;
        }

		/// <summary>
		/// Funktion um das Gewicht zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateGewicht(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            return true;
        }

		/// <summary>
		/// Funktion um den Preis zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidatePreis(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            return true;
        }

		/// <summary>
		/// Funktion um die Hoehe zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateHoehe(string eingabe)
        {
            if (eingabe.Equals("")) return false;

            return true;
        }

		/// <summary>
		/// Funktion um die Breite zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateBreite(string eingabe)
        {
            if (eingabe.Equals("")) return false;

            return true;
        }

		/// <summary>
		/// Funktion um die Laenge zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateLaenge(string eingabe)
        {
            if (eingabe.Equals("")) return false;

            return true;
        }
    }
}
