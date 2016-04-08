using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Newtonsoft.Json;
using System.Data;

namespace Web.command
{
    /// <summary>
    /// getCategory 的摘要说明
    /// </summary>
    public class getCategory : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            CategoryBLL bll = new CategoryBLL();
            if (context.Request["id"] != null)
            {
                int id = int.Parse(context.Request["id"].ToString());
                DataSet ds = bll.getCategoryByParentId(id);
                string result = Newtonsoft.Json.JsonConvert.SerializeObject(ds.Tables[0], new Newtonsoft.Json.Converters.DataTableConverter());
                context.Response.Write(result);
            }
            //context.Response.Write("Hello World");
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