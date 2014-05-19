using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba
{
    public class CookwareEN
    {
        private string name;
        private string material;
        private CookwareCAD cad;

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

        public CookwareEN READ(int cod)
        {
            CookwareEN utensilio = new CookwareEN();

            return utensilio;
        }

        public void UPDATE()
        {

        }

        public void DELETE(int cod)
        {

        }

    }
}
