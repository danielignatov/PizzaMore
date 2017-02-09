namespace PizzaMore.Utility.Models
{
    public class Cookie
    {
        #region Fields
        private string cookieName;
        private string cookieValue;
        #endregion

        #region Constructors
        public Cookie()
        {
            this.CookieName = null;
            this.cookieValue = null;
        }

        public Cookie(string name, string value)
        {
            this.CookieName = name;
            this.CookieValue = value;
        }
        #endregion

        #region Properties
        public string CookieName
        {
            get
            {
                return this.cookieName;
            }
            set
            {
                this.cookieName = value;
            }
        }

        public string CookieValue
        {
            get
            {
                return this.cookieValue;
            }
            set
            {
                this.cookieValue = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{this.cookieName}={this.cookieValue}";
        }
        #endregion
    }
}