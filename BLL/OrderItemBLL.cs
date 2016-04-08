using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modal;
namespace BLL
{
   public  class OrderItemBLL
    {
        OrderItemDAL dal = new OrderItemDAL();
        public int AddOrderItem(OrderItem item)
        {
            return dal.AddOrderItem(item);

        }

    }
}
