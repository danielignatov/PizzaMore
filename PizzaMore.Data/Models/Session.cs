namespace PizzaMore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Session
    {
        #region Constructor
        public Session()
        {

        }
        #endregion

        #region Properties
        [Key]
        public string Id { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{this.Id}\t{this.User.Id}";
        }
        #endregion
    }
}