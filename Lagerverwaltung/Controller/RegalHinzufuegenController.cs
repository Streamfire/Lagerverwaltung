﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.Controller
{
    class RegalHinzufuegenController
    {
        /// <summary>
        /// Funktion für die Überprufung der Eingegebenen Daten in dem Fenster RegalHinzufügen
        /// </summary>
        /// <param name="regalname"></param>
        /// <param name="zeilen"></param>
        /// <param name="spalten"></param>
        /// <param name="regalH"></param>
        /// <param name="regalB"></param>
        /// <param name="regalL"></param>
        /// <param name="fachH"></param>
        /// <param name="fachB"></param>
        /// <param name="fachL"></param>
        /// <param name="wandH"></param>
        /// <param name="wandV"></param>
        /// <returns>Gibt true zurück, falls alle Eingaben in dem RegalHinzufügen Fenster valide sind</returns>
        public static bool ValidateData(string regalname, string zeilen, string spalten, string regalH, string regalB, string regalL, string fachH, string fachB, string fachL, string wandH, string wandV)
        {
            if (!ValidateRegalname(regalname)) return false;
            if (!ValidateZeilen(zeilen)) return false;
            if (!ValidateSpalten(spalten)) return false;
            if (!ValidateRegalH(regalH)) return false;
            if (!ValidateRegalB(regalB)) return false;
            if (!ValidateRegalL(regalL)) return false;
            if (!ValidateFachH(fachH)) return false;
            if (!ValidateFachB(fachB)) return false;
            if (!ValidateFachL(fachL)) return false;
            if (!ValidateWandH(wandH)) return false;
            if (!ValidateWandV(wandV)) return false;
            return true;
        }

		/// <summary>
		/// Funktion um die Regalmaßangaben zu prüfen.
		/// </summary>
		/// <param name="zeilen">Zeilenzahl</param>
		/// <param name="spalten">Spaltenzahl</param>
		/// <param name="regalH">Regalhoehe</param>
		/// <param name="regalB">Regalbreite</param>
		/// <param name="regalL">Regallaenge</param>
		/// <param name="fachH">Fachhoehe</param>
		/// <param name="fachB">Fachbreite</param>
		/// <param name="fachL">Fachlänge</param>
		/// <param name="wandH">Trennwandstärke Horizontal</param>
		/// <param name="wandV">Trennwandstärke Vertikal</param>
		/// <returns>true wenn die Groeße von Regal und Regalfächern sich nicht widersprechen</returns>
        public static bool ValidateGroesse(short zeilen, short spalten, float regalH, float regalB, float regalL, float fachH, float fachB, float fachL, float wandH, float wandV)
        {
            //mind. Anzahl Spalten/Zeilen -1 an Trennwänden
            //Zeilen bzw. Höhe
            if (((zeilen * fachH) + ((zeilen - 1) * wandH)) > regalH) return false;

            //Spalten bzw. Breite
            if (((spalten * fachB) + ((spalten - 1) * wandV)) > regalB) return false;

            //Fachlänge darf nicht größer als Regallänge sein; kleiner ist durch eventuelle Rückwand möglich
            if (fachL > regalL) return false;

            return true;
        }

		/// <summary>
		/// Funktion um den Regalnamen zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateRegalname(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            //Keine Bindestriche dürfen enthalten sein
            if (eingabe.Contains('-')) return false;

            return true;
        }

		/// <summary>
		/// Funktion um die Zeilenzahl zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateZeilen(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            try
            {
                if (Convert.ToInt16(eingabe) <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Zeilen enthält das falsche Format: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Zeilenwert ist zu groß: {0}", e);
            }

            return true;
        }

		/// <summary>
		/// Funktion um die Spaltenzahl zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateSpalten(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            try
            {
                if (Convert.ToInt16(eingabe) <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Spalten enthält das falsche Format: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Spaltenwert ist zu groß: {0}", e);
            }

            return true;
        }

		/// <summary>
		/// Funktion um die Regalhoehe zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateRegalH(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            try
            {
                if (Convert.ToSingle(eingabe) <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Regalhöhe enthält das falsche Format: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Regalhöhe ist zu groß: {0}", e);
            }

            return true;
        }

		/// <summary>
		/// Funktion um die Regalbreite zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateRegalB(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            try
            {
                if (Convert.ToSingle(eingabe) <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Regalbreite enthält das falsche Format: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Regalbreite ist zu groß: {0}", e);
            }

            return true;
        }

		/// <summary>
		/// Funktion um die Regallaenge zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateRegalL(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            try
            {
                if (Convert.ToSingle(eingabe) <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Regallänge enthält das falsche Format: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Regallänge ist zu groß: {0}", e);
            }

            return true;
        }

		/// <summary>
		/// Funktion um die Regalhoehe zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateFachH(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            try
            {
                if (Convert.ToSingle(eingabe) <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Regalfachhöhe enthält das falsche Format: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Regalfachhöhe ist zu groß: {0}", e);
            }

            return true;
        }

		/// <summary>
		/// Funktion um die Regalfachbreite zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateFachB(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            try
            {
                if (Convert.ToSingle(eingabe) <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Regalfachbreite enthält das falsche Format: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Regalfachbreite ist zu groß: {0}", e);
            }

            return true;
        }

		/// <summary>
		/// Funktion um die Regalfachlaenge zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateFachL(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            try
            {
                if (Convert.ToSingle(eingabe) <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Regalfachlänge enthält das falsche Format: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Regalfachlänge ist zu groß: {0}", e);
            }

            return true;
        }

		/// <summary>
		/// Funktion um die Trennwandstärke (horizontal) zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateWandH(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            try
            {
                if (Convert.ToSingle(eingabe) <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Horizontale Wandstärke enthält das falsche Format: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Horizontale Wandstärke ist zu groß: {0}", e);
            }

            return true;
        }

		/// <summary>
		/// Funktion um die Trennwandstärke (vertikal) zu prüfen.
		/// </summary>
		/// <param name="eingabe"> der Eingabestring</param>
		/// <returns>true wenn der Eingabestring Daten des richtigen Formats enthält.</returns>
		private static bool ValidateWandV(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            try
            {
                if (Convert.ToSingle(eingabe) <= 0) return false;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Vertikale Wandstärke enthält das falsche Format: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Vertikale Wandstärke ist zu groß: {0}", e);
            }

            return true;
        }
    }
}
