using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Modal;
using System.Web.SessionState;

namespace Web.command
{
    /// <summary>
    /// loginCheck 的摘要说明
    /// </summary>
    public class loginCheck : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            Users u;
            string username = context.Request["name"].ToString();
            string password = context.Request["pwd"].ToString();
            UserBLL bll = new UserBLL();
            u = bll.getUserByName(username);
            if (u != null && u.Password == password)
            {
                context.Session["users"] = u;
                context.Response.Write("1");
            }
            else
                context.Response.Write("0");
           // context.Response.Write("Hello World");
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