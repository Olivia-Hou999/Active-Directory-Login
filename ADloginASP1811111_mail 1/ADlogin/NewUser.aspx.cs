using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Net;
using System.Net.Mail;
using ADHelper;
using System.DirectoryServices;
using System.Text;
using System.Data;
using System.Data.SqlClient;
//using System.Net.Mail;
using DBHelper;

namespace ADlogin
{
    public partial class NewUser : System.Web.UI.Page
    {

        UserInfo_Normal user_norm = new UserInfo_Normal();
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (!Page.IsPostBack)
            //{
            //    if (Session["username"] == null)
            //    {
            //        Response.Redirect("Login.aspx");
            //    }

            //}
        }




        protected void btn_creat_Click(object sender, EventArgs e)
        {
         //   string msg=lbl_msg.Text.Trim();
         //switch(msg)
         //{
         //    case "":

         //    default:

            if (isUser() == true)
            {
                user_norm.firstName = txt_firstName.Text.Trim();
                user_norm.surName = txt_surName.Text.Trim();
                user_norm.password = "123456";//txt_password.Text.Trim();
                user_norm.emailAddress = txt_usermail.Text.Trim();
                user_norm.companyCode = txt_companyCode.Text.Trim();
                user_norm.position = txt_position.Text.Trim();
                user_norm.workPhoneNumber = txt_workPhoneNumber.Text.Trim();
                user_norm.mobileNumber = txt_mobileNumber.Text.Trim();
                
               // user_norm.userId = Guid.NewGuid();


                user_norm.userCreatedBy = Session["username"].ToString();
                user_norm.userCreatedDatetime = DateTime.Now;
                user_norm.userLatestEditedBy = Session["username"].ToString();
                user_norm.userLatestEditedDatetime = DateTime.Now;
                user_norm.registrationDatetime = DateTime.Now;

                DateTime now = DateTime.Now;
                now.ToString("MM/dd/yyyy hh:mm:ss");//所有日期如果出现问题，都这样格式化一下
                DateTime plus_now = now.AddMinutes(60);//有效期时间为当前时间+1
                plus_now.ToString("MM/dd/yyyy hh:mm:ss");
                string strTime = plus_now.ToString();

                DateTime dt = Convert.ToDateTime(strTime);
                user_norm.tokenExpiredDatetime = dt;


                string strCode = user_norm.firstName + dt;
             user_norm.registrationToken=user_norm.actiCode = EnDecrypt.Encrypt(strCode);

                if (Insert(user_norm))
                {
                    
                    SendSMTPEMail();
                    Response.Write("<script language=javascript>alert('The mail has been sent successfully! Please go to the mailbox and click the link to activate your account！');window.location.href='login.aspx';</script>");

                  //  Response.Write("new user mail have send!");
                }
                else
                {

                    Response.Write("create user fail!");
                }

            }
            
            //     break;
                 

          
        }

        /// <summary>
        /// 插入用户信息到数据库表
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private bool Insert(UserInfo_Normal user)
        {
            string sql = @"insert into local_users 
(firstName,surName,password,companyCode,position,workPhoneNumber,mobileNumber,emailAddress,userCreatedBy,userCreatedDatetime,userLatestEditedBy,userLatestEditedDatetime,activited,registrationToken,registrationDatetime,tokenExpiredDatetime)
VALUES (@firstName,@surName,@password,@companyCode,@position,@workPhoneNumber,@mobileNumber,@emailAddress,@userCreatedBy,@userCreatedDatetime,@userLatestEditedBy,@userLatestEditedDatetime,@activited,@registrationToken,@registrationDatetime,@tokenExpiredDatetime)";

            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@firstName",user.firstName),
                new SqlParameter("@surName",user.surName),
                new SqlParameter("@password",user.password),
                new SqlParameter("@companyCode",user.companyCode),
                new SqlParameter("@position",user.position),
                new SqlParameter("@workPhoneNumber",user.workPhoneNumber),
                new SqlParameter("@mobileNumber",user.mobileNumber),
                 new SqlParameter("@emailAddress",user.emailAddress),
                  new SqlParameter("@userCreatedBy",user.userCreatedBy),
                   new SqlParameter("@userCreatedDatetime",user.userCreatedDatetime),
                    new SqlParameter("@userLatestEditedBy",user.userLatestEditedBy),
                   new SqlParameter("@userLatestEditedDatetime",user.userLatestEditedDatetime),
                    new SqlParameter("@activited",user.activited=0),
                   new SqlParameter("@registrationToken",user.registrationToken),
                new SqlParameter("@registrationDatetime",user.registrationDatetime),
                    new SqlParameter("@tokenExpiredDatetime",user.tokenExpiredDatetime)
            };

            int i = DBHelp.ExecuteCommand(sql, para);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool isUser()
        {
            string userName = txt_firstName.Text.Trim();
            string surname = txt_surName.Text.Trim();
            string mail = txt_usermail.Text.Trim();
            string password = "123456";// txt_password.Text.Trim();
            string workphonenum = txt_workPhoneNumber.Text.Trim();

            user_norm = HaveUser(userName, mail);

            if (userName == "")
            {
               // Response.Write("用户名不能为空");
                lbl_msg.Text = "Username cannot be empty";
                return false;
            }
            if (surname == "")
            {                
                lbl_msg.Text = "Surname cannot be empty";
                return false;
            }
            if (password == "")
            {
                //Response.Write("密码不能为空");
                lbl_msg.Text = "Password cannot be empty";
                return false;
            }
            if (workphonenum == "")
            {
                // Response.Write("邮箱不能为空");
                lbl_msg.Text = "Workphonenum   cannot be empty";
                return false;
            }
            if (mail == "")
            {
               // Response.Write("邮箱不能为空");
                lbl_msg.Text = "Email address cannot be empty";
                return false;
            }
            if (userName == user_norm.firstName)
            {
               // Response.Write("用户名已存在");
                lbl_msg.Text = "Username already exists";
                return false;
            }


            if (mail == user_norm.emailAddress)
            {
                //Response.Write("邮箱已存在");
                lbl_msg.Text = "The mailbox already exists";
                return false;
            }
            else
            {
                userName = "";
                mail = "";
                password = "";
                return true;
            }

        }

        /// <summary>
        /// 是否用户已存在
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="Email"></param>
        /// <returns></returns>
        public UserInfo_Normal HaveUser(string userName, string Email)
        {
            UserInfo_Normal user = new UserInfo_Normal();
        
            string sql = "select firstName,surName,emailAddress from local_users where firstName='" + userName + "' or emailAddress='" + Email + "'";

           SqlDataReader reader = DBHelper.DBHelp.GetReader(sql);
           while (reader.Read())
           {
               user.firstName = reader.GetString(0);
               user.emailAddress = reader.GetString(1);
           }


           reader.Close();
            return user;
        }

        private UserInfo_Normal QueryId(string firstname,string email)
        {
            UserInfo_Normal user = new UserInfo_Normal();
            SqlDataReader reader = DBHelper.DBHelp.GetReader("select userId,firstName,emailAddress,registrationToken,tokenExpiredDatetime,activited from local_users where firstName=@firstName and emailAddress=@mail",
                new SqlParameter("@firstName", firstname),
                new SqlParameter("@mail", email));
            while (reader.Read())
            {
                user.userId = reader.GetInt32(0);               
                user.registrationToken = reader.GetString(3);              
            }
            reader.Close();
            return user;
        }

        /// <summary>
        /// 向新用户发送邮件
        /// </summary>
        private void SendSMTPEMail()
        {
            try
            {
                string addresser = "TempNewUser@kerrylogistics.com";//发送者的邮箱
                string recipient = this.txt_usermail.Text.Trim();//接收者的邮箱
                string userName = this.txt_firstName.Text.Trim();//接收者的用户名
                //string emailPwd = "FBW08uos$";//发送者的邮箱密码

                user_norm = QueryId(userName, recipient);
                string id = EnDecrypt.Encrypt(user_norm.userId.ToString());
                string code = user_norm.registrationToken;


                string title = "Thanks for registering, please verify your email registration";
                //   string str = string.Format("http://localhost:24569/RegistSuccess.aspx?userName={0}&id={1}&token={2}", userName, id, code); //激活码链接
                // string str = string.Format("http://localhost:24569/confirm.aspx?token={0}", code); //激活码链接
                string str = "http://localhost:44567/confirm.aspx?id=" + id+"&token=" + code + "";
                string content = "Please click the link to complete the email verification  " + str;// +",也可以访问http://localhost:24569/confirm.aspx，输入激活码：" + code + "进行激活";
                MailMessage message = new MailMessage(addresser, recipient);
                message.Subject = title;
                message.Body = content;
                message.Priority = MailPriority.High;
                SmtpClient client = new SmtpClient("KLAUVM19.kerrylogistics.com", 25);//更改，例如smtp.163.com，smtp.gmail.com
                client.EnableSsl = false;
                client.UseDefaultCredentials = false;
                //client.Credentials = new System.Net.NetworkCredential(addresser, emailPwd);
                client.Send(message);
            }
            catch (Exception ex)
            {
               // Response.Write("email send fail..."+ex.ToString());
                lbl_msg.Text = "Sending error" + ex.ToString();
            }
        }

        protected void lb_exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginout.aspx");
        }

        protected void txt_usermail_TextChanged(object sender, EventArgs e)
        {

        }

        //protected void lb_exit_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("loginout.aspx");
        //}





    }
}