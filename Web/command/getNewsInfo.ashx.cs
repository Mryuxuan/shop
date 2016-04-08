using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using BLL;
using Newtonsoft.Json;
using Modal;

namespace Web.command
{
    /// <summary>
    /// getNewsInfo 的摘要说明
    /// </summary>
    public class getNewsInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            NewsBLL bll = new NewsBLL();
            if (context.Request["type"].ToString() == "show")
            {
                int pageNo = int.Parse(context.Request["page"].ToString());
                int pageSize = int.Parse(context.Request["rows"].ToString());
                string title = "";
                if (context.Request["desn"] != null)
                    title = context.Request["desn"].ToString().Trim();                
                int count = bll.getNewsCount(title);
                DataSet ds = bll.getNewsByPage(pageNo, pageSize, title);
                string json;
                json = Newtonsoft.Json.JsonConvert.SerializeObject(ds.Tables[0], new Newtonsoft.Json.Converters.DataTableConverter());
                json = "{\"total\":" + count.ToString() + ",\"rows\":" + json + "}";
                context.Response.Write(json);
            }
            else
                if(context.Request["type"].ToString()=="del")
                {
                    string ids=context.Request["id"].ToString();
                    string[] id=ids.Split(',');
                    int count=bll.deleteNews(id);
                    context.Response.Write(count);
                }
            else 
                if (context.Request["type"].ToString() == "add")
                {
                    string body, desn;
                    News n = new News();
                    body = context.Request["body"].ToString();
                    desn = context.Request["desn"].ToString();
                    n.Desn = desn;
                    n.Body = body;
                    n.UserId = 1;
                    n.Date = DateTime.Now;
                    bll.addNews(n);
                    context.Response.Write("添加");

                }
            else
                if (context.Request["type"].ToString() == "edit")
                {
                    string desn, body;
                    int id;
                    desn = context.Request["desn"].ToString();
                    body = context.Request["body"].ToString();
                    id = int.Parse(context.Request["id"].ToString());
                    News n = new News();
                    n.Id = id;
                    n.Desn = desn;
                    n.Body = body;
                    bll.updateNews(n);
                    context.Response.Write("更新");
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