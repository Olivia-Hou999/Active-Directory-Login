using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADlogin
{
    public partial class UserWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string username = Request.QueryString["usname"];


                lbl_username.Text = username;



            }
        }

        protected void lb_exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginout.aspx");
        }
    }
}