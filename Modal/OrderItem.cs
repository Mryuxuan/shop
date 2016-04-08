using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modal
{
  public   class OrderItem
    {
        int orderItemId;

        public int OrderItemId
        {
            get { return orderItemId; }
            set { orderItemId = value; }
        }
        int productId;//商品的id

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        int num;//数量

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        int orderFormId;//订单号

        public int OrderFormId
        {
            get { return orderFormId; }
            set { orderFormId = value; }
        }

    }
}
