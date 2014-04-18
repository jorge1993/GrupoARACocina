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
        private Dictionary<Ingredients, int> ingredients;
        private Dictionary<Comments, User> comments;
        private Dictionary<User, int> puntuations;


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

        public Dictionary<Ingredients, int> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public Dictionary<Comments, User> Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public Dictionary<User, int> Puntuations
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



    }
}
