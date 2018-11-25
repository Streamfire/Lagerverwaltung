using System.Security.Cryptography;
using System.Text;
using System;
using Npgsql;
using Lagerverwaltung.Core;

namespace Lagerverwaltung.Controller
{
    /// <summary>
    /// Statische Klasse die zur Authentifizierung genutzt wird.
    /// </summary>
    static class AuthenticationController
    {
        // Nutzt bsp. den UserModel um abzufragen ob User usw vorhanden ist.
        // Dann vergleicht er das PW und je nachdem werden dann entsprechende Views geöffnet :)

        public static bool Login(string username, string pw)
        {
            string[] pass_and_salt = DB.UserSQL.HoleUserPasswordData(username);
            if (pass_and_salt == null)
                return false;
           
            Byte[] enc_pass = Encoding.UTF8.GetBytes(pw);
            using (SHA512 sha_man = new SHA512Managed())
            {
                Byte[] enc_salt = Encoding.UTF8.GetBytes(pass_and_salt[1]);
                int length = enc_salt.Length + enc_pass.Length;
                byte[] pw_sum = new byte[length];
                enc_pass.CopyTo(pw_sum, 0);
                enc_salt.CopyTo(pw_sum, enc_pass.Length);
                pw_sum = sha_man.ComputeHash(pw_sum);
                if (!(BitConverter.ToString(pw_sum).Replace("-","") == pass_and_salt[0]))
                    return false;
                return true;
            }
        }

        static void Logout()
        {
            //schließe alle Forms und zeige Login-Form wieder
        }
    }
}
