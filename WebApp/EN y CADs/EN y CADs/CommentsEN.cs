using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrueba
{
    public class Comments
    {
        private DateTime date;
        private string description;
        private CommentsCAD cad;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public void INSERT()
        {

        }

        public void READ(int cod)
        {
        }

        public void UPDATE()
        {

        }
        
        public void DELETE()
        {

        }

    }
}
