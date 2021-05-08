using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTracker.Data
{
    public class IngredientList
    {
        [Key]
        public int IngredientListId { get; set; }

        [ForeignKey (nameof(Ingredient))]
        public string IngredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; }



    }//end of class ingredientList
}
