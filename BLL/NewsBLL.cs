using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modal;
using DAL;

namespace BLL
{
    public class NewsBLL
    {
        NewsDAL dal = new NewsDAL();
        //定义一个方法添加新闻
        public void addNews(News news)
        {
            dal.addNews(news);
        }
        //定义一个方法更新新闻
        public int updateNews(News news)
        {
            return dal.updateNews(news);
        }
         //定义一个方法删除新闻
        public int deleteNews(string[] ids)
        {
            return dal.deleteNews(ids);
        }
        //定义一个方法得到新闻
        public DataSet getNewsByPage(int pageNo, int pageSize, string title)
        {            
            return dal.getNewsByPage(pageNo,pageSize,title);
        }
         //定义一个方法得到新闻总数
        public int getNewsCount(string title)
        {            
            return dal.getNewsCount(title);
        }
    }
}
