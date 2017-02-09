namespace PizzaMore.Utility.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using PizzaMore.Utility.Interfaces;

    public class CookieCollection : ICookieCollection
    {
        #region Fields
        private IDictionary<string, Cookie> cookies;
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
                if (this.cookies.ContainsKey(key))
                {
                    this.cookies[key] = value;
                }
                else
                {
                    this.cookies.Add(key, value);
                }
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

        public IEnumerator<Cookie> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void RemoveCookie(string cookieName)
        {
            this.cookies.Remove(cookieName);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}