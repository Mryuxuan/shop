using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modal
{
    public class OrderForm
    {
        int orderFormID;//CRTl+r +e

        public int OrderFormID
        {
            get { return orderFormID; }
            set { orderFormID = value; }
        }
        int userId;
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        int totalNumber;

        public int TotalNumber
        {
            get { return totalNumber; }
            set { totalNumber = value; }
        }
        double totalMoney;

        public double TotalMoney
        {
            get { return totalMoney; }
            set { totalMoney = value; }
        }
        DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        int state;
        public int State
        {
            get { return state; }
            set { state = value; }
        }
        int payMode;

        public int PayMode
        {
            get { return payMode; }
            set { payMode = value; }
        }

    }


}
