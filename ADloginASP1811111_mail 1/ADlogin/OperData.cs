using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ADHelper;
using DBHelper;
using System.Data.SqlClient;
using System.Data;

using System.Text.RegularExpressions;

namespace ADlogin
{
    public class OperData
    {
        private static UserInfo_Normal QueryPwd(string token)
        {
            UserInfo_Normal user = new UserInfo_Normal();
            SqlDataReader reader = DBHelper.DBHelp.GetReader("select userId,firstName,emailAddress,registrationToken,tokenExpiredDatetime,activited,password from local_users where registrationToken=@token",

                new SqlParameter("@token", token));
            while (reader.Read())
            {
                user.userId = reader.GetInt32(0);
                user.firstName = reader.GetString(1);
                user.emailAddress = reader.GetString(2);
                user.registrationToken = reader.GetString(3);
                user.tokenExpiredDatetime = reader.GetDateTime(4);
                user.activited = reader.GetInt32(5);
                user.password = reader.GetString(6);
            }
            reader.Close();
            return user;
        }



        private static UserInfo_Normal QueryId(string firstname, string email)
        {
            UserInfo_Normal user = new UserInfo_Normal();
            SqlDataReader reader = DBHelper.DBHelp.GetReader("select userId,firstName,emailAddress,registrationToken,tokenExpiredDatetime,activited from local_users where firstName=@firstName and emailAddress=@mail",
                new SqlParameter("@firstName", firstname),
                new SqlParameter("@Email", email));
            while (reader.Read())
            {
                user.userId = reader.GetInt32(0);
                user.firstName = reader.GetString(1);
                user.emailAddress = reader.GetString(2);
                user.registrationToken = reader.GetString(3);
                user.tokenExpiredDatetime = reader.GetDateTime(4);
                user.activited = reader.GetInt32(5);
            }
            reader.Close();
            return user;
        }


        public static UserInfo_Normal QueryIdByToken(string token)
        {
            UserInfo_Normal user = new UserInfo_Normal();

           // DataTable dt = DBHelp.GetDataSet("select userId,firstName,emailAddress,registrationToken,expTime,activited,password from local_users where registrationToken='" + token + "'");
            DataTable dt = DBHelp.GetDataSet("select * from local_users where registrationToken='" + token + "'");

            if (dt.Rows.Count > 0)
            {
                user.userId = int.Parse(dt.Rows[0]["userId"].ToString());
                user.firstName = dt.Rows[0]["firstName"].ToString();
                user.emailAddress = dt.Rows[0]["emailAddress"].ToString();
                user.registrationToken = dt.Rows[0]["registrationToken"].ToString();
                user.tokenExpiredDatetime = Convert.ToDateTime(dt.Rows[0]["tokenExpiredDatetime"].ToString());
                string act = dt.Rows[0]["activited"].ToString();
                if (act == "true")
                {
                    user.activited = 1;
                }
                else
                {
                    user.activited = 0;
                }
                user.password = dt.Rows[0]["password"].ToString();
            }

            return user;
        }

        public static UserInfo_Normal QueryInfoByID(string id)
        {
            UserInfo_Normal user = new UserInfo_Normal();

            // DataTable dt = DBHelp.GetDataSet("select userId,firstName,emailAddress,registrationToken,expTime,activited,password from local_users where registrationToken='" + token + "'");
            DataTable dt = DBHelp.GetDataSet("select * from local_users where userId='" + id + "'");

            if (dt.Rows.Count > 0)
            {
                user.userId = int.Parse(dt.Rows[0]["userId"].ToString());
                user.firstName = dt.Rows[0]["firstName"].ToString();
                user.emailAddress = dt.Rows[0]["emailAddress"].ToString();
                user.registrationToken = dt.Rows[0]["registrationToken"].ToString();
                user.tokenExpiredDatetime = Convert.ToDateTime(dt.Rows[0]["tokenExpiredDatetime"].ToString());
                string act = dt.Rows[0]["activited"].ToString();
                if (act == "true")
                {
                    user.activited = 1;
                }
                else
                {
                    user.activited = 0;
                }
                user.password = dt.Rows[0]["password"].ToString();
            }
            return user;
        }

        public static string QueryUserIDByfirstname(string firstname)
        {

            string res = "";
            // DataTable dt = DBHelp.GetDataSet("select userId,firstName,emailAddress,registrationToken,expTime,activited,password from local_users where registrationToken='" + token + "'");
            DataTable dt = DBHelp.GetDataSet("select * from local_users where firstName='" + firstname + "'");

            if (dt.Rows.Count > 0)
            {
                res =dt.Rows[0]["userId"].ToString();
            }
            return res;
        }

        public static string QueryUserIDBymail(string email)
        {

            string res = "";
            // DataTable dt = DBHelp.GetDataSet("select userId,firstName,emailAddress,registrationToken,expTime,activited,password from local_users where registrationToken='" + token + "'");
            DataTable dt = DBHelp.GetDataSet("select * from local_users where emailAddress='" + email + "'");

            if (dt.Rows.Count > 0)
            {
                res = dt.Rows[0]["userId"].ToString();
            }
            return res;
        }

        /// <summary>
        /// 通过邮箱查询用户名
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static string QueryUserNameBymail(string email)
        {

            string res = "";
            // DataTable dt = DBHelp.GetDataSet("select userId,firstName,emailAddress,registrationToken,expTime,activited,password from local_users where registrationToken='" + token + "'");
            DataTable dt = DBHelp.GetDataSet("select * from local_users where emailAddress='" + email + "'");

            if (dt.Rows.Count > 0)
            {
                res = dt.Rows[0]["firstName"].ToString();
            }
            return res;
        }

        public static bool UpdateActive(string token)
        {
            string sql = "Update local_users Set activited=1 where registrationToken='"+token+"'";

            int i = DBHelp.ExecuteCommand(sql);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool UpdateActiveByID(string id)
        {
            string sql = "Update local_users Set activited=1 where userId='" + id + "'";

            int i = DBHelp.ExecuteCommand(sql);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool DelAccount(string id)
        {
            string sql = "delete from local_users  where userId='" + id + "'";
            int i = DBHelp.ExecuteCommand(sql);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool changepwd(string id,string pwd)
        {
            string sql = "Update local_users Set password='"+pwd+"' where userId='" + id + "'";

            int i = DBHelp.ExecuteCommand(sql);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static bool logined(string username, string pwd)
        {
            try
            {
                string sql = "select * from local_users where firstName='"+username+"' and activited=1";
                DataTable dt = DBHelp.GetDataSet(sql);
                if (dt.Rows.Count > 0)
                {
                    string dt_pwd = dt.Rows[0]["password"].ToString();
                    if (pwd == dt_pwd)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static bool loginedByEmail(string usermail, string pwd)
        {
            try
            {
                string sql = "select * from local_users where emailAddress='" + usermail + "' and activited=1";
                DataTable dt = DBHelp.GetDataSet(sql);
                if (dt.Rows.Count > 0)
                {
                    string dt_pwd = dt.Rows[0]["password"].ToString();
                    if (pwd == dt_pwd)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return false;
            }
        }


        public static bool insertLog(Crystal_clear_logs log)
        {
             string sql_insert_log = "insert into crystal_clear_logs (userId,action,actionDetails,actionDatetime) values('"+log.userId+"','"+log.action+"','"+log.actionDetails+"','"+ log.actionDatetime.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            
            int res=DBHelp.ExecuteCommand(sql_insert_log);
                    if (res >0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
        }

        /// <summary>
        /// 查询重复邮箱
        /// </summary>
        /// <param name="pinyinsuoxie"></param>
        /// <returns></returns>
        public static bool ChkReEmail(string email)
        {
            
            using (SqlConnection conn = DBHelp.GetConnection())
            {
                string sql = @"select * from local_users 
where emailAddress='" + email + "'";//or emailAddress

                DataTable dt = DBHelp.GetDataSet(sql);

                if (dt.Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        /// <summary>
        /// 密码强度验证
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static bool ChkPwdPower(string pwd)
        {
            //var regex = new Regex(@"[a-zA-Z](?=.*[0-9])(?=.*[^a-zA-Z])(?=([\x21-\x7e]+)[^a-zA-Z0-9]).{8,30}");
            var regex = new Regex(@"^[a-zA-Z]{1}(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

//                                [a-zA-Z]                             
//                                (?=.*[0-9])
//                                (?=.*[^a-zA-Z])
//                                (?=([\x21-\x7e]+)[^a-zA-Z0-9])
//                                .{8,30}"
//                                );
            //字母开头
            //必须要有数字
            //必须要有一个大写字母和一个小写字母
            //必须有特殊符号
            //至少8个字符，最多30个字符

            if (regex.IsMatch(pwd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}