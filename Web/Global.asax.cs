using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;
namespace Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();//数据表
            DataColumn dc;//数据列
            //定义商品编号列
            dc = new DataColumn();
            dc.ColumnName = "Id";
            dc.DataType = System.Type.GetType("System.Int32");
            dt.Columns.Add(dc);
            //定义商品名称列
            dc = new DataColumn();
            dc.ColumnName = "Name";
            dc.DataType = System.Type.GetType("System.String");
            dt.Columns.Add(dc);
            //定义商品价格
            dc = new DataColumn();
            dc.ColumnName = "price";
            dc.DataType = System.Type.GetType("System.Double");
            dt.Columns.Add(dc);
            //定义商品数量
            dc = new DataColumn();
            dc.ColumnName = "Num";
            dc.DataType = System.Type.GetType("System.Int32");
            dt.Columns.Add(dc);
            Session["dt"] = dt;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}