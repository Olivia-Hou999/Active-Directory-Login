using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.DirectoryServices;
using ADHelper;
using System.Data.SqlClient;
namespace ADlogin
{
    public partial class Active : System.Web.UI.Page
    {
        UserInfo_Normal user_Pub = new UserInfo_Normal();
        protected void Page_Load(object sender, EventArgs e)
        {
            //进行激活判断
            //修改密码
            //显示激活成功
            //用户登录
           
            if (!Page.IsPostBack)
            {
                lbl_info.Text = "至少包含一个大写字母，至少包含一个小写字母，至少包含一个数字，密码只能以字母开头，并且包含这些字母(!#@$%^&*)中的一个, 并且密码长度至少是8个";
                string id_tmp = System.Web.HttpUtility.UrlEncode(Request.QueryString["id"], System.Text.UnicodeEncoding.UTF8);
                string id = id_tmp.Replace("%3d", "=");

                //string token = Request.QueryString["id"];
                string de_id = EnDecrypt.Decrypt(id);
                hf_id.Value = id;
                if (de_id != "")
                {

                    user_Pub = QueryPwd(de_id);

                    string commonname = user_Pub.firstName;
                    string oldpwd = user_Pub.password;

                    lbl_username.Text = commonname;
                    lbl_oldpwd.Text = oldpwd;


                }
                else
                {
                    Response.Write("Invalid Link");
                    return;
                }

            }


        }

        protected void btn_changepwd_Click(object sender, EventArgs e)
        {
            

            if (txt_newpwd.Text == txt_confirmnewpwd.Text)
            {
                if (OperData.ChkPwdPower(txt_confirmnewpwd.Text.Trim()))
                {
                    string id = EnDecrypt.Decrypt(hf_id.Value);
                    if (OperData.changepwd(id, txt_newpwd.Text.Trim()))
                    {
                        Response.Write("<script language=javascript>alert('Password has been changed successfully！Your account has been activated !');window.location.href='login.aspx';</script>");
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('Password is not changed properly！');</script>");

                    }
                }
                else
                {
                    lbl_msg.Text = "Must start with letters; At least include one uppercase, one lowercase and one number; No fewer than eight characters long";
                }
            }
            else
            {
                lbl_msg.Text = "Password and confirm password don't match";

            }
        }



        private UserInfo_Normal QueryPwd(string id)
        {
            UserInfo_Normal user = new UserInfo_Normal();
            SqlDataReader reader = DBHelper.DBHelp.GetReader("select userId,firstName,emailAddress,registrationToken,tokenExpiredDatetime,activited,password from local_users where userId=@id",

                new SqlParameter("@id", id));
            while (reader.Read())
            {
                user.userId = reader.GetInt32(0);
                user.firstName = reader.GetString(1);
                user.emailAddress = reader.GetString(2);
                user.registrationToken = reader.GetString(3);
                user.tokenExpiredDatetime = reader.GetDateTime(4);
                string act = reader[5].ToString();
                if (act == "true")
                {
                    user.activited = 1;
                }
                else
                {
                    user.activited = 0;
                }
                user.password = reader.GetString(6);
            }
            reader.Close();
            return user;
        }

        protected void lb_exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginout.aspx");
        }
    }
}