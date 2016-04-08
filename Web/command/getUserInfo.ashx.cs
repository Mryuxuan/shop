using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Newtonsoft.Json;
using System.Data;
using System.Data.OleDb;
using System.Web.SessionState;

namespace Web.command
{
    /// <summary>
    /// getUserInfo 的摘要说明
    /// </summary>
    public class getUserInfo : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");

            int pageNo, pageSize;
            int count;//记录总数
            pageNo = int.Parse(context.Request["page"].ToString());//得到页号
            pageSize = int.Parse(context.Request["rows"].ToString());//得到分页大小
            UserBLL bll = new UserBLL();
            DataSet ds = bll.getAllUserInfo(pageNo, pageSize);
            count = bll.getAllUsersCount();
            string json;
            json = Newtonsoft.Json.JsonConvert.SerializeObject(ds.Tables[0], new Newtonsoft.Json.Converters.DataTableConverter());
            json = "{\"total\":" + count + ",\"rows\":" + json + "}";
            context.Response.Write(json);

            //UserBLL bll = new UserBLL();
            //DataSet ds = bll.getAllUser();
            //string json;
            //json = Newtonsoft.Json.JsonConvert.SerializeObject(ds.Tables[0],new Newtonsoft.Json.Converters.DataSetConverter());
            //json = "{\"total\":" + ds.Tables[0].Rows.Count.ToString() + ",\"rows\":" + json + "}";
            //context.Response.Write(json);


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