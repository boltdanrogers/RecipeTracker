using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTracker.Data
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters")]
        [MaxLength(100, ErrorMessage = "Too many characters")]
        public string RecipeName { get; set; }

        public virtual IngredientList IList { get; set; } //One to One linking IngredientListId 

    }//end of class recipe
}
