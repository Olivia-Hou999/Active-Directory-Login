using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADlogin
{
    public partial class LoginedUser : System.Web.UI.Page
    {
        string userstyle = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                if (Session["username"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                userstyle = Request.QueryString["userstyle"];
                if (userstyle == "1")
                {
                    employeeuser.Attributes["style"] = "display:inline-block";
                }
                else
                {
                    normaluser.Attributes["style"] = "display:inline-block";
                    
                }


                lbl_username.Text = Request.QueryString["usname"];
                lg_username.Text = Request.QueryString["usname"];
                lg_usermail.Text = Request.QueryString["usmail"];
                lbl_telephone.Text = Request.QueryString["usphone"];



                
            }
        }

        protected void lb_exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginout.aspx");
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateNewUser.aspx");//带参数
        }
    }
}