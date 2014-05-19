using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace prueba
{
    public class IngredientCAD
    {
        public IngredientCAD()
        {
        }


        // Insert into the database a new ingredient (It's necessary that its fields are not null)
        public void InsertIngredient(IngredientEN ing)
        {
        }

        // Deletes the ingredient from the database that is passed by parameter
        public void DeleteIngredient(IngredientEN ing)
        {
        }

        // Returns a list with the recipes that use this ingredient
        public List<RecipeEN> ListRecipes(IngredientEN ing)
        {
            List<RecipeEN> recetas = new List<RecipeEN>();

            return recetas;
        }

        // Modify the description of an ingredient
        public void ModifyDescription(IngredientEN ing, string description)
        {
        }

        /***********/
        /** DATOS **/
        /***********/

        //private Database db;
        private IngredientEN ingredient;
        private List<IngredientEN> ingredients;

    }
}