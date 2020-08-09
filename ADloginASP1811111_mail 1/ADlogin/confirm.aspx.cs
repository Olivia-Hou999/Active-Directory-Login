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
    public partial class confirm : System.Web.UI.Page
    {
        UserInfo_Normal user_nom = new UserInfo_Normal();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                string token = Request.QueryString["token"];
                string id_tmp = System.Web.HttpUtility.UrlEncode(Request.QueryString["id"],System.Text.UnicodeEncoding.UTF8);
                string id = id_tmp.Replace("%3d", "=");
                if (token != "" && id!="")
                {
                    string de_id = EnDecrypt.Decrypt(id);
                    //user_nom = OperData.QueryIdByToken(token);
                    user_nom = OperData.QueryInfoByID(de_id);
                    if (user_nom != null)
                    {
                        string first = user_nom.firstName;
                        DateTime tokenExpiredDatetime = user_nom.tokenExpiredDatetime;//有效期
                       
                        string code = user_nom.registrationToken;//激活码
                        int flag = user_nom.activited;//激活状态

                        DateTime curtime = DateTime.Now;

                      

                        if (flag == 0 && curtime < tokenExpiredDatetime)
                        {

                            if (OperData.UpdateActiveByID(de_id))
                            {
                                //这就是打断点的方法
                                Response.Write("<script language=javascript>alert('Your account has been activated successfully！');window.location.href='active.aspx?id=" + id + "';</script>");
                            }
                            else
                            {
                                Response.Write("<script language=javascript>alert('Failed to activate！');window.location.href='login.aspx';</script>");
                            }
                        }
                        else
                        {
                            if (flag == 1)
                            {
                                Response.Write("<script language=javascript>alert('Account has been activated！');window.location.href='active.aspx?id=" + id + "';</script>");
                                return;
                            }

                            if (flag == 0 && curtime > tokenExpiredDatetime)
                            {
                                Response.Write("<script language=javascript>alert('Code expired, activate fail！');window.location.href='delaccount.aspx?id=" + id + "';</script>");
                                return;
                            }
                            else
                            {
                                Response.Write("<script language=javascript>alert('Error Link！');window.location.href='login.aspx';</script>");
                            }

                        }
                        
                    }
                }
            }
        }

        protected void btn_active_Click(object sender, EventArgs e)
        {
            if (txt_regcode.Text != "" || txt_regcode.Text != null)
            {
                Response.Write("");
            }
            else
            {
                string token = txt_regcode.Text.Trim();
                if (token != "")
                {
                    user_nom = OperData.QueryIdByToken(token);
                    string first = user_nom.firstName;
                    DateTime tokenExpiredDatetime = user_nom.tokenExpiredDatetime;//有效期
                    string code = user_nom.registrationToken;//激活码
                    int flag = user_nom.activited;//激活状态

                    DateTime curtime = DateTime.Now;
                    if (code == token && flag == 0 && curtime < tokenExpiredDatetime)
                    {

                        if (OperData.UpdateActive(token))
                        {
                            Response.Write("<script language=javascript>alert('Your account has been activated successfully！');window.location.href='active.aspx?token=" + token + "';</script>");
                        }
                        else
                        {
                            Response.Write("<script language=javascript>alert('Failed to activate！');window.location.href='login.aspx';</script>");
                        }
                    }
                    else
                    {
                        if (code == token && flag == 1)
                        {
                            Response.Write("<script language=javascript>alert('Your account has been activated successfully！');window.location.href='active.aspx?token=" + token + "';</script>");
                            return;
                        }

                        if (code == token && flag == 0 && curtime > tokenExpiredDatetime)
                        {
                            Response.Write("<script language=javascript>alert('Code expired, failed to activate！');window.location.href='login.aspx" + token + "';</script>");
                            return;
                        }
                        else
                        {
                            Response.Write("<script language=javascript>alert('Error Link！');window.location.href='login.aspx';</script>");
                        }

                    }
                }

              
            }
        }
    }
}