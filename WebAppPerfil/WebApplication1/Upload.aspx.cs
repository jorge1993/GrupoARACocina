using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using prueba;

namespace WebApplication1
{
    public partial class Formulario_web15 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login(object sender, EventArgs e)
        {
            Response.Redirect("LogOn.aspx");
        }

        protected void Register(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }


        protected void Upload_recipe(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                RecipeEN receta = new RecipeEN();
                UserEN usuario = new UserEN();

                //usuario.Password = (string)Session["login"];
                //usuario = usuario.Read();

                usuario.Email = Session["Login"].ToString();
                usuario = usuario.Read();

                

                receta.Name = Nombre.Text;
                receta.Subtitle = Subtitulo.Text;
                receta.Time = Int32.Parse(Tiempo.Text);
                receta.Description = Descripcion.Text;
                receta.Origin = Origen.Text;
                receta.Imagen = Foto.Text;
                receta.Video = Video.Text;
                receta.Imagen = Foto.Text;
                receta.User = usuario;

                string num = DropDownList1.SelectedIndex.ToString();

                if (num == "0")
                {
                    receta.Difficulty = "Easy";
                }

                else if (num == "1")
                {
                    receta.Difficulty = "Medium";
                }

                else if (num == "2")
                {
                    receta.Difficulty = "Hard";
                }

                else 
                {
                    receta.Difficulty = "Impossible";
                }


                string tipo = DropDownList2.SelectedIndex.ToString();

                if (tipo == "0")
                {
                    receta.Type = "Starter";
                }

                else if (tipo == "1")
                {
                    receta.Type = "First Plate";
                }

                else if (tipo == "2")
                {
                    receta.Type = "Second Plate";
                }

                else
                {
                    receta.Type = "Dessert";
                }


                //receta.User = usuario;

                if (receta.INSERT())
                {
                    //MensajeOK.Text = "The recipe was uploaded correctly";
                    Nombre.Text = "";
                    Subtitulo.Text = "";
                    Tiempo.Text = "";
                    Descripcion.Text = "";
                    Origen.Text = "";
                    Descripcion.Text = "";
                    Video.Text = "";

                    MensajeOK.Text = "The recipe is uploaded! Thank You!";
                }

                else
                {
                    MensajeOK.Text = "The recipe can not be uploaded";
                }

            }

            else
            {
                MensajeOK.Text = "You have to be a registered user to upload a recipe!";
            }

        }
    }
}