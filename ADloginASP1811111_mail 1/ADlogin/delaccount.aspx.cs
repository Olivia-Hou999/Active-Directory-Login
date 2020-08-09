using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ADHelper;
using DBHelper;
namespace ADlogin
{
    public partial class delaccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id_tmp = System.Web.HttpUtility.UrlEncode(Request.QueryString["id"], System.Text.UnicodeEncoding.UTF8);
                string id = id_tmp.Replace("%3d", "=");
               // string token = Request.QueryString["id"];
                //UserInfo_Normal user = OperData.QueryIdByToken(token);
                string de_id = EnDecrypt.Decrypt(id);
                if (OperData.DelAccount(de_id))
                {
                    Response.Write("<script language=javascript>alert('user had deleted  ！');window.location.href='login.aspx';</script>");

                }
                else
                {
                    Response.Write("<script language=javascript>alert('deleted user fail ！');</script>");
                }
                
            }
        }
    }
}