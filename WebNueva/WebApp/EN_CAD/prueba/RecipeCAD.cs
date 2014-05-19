using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Finisar.SQLite;

namespace prueba
{
    public class RecipeCAD
    {
        //private Database db;


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

        public List<CookwareEN> Cookware(RecipeEN recipe)
        {
            List<CookwareEN> utensilios = new List<CookwareEN>();

            return utensilios;
        }

        public List<IngredientEN> Ingredients(RecipeEN recipe)
        {
            List<IngredientEN> ingredientes = new List<IngredientEN>();

            return ingredientes;
        }

        public int Quantity(RecipeEN recipe, IngredientEN ingredient)
        {
            int cantidad = 0;

            return cantidad;
        }

        public List<CommentEN> Comments(RecipeEN recipe)
        {
            List<CommentEN> comentarios = new List<CommentEN>();

            return comentarios;
        }

        public int Puntuation(RecipeEN recipe)
        {
            int puntuacion = 0;

            return puntuacion;
        }
    }
}
