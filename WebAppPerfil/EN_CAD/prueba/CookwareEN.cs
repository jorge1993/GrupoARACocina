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
        private string imagen;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public void INSERT()
        {
            CookwareCAD cook = new CookwareCAD();
            cook.addCookware(this);
        }

        public CookwareEN READ(CookwareEN cook)
        {
            CookwareCAD utensilio = new CookwareCAD();

            return utensilio.getCookware(cook.name, cook.material);
        }

        public List<CookwareEN> READCooksWares()
        {
            CookwareCAD lista = new CookwareCAD();
            return lista.getCookwares();
        }


        public void DELETE()
        {
            CookwareCAD cook = new CookwareCAD();
            cook.deleteCookware(this);
        }

    }
}
