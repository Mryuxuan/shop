using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modal;

namespace DAL
{
   public  class OrderItemDAL
    {
        database db = new database();
        //定义一个方法来添加记录
        public int AddOrderItem(OrderItem item)
        {
            string sql = "";
            sql = "insert into orderItem(productId,number,orderFormId) values(";
            sql = sql + item.ProductId + ",";
            sql = sql + item.Num + ",";
            sql = sql + item.OrderFormId + ")";
            int t = db.ExecSql(sql);
            return t;

        }

    }
}
