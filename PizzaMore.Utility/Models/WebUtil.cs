namespace PizzaMore.Utility.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PizzaMore.Utility.Interfaces;
    using Data.Models;
    using System.Net;
    using System.IO;
    using Data;

    public static class WebUtil
    {
        #region Methods
        public static bool IsGet()
        {
            var environmentVariable = Environment.GetEnvironmentVariable(Constants.RequestMethod);
            environmentVariable = environmentVariable.ToLower();

            if (environmentVariable != null)
            {
                if (environmentVariable == "get")
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsPost()
        {
            var environmentVariable = Environment.GetEnvironmentVariable(Constants.RequestMethod);
            environmentVariable = environmentVariable.ToLower();

            if (environmentVariable != null)
            {
                if (environmentVariable == "post")
                {
                    return true;
                }
            }

            return false;
        }

        public static IDictionary<string, string> RetrieveGetParameters()
        {
            string parameters = WebUtility.UrlDecode(Environment.GetEnvironmentVariable(Constants.QueryString));

            return RetrieveRequestParameters(parameters);
        }

        public static IDictionary<string, string> RetrievePostParameters()
        {
            string parameters = WebUtility.UrlDecode(Console.ReadLine());

            return RetrieveRequestParameters(parameters);
        }

        public static IDictionary<string, string> RetrieveRequestParameters(string parametersString)
        {
            var resultPrameters = new Dictionary<string, string>();
            var parameters = parametersString.Split('&');

            foreach (var param in parameters)
            {
                var pair = param.Split('=');
                var key = pair[0];
                string value = null;
                if (pair.Count() > 1)
                {
                    value = pair[1];
                }

                resultPrameters.Add(key, value);
            }

            return resultPrameters;
        }

        public static ICookieCollection GetCookies()
        {
            string cookieString = Environment.GetEnvironmentVariable(Constants.GetCookie);

            if (string.IsNullOrEmpty(cookieString))
            {
                return new CookieCollection();
            }

            var cookies = new CookieCollection();
            string[] cookieParameters = cookieString.Split(';');

            foreach (var cookieParam in cookieParameters)
            {
                string[] pair = cookieParam.Split('=').Select(c => c.Trim()).ToArray();
                var cookie = new Cookie(pair[0], pair[1]);
                cookies.AddCookie(cookie);
            }

            return cookies;
        }

        public static Session GetSession()
        {
            var cookies = GetCookies();

            if (!cookies.ContainsKey(Constants.SessionId))
            {
                return null;
            }

            var sessionCookie = cookies[Constants.SessionId];
            var context = new PizzaMoreContext();

            var session = context.Sessions.FirstOrDefault(x => x.Id == sessionCookie.CookieValue);

            return session;
        }

        public static void PrintFileContent(string path)
        {
            string fileContent = File.ReadAllText(path);
            Console.WriteLine(fileContent);
        }

        public static void PageNotAllowed()
        {
            PrintFileContent("/page-not-allowed.html");
        }
        #endregion
    }
}
