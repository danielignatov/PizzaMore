using PizzaMore.Utility.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMore.Utility.Models
{
    public class Header
    {
        #region Constructor
        public Header()
        {
            this.Type = "Content-type: text/html";
            this.Cookies = new CookieCollection();
        }
        #endregion
        
        #region Properties
        public string Type { get; set; }

        public string Location { get; set; }

        public CookieCollection Cookies { get; set; }
        #endregion

        #region Methods
        public void AddLocation(string location)
        {
            this.Location = $"Location: {location}";
        }

        public void AddCookie(Cookie cookie)
        {
            this.Cookies.AddCookie(cookie);
        }

        public override string ToString()
        {
            StringBuilder header = new StringBuilder();
            header.AppendLine(this.Type);

            if (this.Cookies.Count > 0)
            {
                foreach (var cookie in this.Cookies)
                {
                    header.AppendLine($"Set-Cookie: {cookie.ToString()}");
                }
            }

            if (this.Location != null)
            {
                header.AppendLine(this.Location);
            }

            header.AppendLine();
            header.AppendLine();

            return header.ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        #endregion
    }
}
