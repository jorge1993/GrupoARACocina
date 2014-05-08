using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPrueba
{
    public class Utensils
    {
        private string name;
        private string material;
        private UtensilsCAD cad;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public void INSERT()
        {

        }

        public UtensilsEN READ(int cod)
        {
        }

        public void UPDATE()
        {

        }
        
        public void DELETE(int cod)
        {

        }

    }
}
