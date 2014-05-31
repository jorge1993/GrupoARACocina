using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba
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
            IngredientCAD ing = new IngredientCAD();
            ing.InsertIngredient(this);
        }

        // Deletes the ingredient that is passed by parameter
        public void DeleteIngredient()
        {
            IngredientCAD ing = new IngredientCAD();
            ing.DeleteIngredient(this);
        }

        // Modify the description of an ingredient
        public void ModifyDescription(string description)
        {
            IngredientCAD ing = new IngredientCAD();
            ing.ModifyDescription(this, description);
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
