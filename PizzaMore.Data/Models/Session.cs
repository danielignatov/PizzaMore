namespace PizzaMore.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Session
    {
        #region Constructor
        public Session()
        {

        }
        #endregion

        #region Properties
        [Key]
        public int Id { get; set; }

        public User User { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{this.Id}\t{this.User.Id}";
        }
        #endregion
    }
}