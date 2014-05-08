using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrueba
{
    public class Recipe
    {
        private long id;
        private string name;
        private int time;
        private string subtitle;
        private string description;
        private string video;
        private string origin;
        private string difficulty;
        private User user;
        private BooksEN book;
        private Utensilis utensilis;
        private List<Ingredients> ingredients;
        private List<Comments> comments;
        private List<User> puntuations;

        private RecipeCAD cad;


        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public BooksEn Books
        {
            get { return book; }
            set { book = value; }
        }

        public Utensilis Utensilis
        {
            get { return utensilis; }
            set { utensilis = value; }
        }

        public List<Ingredients> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public List<Comments> Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public List<User> Puntuations
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
        }

        public void UPDATE()
        {

        }
        
        public void DELETE()
        {

        }

        public List<Utensils> Utensils()
        {

        }

        public List<Ingredient> Ingredients()
        {

        }

        public int Quantity(Ingredient ingredient)
        {
            
        }

        public List<Comments> Comments()
        {

        }

        public int Puntuation()
        {

        }

    }
}
