using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modal
{
  public   class Product
    {
        int productId;//商品编号

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        string name;//商品名称

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string desn;// 商品描述

        public string Desn
        {
            get { return desn; }
            set { desn = value; }
        }
        DateTime createDate;//注册日期

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        DateTime sellInDate;//有效期

        public DateTime SellInDate
        {
            get { return sellInDate; }
            set { sellInDate = value; }
        }
        string unit;//单位

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        int quantity;//数量

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        int upper;

        public int Upper//最大库存量
        {
            get { return upper; }
            set { upper = value; }
        }
        int lower;//最低库存量

        public int Lower
        {
            get { return lower; }
            set { lower = value; }
        }
        double inPrice;//进货价格

        public double InPrice
        {
            get { return inPrice; }
            set { inPrice = value; }
        }
        double outPrice;//卖出价格

        public double OutPrice
        {
            get { return outPrice; }
            set { outPrice = value; }
        }
        string picture;//图片

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        string remark;//备注

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
        int categroyId;//类别的id

        public int CategroyId
        {
            get { return categroyId; }
            set { categroyId = value; }
        }
        string title;//类别的名称

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        int parentId;//商品父类别

        public int ParentId
        {
            get { return parentId; }
            set { parentId = value; }
        }
        string userName;//商品所属卖家

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        string realName;

        public string RealName
        {
            get { return realName; }
            set { realName = value; }
        }
        int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
    }
}
