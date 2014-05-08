using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrueba
{
    public class IngredientEN
    {
      
        // Constructor without parameterss
        public IngredientEN()
        {
            name = "";
            description = "";
        }

        // Constructor with the name and the description of a new ingredient
        public IngredientEN(string n, string d)
        {
            name = n;
            description = d;
        }

        // It inserts a new ingredient
        public void InsertIngredient()
        {
        }

        // Deletes the ingredient that is passed by parameter
        public void DeleteIngredient()
        {
        }

        // Returns a list with the recipes that use this ingredient
        public List<Recipe> ListRecipes()
        {
        }

        // Modify the description of an ingredient
        public void ModifyDescription()
        {
        }
 
        // Getter/Setter of name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        // Getter/Setter of description
        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        /***********/
        /** DATOS **/
        /***********/
        private string name;
        private string description;

        private IngredientCAD ingCAD;

    }
}
