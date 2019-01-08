using System.Security.Cryptography;
using System.Text;
using System;
using System.Windows.Forms;

namespace Lagerverwaltung.Controller
{
    /// <summary>
    /// Statische Klasse die zur Authentifizierung genutzt wird.
    /// </summary>
    static class AuthenticationController
    {
        /// <summary>
        /// Get Methode um zu bestimmen ob der Nutzer beim Login richtig lag.
        /// </summary>
        public static bool Adminuser { get; set; }

        public static Model.UserModel GlobalUser { get; set; }

        // Loads stored hash + SALT and tests if hash(pw + SALT) = stored hash
        public static bool Login(string username, string pw)
        {
            try
            {
                string[] pw_and_salt = DB.UserSQL.HoleUserPasswordData(username);
                if (pw_and_salt == null)
                    return false;

                if (!(GeneratePasswordHash(pw, pw_and_salt[1]) == pw_and_salt[0]))
                    return false;
                return true;
            }
            catch (System.TypeInitializationException)
            {
                MessageBox.Show("Bitte vorher die PostgreSQL Datenbank starten!", "Keine Verbindung!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            return false;
        
        }

        // Change Password data of User
        public static bool ChangePassword(string username, string old_pw, string new_pw)
        {
            if (!Login(username, old_pw))
                return false;

            try
            {
                string salt = Create_Salt(10);
                if (!DB.UserSQL.UpdateUserPassword(username, GeneratePasswordHash(new_pw, salt), salt))
                    return false;
                return true;
            }
            catch
            {
                MessageBox.Show("Bitte vorher die PostgreSQL Datenbank starten!", "Keine Verbindung!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            return false;
        }

        // Creates Password String Hash from input password and SALT
        public static string GeneratePasswordHash(string password, string salt)
        {
            Byte[] enc_pass = Encode_2UTF(password);
            Byte[] enc_salt = Encode_2UTF(salt);
            Byte[] enc_hash = Hash_SHA1(ConcatByteArray(enc_pass, enc_salt));
            return Encode_2String(enc_hash);
        }

        // Generates Base64 String of certain length
        public static string Create_Salt(int length)
        {
            using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
            {
                byte[] tokenData = new byte[100];
                rng.GetBytes(tokenData);
                return Convert.ToBase64String(tokenData, 0, length).Substring(0, length);
            }
        }

        public static string Create_Salt(int length, int length_byte)
        {
            using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
            {
                byte[] tokenData = new byte[length_byte];
                rng.GetBytes(tokenData);
                return Convert.ToBase64String(tokenData, 0, length).Substring(0, length);
            }
        }

        // Sha512 Hash Function
        private static byte[] Hash_SHA1(byte[] stream)
        {
            using (SHA1 sha_man = new SHA1Managed())
            {
                return sha_man.ComputeHash(stream);
            }
        }
         
        // Encode String into UTF8 Byte Stream
        private static byte[] Encode_2UTF(string unencoded)
        {
            return Encoding.UTF8.GetBytes(unencoded);
        }

        // Converts Array of a Byte Stream into a concatenated String
        private static string Encode_2String(byte[] stream)
        {
            return BitConverter.ToString(stream).Replace("-", "");
        }

        //Concatenates 2 byte arrays
        private static byte[] ConcatByteArray(byte[] stream1, byte[] stream2)
        {
            int length = stream1.Length + stream2.Length;
            Byte[] sum = new byte[length];
            stream1.CopyTo(sum, 0);
            stream2.CopyTo(sum, stream1.Length);
            return sum;
        }
    }
}
