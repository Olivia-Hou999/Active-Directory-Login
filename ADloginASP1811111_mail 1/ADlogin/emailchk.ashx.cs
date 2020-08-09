using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ADlogin
{
    /// <summary>
    /// emailchk 的摘要说明
    /// </summary>
    public class emailchk : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string useremail = context.Request["user_email"];
            if ((useremail != null) || (useremail != ""))
            {
                if (OperData.ChkReEmail(useremail))
                {
                    context.Response.Write("Email address can be used");

                }
                else
                {
                    context.Response.Write("The email address already exsited ");
                }
            }
            else
            {
                context.Response.Write("Enqury error");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}