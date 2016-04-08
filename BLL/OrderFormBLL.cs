using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modal;
using DAL;
namespace BLL
{
  public  class OrderFormBLL
     
    {
      OrderFormDAL dal = new OrderFormDAL();
       //生成订单，并返回含订单号的订单实体
      public OrderForm addOrderForm(OrderForm f)
      {
          return dal.addOrderForm(f);
      }
    }
}
