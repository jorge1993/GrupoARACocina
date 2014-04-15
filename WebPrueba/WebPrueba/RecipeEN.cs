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