using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADlogin
{
    public partial class Masterpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lb_exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginout.aspx");
        }
        //public bool SetMenuHidden
        //{
        //    get { return menu_1.Attributes["style"]; }
        //    set { menu_1.Attributes["style"] = value; }
        //}
    }
}