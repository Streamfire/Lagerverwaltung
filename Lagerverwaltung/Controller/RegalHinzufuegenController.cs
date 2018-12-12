using System;
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

        private static bool ValidateRegalname(string eingabe)
        {
            //Validierung auf Leeren String
            if (eingabe.Equals("")) return false;

            //Keine Bindestriche dürfen enthalten sein
            if (eingabe.Contains('-')) return false;

            return true;
        }

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

            return true;
        }

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

            return true;
        }

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

            return true;
        }

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

            return true;
        }

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

            return true;
        }

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

            return true;
        }

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

            return true;
        }

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

            return true;
        }

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

            return true;
        }

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

            return true;
        }
    }
}
