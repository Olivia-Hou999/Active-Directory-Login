using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



using ADHelper;
using DBHelper;
using System.Data.SqlClient;
using System.Data;

using System.Text.RegularExpressions;

namespace ADlogin
{
    public partial class TestPWD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 密码强度验证
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static bool ChkPwdPower(string pwd)
        {
            var regex = new Regex(@"^[a-zA-Z]{1}(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");//[^a-zA-Z](?=.*[0-9])(?=.*?[a-z])(?=.*?[A-Z])(?=([\x21-\x7e])).{8,30}
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

        protected void ok_Click(object sender, EventArgs e)
        {
            if (ChkPwdPower(pwd.Text))
            {
                lblmsg.Text = "验证通过";
            }
            else
            {
                lblmsg.Text = "未通过";
            }
        }
    }
}