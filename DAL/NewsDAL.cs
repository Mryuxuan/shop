using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modal;

namespace DAL
{
    public class NewsDAL
    {
        database db = new database();
        //定义一个方法添加新闻
        public void addNews(News news) 
        {
            string sql = "select top 1 * from news order by newsId";
            DataSet ds = db.GetDataSet(sql);
            DataRow row = ds.Tables[0].NewRow();
            row["desn"] = news.Desn;
            row["body"] = news.Body;
            row["date"] = DateTime.Now;
            row["userid"] = news.UserId;
            ds.Tables[0].Rows.Add(row);
            db.UpdateDataset(sql, ds);

        }
        //定义一个方法更新新闻
        public int updateNews(News news)
        {
            string sql = "update news set desn ='" + news.Desn + "',body ='" + news.Body + "' where Newsid=" + news.Id;
            int x = db.ExecSql(sql);
            return x;
        }
        //定义一个方法删除新闻
        public int deleteNews(string[] ids)
        {
            string sql = "";
            for (int i = 0; i < ids.Length; i++)
            {
                if (i == 0)
                    sql = "delete news where newsid=" + ids[i];
                else
                    sql = sql + " or newsid=" + ids[i];
            }
            int count = db.ExecSql(sql);
            return count;
        }
        //定义一个方法得到新闻
        public DataSet getNewsByPage(int pageNo, int pageSize, string title)
        {
            string sql = "select top " + pageSize + "  * from V_news where newsId not in(select top  " + (pageNo - 1) * pageSize + " newsID from V_news where desn like '%" + title + "%' order by date) and desn like '%" + title + "%' order by date ";
            DataSet ds = db.GetDataSet(sql);
            return ds;
        }
        //定义一个方法得到新闻总数
        public int getNewsCount(string title)
        {
            string sql = "select * from V_news where desn like '%" + title + "%'";
            DataSet ds = db.GetDataSet(sql);
            return ds.Tables[0].Rows.Count;
        }
    }
}
