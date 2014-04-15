using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrueba
{
    public class Books
    {
        private string title;
        private string author;
        private long isbn;
        private int price;
        private int publication_date;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public long Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
       
    
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
      

        public int Publication_date
        {
            get { return publication_date; }
            set { publication_date = value; }
        }

    }
}