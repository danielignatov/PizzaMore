namespace PizzaMore.Utility.Models
{
    using System.Collections.Generic;
    using PizzaMore.Utility.Interfaces;

    public class CookieCollection : ICookieCollection
    {
        #region Fields
        private Dictionary<string, Cookie> cookies;
        #endregion

        #region Constructors
        public CookieCollection()
        {
            this.cookies = new Dictionary<string, Cookie>();
        }
        #endregion

        #region Properties
        public Cookie this[string key]
        {
            get
            {
                return this.cookies[key];
            }

            set
            {
                this.cookies[key] = value;
            }
        }

        public int Count
        {
            get
            {
                return this.cookies.Count;
            }
        }
        #endregion

        #region Methods
        public void AddCookie(Cookie cookie)
        {
            this.cookies.Add(cookie.CookieName, cookie);
        }

        public bool ContainsKey(string key)
        {
            if (this.cookies.ContainsKey(key))
            {
                return true;
            }

            return false;
        }

        public void RemoveCookie(string cookieName)
        {
            this.cookies.Remove(cookieName);
        }
        #endregion
    }
}