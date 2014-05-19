using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba
{
    public class RecipeEN
    {
        private long id;
        private string name;
        private int time;
        private string subtitle;
        private string description;
        private string video;
        private string origin;
        private string difficulty;
        private UserEN user;
        private BookEN book;
        private CookwareEN cookware;
        private List<IngredientEN> ingredients;
        private List<CommentEN> comments;
        private List<UserEN> puntuations;

        private RecipeCAD cad;


        public UserEN User
        {
            get { return user; }
            set { user = value; }
        }

        public BookEN Book
        {
            get { return book; }
            set { book = value; }
        }

        public CookwareEN Cookware
        {
            get { return cookware; }
            set { cookware = value; }
        }

        public List<IngredientEN> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public List<CommentEN> Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public List<UserEN> Puntuations
        {
            get { return puntuations; }
            set { puntuations = value; }
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int Time
        {
            get { return time; }
            set { time = value; }
        }


        public string Subtitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }


        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Video
        {
            get { return video; }
            set { video = value; }
        }



        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }




        public void INSERT()
        {

        }

        public RecipeEN READ()
        {
            RecipeEN receta = new RecipeEN();

            return receta;
        }

        public void UPDATE()
        {

        }

        public void DELETE()
        {

        }

        public List<CookwareEN> CookwarePerRecipe()
        {
            List<CookwareEN> utensilios = new List<CookwareEN>();

            return utensilios;
        }

        public List<IngredientEN> IngredientsPerRecipe()
        {
            List<IngredientEN> ingredientes = new List<IngredientEN>();

            return ingredientes;

        }

        public int Quantity(IngredientEN ingredient)
        {
            int cantidad = 0;

            return cantidad;
        }

        public List<CommentEN> CommentsPerRecipe()
        {
            List<CommentEN> comentarios = new List<CommentEN>();

            return comentarios;
        }

        public int Puntuation()
        {
            int puntuacion = 0;

            return puntuacion;
        }

    }
}
