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
 
        [ForeignKey(nameof(Recipe))]//Set up to link to a perticular Recipe(1 to 1) 
        public int IngredientListId { get; set; }//Same as IList in Recipe Class
        public virtual Recipe Recipe { get; set; }
        public virtual ICollection<Ingredient> ListOfIngredients { get; set; } //Many to Many relationship with ingredient

        public IngredientList()
        {
            ListOfIngredients = new HashSet<Ingredient>();
        }

    }//end of class ingredientList
}
