namespace Lagerverwaltung.Controller
{

    /// <summary>
    /// Statische Klasse die zur Authentifizierung genutzt wird.
    /// </summary>
    static class AuthenticationController
    {
        // Nutzt bsp. den UserModel um abzufragen ob User usw vorhanden ist.
        // Dann vergleicht er das PW und je nachdem werden dann entsprechende Views geöffnet :)

        static bool Login(string name, string pw)
        {
            return false;
        }

        static void Logout()
        {
            //schließe alle Forms und zeige Login-Form wieder
        }
    }
}
