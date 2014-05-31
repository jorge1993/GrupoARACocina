using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using prueba;

namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sender_Click(object sender, EventArgs e)
        {
            try
            {
                UserEN usuario = new UserEN();

                usuario.Email = email.Text;

                if (usuario.CheckEmail())
                {
                    Label1.Text = "This email is already in use!";
                }



                else
                {
                    usuario.Nick = userBox.Text;
                    usuario.Password = passBox.Text;
                    usuario.Email = email.Text;
                    usuario.Name = name.Text;
                    usuario.Surname = surname.Text;
                    usuario.Country = country.Text;

                    if(age.Text != "")
                        usuario.Age = Int32.Parse(age.Text);

                    if (usuario.InsertUser())
                    {
                        Session["login"] = usuario.Email;
                        Response.Redirect("RegisterOK.aspx");
                    }

                    else
                    {
                        Label1.Text = "A problem has ocurred during the creation of the user";
                    }

                }

            }

            catch (Exception ex)
            {
                

            }
        }
    }
}