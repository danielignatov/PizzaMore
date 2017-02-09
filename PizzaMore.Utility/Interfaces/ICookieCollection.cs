namespace PizzaMore.Utility.Interfaces
{
    using PizzaMore.Utility.Models;

    public interface ICookieCollection
    {
        void AddCookie(Cookie cookie);

        void RemoveCookie(string cookieName);

        bool ContainsKey(string key);

        int Count
        {
            get;
        }

        Cookie this[string key]
        {
            get; set;
        }
    }
}