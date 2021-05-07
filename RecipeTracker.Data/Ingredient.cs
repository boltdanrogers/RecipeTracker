using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTracker.Data
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters")]
        [MaxLength(100, ErrorMessage = "Too many characters")]
        public string IngredientName { get; set; }
        [Required]
        [Range(0, Double.PositiveInfinity)]
        public Double Quantity { get; set; }
        [Required]
        [MinLength(1, ErrorMessage = "Please enter at least 1 characters")]
        [MaxLength(100, ErrorMessage = "Too many characters")]
        public string Unit { get; set; }

    }//end of class Ingredient
}
