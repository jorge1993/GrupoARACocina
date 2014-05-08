using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrueba
{
    public class IngredientCAD
    {
    	public IngredientCAD()
    	{
    	}


    	// Insert into the database a new ingredient (It's necessary that its fields are not null)
    	public void InsertIngredient(Ingredient ing)
    	{
    	}

    	// Deletes the ingredient from the database that is passed by parameter
        public void DeleteIngredient(Ingredient ing)
        {
        }

        // Returns a list with the recipes that use this ingredient
        public List<Recipe> ListRecipes(Ingredient ing)
        {
        }

        // Modify the description of an ingredient
        public void ModifyDescription(Ingredient ing, string description)
        {
        }

		/***********/
        /** DATOS **/
        /***********/

        private Database db;
        private IngredientEN ingredient;
        private ArrayList<IngredientEN> ingredients;

    }
}