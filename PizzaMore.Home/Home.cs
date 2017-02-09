namespace PizzaMore.Home
{
    using Data.Models;
    using Utility.Models;
    using System.Collections.Generic;

    class Home
    {
        private static IDictionary<string, string> RequestParameters;
        private static Session Session;
        private static Header Header = new Header();
        private static string Language;

        static void Main()
        {
            AddDefaultLanguageCookie();

            if (WebUtil.IsGet())
            {
                RequestParameters = WebUtil.RetrieveGetParameters();
                Language = WebUtil.GetCookies()["lang"].CookieValue;
            }
            else if (WebUtil.IsPost())
            {
                RequestParameters = WebUtil.RetrievePostParameters();
                Header.AddCookie(new Cookie("lang", RequestParameters["language"]));
                Language = RequestParameters["language"];
            }

            ShowPage();
        }

        private static void AddDefaultLanguageCookie()
        {
            if (!WebUtil.GetCookies().ContainsKey("lang"))
            {
                var defaultCookie = new Cookie("lang", "EN");
                Header.AddCookie(defaultCookie);
                Language = "EN";
                ShowPage();
            }
        }

        private static void ShowPage()
        {
            Header.Print();

            if (Language.Equals("BG"))
            {
                ServeHtmlBg();
            }
            else
            {
                ServeHtmlEn();
            }
        }

        private static void ServeHtmlEn()
        {
            WebUtil.PrintFileContent("home.html");
        }

        private static void ServeHtmlBg()
        {
            WebUtil.PrintFileContent("home-bg.html");
        }
    }
}