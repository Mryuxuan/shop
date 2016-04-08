using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modal;
using BLL;
using System.Data;
namespace Web
{
    public partial class ProductInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                ProdcutBLL bll = new ProdcutBLL();
                Product p;
                //得到商品的编号
                int id = int.Parse(Request["id"].ToString());
                p = bll.getProductById(id);
                lblName.Text = p.Name;
                lblSell.Text = p.UserName;
                lblNum.Text = p.Quantity.ToString();
                lblPrice.Text = p.OutPrice.ToString();
                lblUnit.Text = p.Unit;
                Image1.ImageUrl = "image" + p.Picture;
                Literal1.Text = p.Desn;
                HyperLink4.NavigateUrl = "tencent://message/?uin=" + "123456";

            }

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //查看当前购物车是否当前选购的商品
            DataTable dt;
            dt = (DataTable)Session["dt"];//读出购物车信息
            int id = int.Parse(Request["id"].ToString());//得到当前商品的编号
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(id==int.Parse(dt.Rows[i]["id"].ToString()))
                {
                    //修改商品的数量
                    dt.Rows[i]["num"] = int.Parse(dt.Rows[i]["num"].ToString()) + int.Parse(txtNum.Text.Trim());
                    //保存购物车信息
                    Session["dt"] = dt;
                    Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('商品成功添加到购物车！')", true);
                    return;
                }

           }
            //当前商品是用户新购买的商品，购物车没有该种商品
            DataRow dr = dt.NewRow();
            dr["id"] = id;//商品的id
            dr["name"] = lblName.Text;
            dr["price"] = lblPrice.Text;
            dr["num"] = txtNum.Text;
            dt.Rows.Add(dr);
            Session["dt"] = dt;
            Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('商品成功添加到购物车！')", true);

            
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["users"] == null)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('你还未登录，请到首页登录！')", true);
                return;
            }
            //判断购物车中是否有商品
            DataTable dt = (DataTable)Session["dt"];
            if (dt.Rows.Count <= 0)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('你还未选购商品!')", true);
                return;
            }
            //读出用户登录信息
            Users u = (Users)Session["users"];
            int totalNum = 0;
            double totalMoney = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                totalNum = totalNum + int.Parse(dt.Rows[i]["num"].ToString());//订单商品总数量
                totalMoney = totalMoney + int.Parse(dt.Rows[i]["num"].ToString()) * double.Parse(dt.Rows[i]["price"].ToString());//总钱数
                
            }
            try
            {             //定义一个订单
                OrderForm of = new OrderForm();
                of.OrderDate = DateTime.Now;
                of.TotalNumber = totalNum;
                of.TotalMoney = totalMoney;
                of.PayMode = 1;
                of.State = 1;
                of.UserId = u.Userid;
                OrderFormBLL ofBLL = new OrderFormBLL();
                of = ofBLL.addOrderForm(of);
                //保存订单详细信息，往订单明细表写数据
                OrderItem item = new OrderItem();
                OrderItemBLL itemBLL = new OrderItemBLL();
                item.OrderFormId = of.OrderFormID;//订单号
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    item.ProductId = int.Parse(dt.Rows[i]["id"].ToString());//商品的编号id
                    item.Num = int.Parse(dt.Rows[i]["num"].ToString());//商品数量
                    itemBLL.AddOrderItem(item);
                }
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('订单生成成功！')", true);
            }
            catch (Exception ee)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('订单生成失败！')", true);

            }

        }

       
    }
}