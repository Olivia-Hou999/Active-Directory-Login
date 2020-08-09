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
    public partial class loginem : System.Web.UI.Page
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
                    myDomain.Value = cookies["myDomain"];
                    this.chk_remember.Checked = true;
                }

            }
          
            
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {



            Response.Redirect("login.aspx");

            //if (txt_password.Text.Trim() != "" && txt_username.Text.Trim() != "")
            //{
            //    if(OperData.logined(txt_username.Text.Trim(),txt_password.Text.Trim()))
            //    {
            //        //Response.Write("<script language=javascript>window.location.href='login.aspx';</script>");
            //        Crystal_clear_logs log=new Crystal_clear_logs();
            //     //   log.userId=OperData.QueryInfoByfirstname(txt_username.Text.Trim());
            //        log.userId = txt_username.Text.Trim();
            //        log.action = "login";
            //        log.actionDatetime = DateTime.Now;
            //        log.actionDatetime.ToString("MM/dd/yyyy hh:mm:ss");
            //        log.actionDetails = "login in system";



            //        if(OperData.insertLog(log))
            //        Response.Redirect("userweb.aspx?usname="+txt_username.Text);
            //    }
            //}



            ////以下用于第二次登录时，记住用户上次登录时的域名
            //HttpCookie cookie = new HttpCookie("USER_COOKIE");
            //if (chk_remember.Checked)
            //{
            //    cookie.Values.Add("UserName", this.txt_username.Text.Trim());
            //    cookie.Values.Add("UserPassword", this.txt_password.Text.Trim());
            //    cookie.Values.Add("myDomain", this.myDomain.Value.Trim());
            //    cookie.Expires = System.DateTime.Now.AddDays(7.0); 
            //    HttpContext.Current.Response.Cookies.Add(cookie);
            //}
            //else
            //{
            //    if (cookie != null)
            //    {
            //        Response.Cookies["USER_COOKIE"].Expires = DateTime.Now;
            //    }
            //}

         
        }

        //雇员登录
        protected void btn_EmployeeLogin_Click(object sender, EventArgs e)
        {

            //Response.Redirect("CurrentUser.aspx?userstyle=1&usname=" + inp_username.Value + "&usmail=lanhai@163.com&usphone=135728744444");

            
            try
            {
                #region
                //AD 域用户登录
                string mydomain = myDomain.Value;
                m_username = inp_username.Value;
                string FilterStr;//               
                DirectoryEntry entry = new DirectoryEntry("LDAP://" + "kerrylogistics.com", m_username, this.pwd.Value);

                DirectorySearcher Seacher = new DirectorySearcher(entry);
                FilterStr = "(&(objectClass=user) (sAMAccountName=" + m_username + "))";
                Seacher.Filter = FilterStr;
                SearchResult Result = Seacher.FindOne();
                UserInfo us = new UserInfo();

                StringBuilder strtemp = new StringBuilder();
                if (Result == null)
                {
                    Response.Write("<script language=javascript>alert('username or password error！if you'r a new user ,please click Login！');</script>");

                }
                else
                {


                    foreach (string userkey in Result.Properties.PropertyNames)
                    {
                        foreach (object obj in Result.Properties[userkey])
                        {
                            strtemp.Append(userkey + ":" + obj.ToString() + "\r\n");
                            switch (userkey)
                            {
                                case "objectsid":
                                    byte[] guid = ObjToByte(obj);
                                    us.objectguid = Convert.ToBase64String(guid);
                                    break;
                                case "samaccountname": us.name = obj.ToString(); break;
                                case "mail": us.mail = obj.ToString(); break;
                                case "telephonenumber": us.telephonenumber = obj.ToString(); break;
                                default: break;
                            }
                        }



                    }


                    entry.AuthenticationType = AuthenticationTypes.Secure;



                    Crystal_clear_logs log = new Crystal_clear_logs();
                    // log.userId = us.objectguid;


                    log.userId = us.name;//新加userID记录username
                    log.action = "login";
                    log.actionDatetime = DateTime.Now;
                    //log.actionDatetime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
                    log.actionDetails = "login in system";



                    if (OperData.insertLog(log))
                    {
                        Session["userguid"] = us.objectguid.Trim();
                        Session["username"] = us.name.Trim();//存储用户编号

                        HttpCookie cookie = new HttpCookie("USER_COOKIE");
                        if (chk_remember.Checked)
                        {
                            cookie.Values.Add("UserName", this.inp_username.Value.Trim());
                            cookie.Values.Add("UserPassword", this.pwd.Value.Trim());
                            cookie.Values.Add("myDomain", this.myDomain.Value.Trim());
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


                        // Response.Redirect("register.aspx?usname=" + us.name + "&usmail=" + us.mail + "&usphone=" + us.telephonenumber);
                        //  Response.Redirect("LoginedUser.aspx?userstyle=1&usname=" + us.name + "&usmail=" + us.mail + "&usphone=" + us.telephonenumber);
                        Response.Redirect("CurrentUser.aspx?userstyle=1&usname=" + us.name + "&usmail=" + us.mail + "&usphone=" + us.telephonenumber);
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('AD login fail！');</script>");
                    }




                }
                #endregion


                //模拟用户登录

                //if (txt_username.Text != "")
                //{
                //    string userguid = "14545545";
                //    string sql_insert_log = "insert into crystal_clear_logs (userId,action,actionDetails,actionDatetime) values('" + userguid + "','" + "login','" + "login in system','" + DateTime.Now + "')";
                //    int res = DBHelp.ExecuteCommand(sql_insert_log);
                //    if (res > 0)
                //    {
                //        Session["username"] = txt_username.Text.Trim();//存储用户编号
                //        Response.Redirect("register.aspx?usname=" + txt_username.Text + "&usmail=" + "text@mail.com" + "&usphone=" + "13577889988");
                //    }
                //    else
                //    {
                //        Response.Write("<script language=javascript>alert('Insert log fail！');</script>");
                //    }
                //}



            }
            catch (Exception ex)
            {
                string Str = ex.Message;

                lbl_msg.Text = Str;
            }
           
        }


    

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