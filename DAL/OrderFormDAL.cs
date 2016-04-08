using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modal;
namespace DAL
{
  public   class OrderFormDAL
    {
      database db = new database();
      //生成订单，并返回含订单号的订单实体
      public OrderForm addOrderForm(OrderForm f)
      {
          string sql = "insert into orderform(userid,totalNumber,totalMoney,orderDate,state,paymode) values(";
          sql = sql + f.UserId + ",";
          sql = sql + f.TotalNumber + ",";
          sql = sql + f.TotalMoney + ",";
          sql = sql + "'" + f.OrderDate.ToString() + "',";
          sql = sql + f.State + ",";
          sql = sql + f.PayMode + ")";
          int t = db.ExecSql(sql);
          //读出订单号
          sql = "select @@identity";
          DataSet ds = db.GetDataSet(sql);
          int orderformId;
          if (ds.Tables[0].Rows.Count > 0)
          {
              orderformId = int.Parse(ds.Tables[0].Rows[0][0].ToString());
              f.OrderFormID = orderformId;
              return f;

          }
          else
          {
              return null;
          }

      }
    }
}
