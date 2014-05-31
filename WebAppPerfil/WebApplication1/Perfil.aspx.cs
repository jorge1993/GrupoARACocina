using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using prueba;

namespace WebApplication1
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserEN usuario = new UserEN();

            usuario.Email = Session["Login"].ToString();
            usuario = usuario.Read();

            Email.Text = Session["login"].ToString();
            Nombre.Text = usuario.Name;
            Apellidos.Text = usuario.Surname;
            Pais.Text = usuario.Country;
            Age.Text = usuario.Age.ToString();
            Nickname.Text = usuario.Nick;
            Contraseña.Text = usuario.Password;

        }

        protected void Edit_Profile(object sender, EventArgs e)
        {

        }
    }
}