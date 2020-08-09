using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ADHelper;
namespace ADlogin
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["username"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                lg_username.Text = Request.QueryString["usname"];
                lg_usermail.Text = Request.QueryString["usmail"];
                lbl_telephone.Text = Request.QueryString["usphone"];
            }
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {

            Response.Redirect("NewUser.aspx");//带参数

           
        }

        protected void lb_exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginout.aspx");
        }
    }
}