using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LogOnOK : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = Session["Login"].ToString();
            }
            catch (Exception excep)
            {
                Label1.Text = "Please Register first.";
            }
        }
    }
}