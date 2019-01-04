using System;

namespace KatalonDemoExportTest
{
    // Used for the test simulation
    public class MySite
    {
        public string url = "Chick site url";
        public string usernameField = "Username field";
        public string loginButton = "Login button";
        public string errorMessage = "Please enter a valid e-mail address";

        public MySite()
        {
            Console.WriteLine("The browser is open!");
        }
    }
}
