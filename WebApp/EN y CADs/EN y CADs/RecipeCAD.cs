using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;

namespace WebPrueba
{
    public class RecipeCAD
    {
        private Database db;


        public RecipeCAD()
        {

        }

        public void INSERT(RecipeEN e)
        {

        }

        public RecipeEN READ(long cod)
        {
            return (null);
        }

        public void UPDATE(RecipeEN update)
        {

        }
        
        public void DELETE(long cod)
        {

        }

        public List<Utensils> Utensils(RecipeEN recipe)
        {

        }

        public List<Ingredient> Ingredients(RecipeEn recipe)
        {

        }

        public int Quantity(RecipeEn recipe, Ingredient ingredient)
        {
            
        }

        public List<Comments> Comments(RecipeEN recipe)
        {

        }

        public int Puntuation(RecipeEN recipe)
        {

        }
    }
}
