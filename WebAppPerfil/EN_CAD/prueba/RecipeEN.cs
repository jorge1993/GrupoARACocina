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
        private string type;
        private string imagen;
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

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
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

        public RecipeEN()
        {
            id = -1;
            name = "";
            time = 0;
            subtitle = "";
            description = "";
            video = "";
            origin = "";
            difficulty = "";
        }


        public bool INSERT()
        {
            RecipeCAD u = new RecipeCAD();
            if (u.addRecipe(this))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public RecipeEN READ()
        {
            RecipeEN receta = new RecipeEN();

            return receta;
        }

        /*public bool UPDATE()
        {
            RecipeCAD u = new RecipeCAD();
            if (u.updateRecipe(this, id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        public bool DELETE()
        {
            RecipeCAD u = new RecipeCAD();
            if (u.deleteRecipe(this))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public RecipeEN getRecipe(int id)
        {
            RecipeCAD recipe = new RecipeCAD();

            return recipe.getRecipe(id);
        }

        public List<CommentEN> CommentsPerRecipe(RecipeEN recipe)
        {
            RecipeCAD receta = new RecipeCAD();

            return receta.getComments(recipe);
        }

        public List<RecipeEN> getRecipes(string identificador)
        {
            RecipeCAD recipes = new RecipeCAD();

            return recipes.getRecipes(identificador, this);
        }

        public BookEN getBook()
        {
            RecipeCAD recipe = new RecipeCAD();
            return recipe.getBook(this);
        }

        /********************************/

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
