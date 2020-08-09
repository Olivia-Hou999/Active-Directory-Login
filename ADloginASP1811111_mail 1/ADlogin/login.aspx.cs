using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.DirectoryServices;
using ADHelper;
using DBHelper;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace ADlogin
{
    public partial class login : System.Web.UI.Page
    {
        private string m_username="";
        private string m_domain="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookies = Request.Cookies["USER_COOKIE"];
                if (cookies != null)
                {
                    //txt_Domain.Text = cookies["myDomain"];
                   // inp_username.Value = cookies["UserName"];
                  
                    inp_username.Value = cookies["UserEmail"];
                    //inp_username.Value = cookies["UserName"];
                   pwd.Value = cookies["UserPassword"];
                    this.chk_remember.Checked = true;
                }
              
            }
          
            
        }

        /// <summary>
        /// 普通用户登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Login_Click(object sender, EventArgs e)
        {

            if (pwd.Value.Trim() != "" && inp_username.Value.Trim() != "") //用户邮箱和密码
            {
                if (OperData.loginedByEmail(inp_username.Value.Trim(), pwd.Value.Trim()))
                {
                    //Response.Write("<script language=javascript>window.location.href='login.aspx';</script>");
                    Crystal_clear_logs log = new Crystal_clear_logs();
                    //   log.userId=OperData.QueryInfoByfirstname(inp_username.Value.Trim());
                    log.userId = inp_username.Value.Trim();
                    log.action = "login";
                    log.actionDatetime = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));


                    log.actionDetails = "login in system";



                    // Session["userguid"] = OperData.QueryUserIDByfirstname(inp_username.Value.Trim());//
                    Session["userguid"] = OperData.QueryUserIDBymail(inp_username.Value.Trim());//通过用户邮箱查询id
                    //Session["username"] = inp_username.Value.Trim();
                    Session["UserEmail"] = inp_username.Value.Trim();
                    m_username = OperData.QueryUserNameBymail(inp_username.Value.Trim());
                    Session["username"] = m_username;
                    if (OperData.insertLog(log))


                        //     Response.Redirect("userweb.aspx?usname=" + m_username);
                        Response.Redirect("LoginedNUser.aspx?usname=" + m_username + "&userstyle=0");
                }
                else
                {
                    lbl_msg.Text = "User acount or password is invlaid!";
                }
            }



            //以下用于第二次登录时，记住用户上次登录时的域名
            HttpCookie cookie = new HttpCookie("USER_COOKIE");
            if (chk_remember.Checked)
            {
                cookie.Values.Add("UserEmail", this.inp_username.Value.Trim());
                cookie.Values.Add("UserName", m_username);
                cookie.Values.Add("UserPassword", this.pwd.Value.Trim());
                //cookie.Values.Add("myDomain", this.txt_Domain.Text.Trim());
                cookie.Expires = System.DateTime.Now.AddDays(7.0); 
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
            else
            {
                if (cookie != null)
                {
                    Response.Cookies["USER_COOKIE"].Expires = DateTime.Now;
                }
            }

         
        }


        //雇员登录  ：这里就不用了。单独跳转到lgoinem.aspx进行登录
        protected void btn_EmployeeLogin_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //AD 域用户登录

            //    m_username = inp_username.Value;
            //    string FilterStr;//               
            //    DirectoryEntry entry = new DirectoryEntry("LDAP://" + this.txt_Domain.Text, m_username, this.pwd.Value);
              
            //    DirectorySearcher Seacher = new DirectorySearcher(entry);
            //    FilterStr = "(&(objectClass=user) (cn=" + m_username + "))";
            //    Seacher.Filter = FilterStr;
            //    SearchResult Result = Seacher.FindOne();
            //    UserInfo us = new UserInfo();

            //    StringBuilder strtemp = new StringBuilder();
            //    if (Result == null)
            //    {
            //        Response.Write("<script language=javascript>alert('username or password error！if you'r a new user ,please click Login！');</script>");
                   
            //    }
            //    else
            //    {


            //        foreach (string userkey in Result.Properties.PropertyNames)
            //        {
            //            foreach (object obj in Result.Properties[userkey])
            //            {
            //                strtemp.Append(userkey + ":" + obj.ToString() + "\r\n");
            //                switch (userkey)
            //                {
            //                    case "objectsid":
            //                        byte[] guid = ObjToByte(obj);
            //                        us.objectguid = Convert.ToBase64String(guid);
            //                        break;
            //                    case "name": us.name = obj.ToString(); break;
            //                    case "mail": us.mail = obj.ToString(); break;
            //                    case "telephonenumber": us.telephonenumber = obj.ToString(); break;
            //                    default: break;
            //                }
            //            }



            //        }

                   
            //        entry.AuthenticationType = AuthenticationTypes.Secure;
                  


            //        Crystal_clear_logs log = new Crystal_clear_logs();
            //       // log.userId = us.objectguid;


            //        log.userId = us.name;//新加userID记录username
            //        log.action = "login";
            //        log.actionDatetime = DateTime.Now;
            //        log.actionDatetime.ToString("MM/dd/yyyy hh:mm:ss");
            //        log.actionDetails = "login in system";



            //        if (OperData.insertLog(log))
            //        {
            //            Session["userguid"] = us.objectguid.Trim();
            //            Session["username"] = us.name.Trim();//存储用户编号

            //            HttpCookie cookie = new HttpCookie("USER_COOKIE");
            //            if (chk_remember.Checked)
            //            {
            //                cookie.Values.Add("UserName", this.inp_username.Value.Trim());
            //                cookie.Values.Add("UserPassword", this.pwd.Value.Trim());
            //                cookie.Values.Add("myDomain", this.txt_Domain.Text.Trim());
            //                cookie.Expires = System.DateTime.Now.AddDays(7.0);
            //                HttpContext.Current.Response.Cookies.Add(cookie);
            //            }
            //            else
            //            {
            //                if (cookie != null)
            //                {
            //                    Response.Cookies["USER_COOKIE"].Expires = DateTime.Now;
            //                }
            //            }


            //            Response.Redirect("register.aspx?usname=" + us.name + "&usmail=" + us.mail + "&usphone=" + us.telephonenumber);
            //        }
            //        else
            //        {
            //            Response.Write("<script language=javascript>alert('AD login fail！');</script>");
            //        }




            //    }

          

            //    //if (inp_username.Value != "")
            //    //{
            //    //    string userguid = "14545545";
            //    //    string sql_insert_log = "insert into crystal_clear_logs (userId,action,actionDetails,actionDatetime) values('" + userguid + "','" + "login','" + "login in system','" + DateTime.Now + "')";
            //    //    int res = DBHelp.ExecuteCommand(sql_insert_log);
            //    //    if (res > 0)
            //    //    {
            //    //        Session["username"] = inp_username.Value.Trim();//存储用户编号
            //    //        Response.Redirect("register.aspx?usname=" + inp_username.Value + "&usmail=" + "text@mail.com" + "&usphone=" + "13577889988");
            //    //    }
            //    //    else
            //    //    {
            //    //        Response.Write("<script language=javascript>alert('Insert log fail！');</script>");
            //    //    }
            //    //}


                
            //}
            //catch (Exception ex)
            //{
            //    string Str = ex.Message;
              
            //}  
        
        }


    
        /// <summary>
        /// 对象转字节
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] ObjToByte(object obj)
        {
            byte[] buff;
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter ifor = new BinaryFormatter();
                ifor.Serialize(ms, obj);
                buff = ms.GetBuffer();
            }
            return buff;
        }





       
    }
}