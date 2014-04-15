using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrueba
{
    public class Comments
    {
        DateTime date;
        string description;

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


    }
}