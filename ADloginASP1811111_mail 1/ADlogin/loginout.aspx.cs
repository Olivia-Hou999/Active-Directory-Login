using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADlogin
{
    public partial class loginout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            Session.Remove("username");
            Session.Remove("userguid");
            Session.RemoveAll();
            this.Page.RegisterStartupScript("", "<script>window.top.document.location.href='login.aspx';</script>");
        }
    }
}