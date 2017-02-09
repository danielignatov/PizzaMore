namespace PizzaMore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        #region Fields
        private int id;
        private string email;
        private string password;
        private ICollection<Pizza> pizzaSuggestions;
        #endregion

        #region Constructors
        public User()
        {
            this.pizzaSuggestions = new HashSet<Pizza>();
        }
        #endregion

        #region Properties
        [Key]
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        [Required]
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        [Required]
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        public virtual ICollection<Pizza> PizzaSuggestions
        {
            get
            {
                return this.pizzaSuggestions;
            }
            set
            {
                this.pizzaSuggestions = value;
            }
        }
        #endregion
    }
}
