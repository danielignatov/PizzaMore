namespace PizzaMore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Pizza
    {
        #region Constructor
        public Pizza()
        {

        }
        #endregion

        #region Properties
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Recipe { get; set; }

        public string ImageUrl { get; set; }

        public int UpVotes { get; set; }

        public int DownVotes { get; set; }

        public int RecipeOwnerId { get; set; }

        public virtual User RecipeOwner { get; set; }
        #endregion
    }
}
