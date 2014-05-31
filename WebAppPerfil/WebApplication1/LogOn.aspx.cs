using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using prueba;

namespace WebApplication1
{
    public partial class LogOn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        protected void sender_Click(object sender, EventArgs e)
        {

            try
            {
                UserEN user = new UserEN();

                user.Email = userBox.Text;
                user.Password = passBox.Text;

                if (user.ValidationUser())
                {
                    Session.Clear();
                    Session["login"] = userBox.Text;
                    Response.Redirect("LogOnOK.aspx");
                }

                else
                {
                    Control.Text = "The email and the password don't match";
                }

            }

            catch (Exception ex)
            {
                Control.Text = ex.Message;

            }
        }

    }
}
