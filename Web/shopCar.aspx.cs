using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Web
{
    public partial class shopCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                data_bind();
            }

        }
        private void data_bind()
        {
            DataTable dt = (DataTable)Session["dt"];
            GridView1.DataSource = dt;
            GridView1.DataBind();
            //计算总价钱
            double total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //商品单价*数量
                total = total+double.Parse(dt.Rows[i]["price"].ToString()) * int.Parse(dt.Rows[i]["num"].ToString());
                
            }
            Label6.Text = total.ToString();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //读出购物车中的信息
            DataTable dt;
            dt = (DataTable)Session["dt"];
            //读出当前商品的编号
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //在购物车中搜索该商品
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (id == dt.Rows[i]["id"].ToString())
                {
                    dt.Rows.RemoveAt(i);
                    break;
                }
            }
            //保存购物车
            Session["dt"] = dt;
            data_bind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            data_bind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            data_bind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox txt;
            txt = (TextBox)GridView1.Rows[e.RowIndex].FindControl("TxtNum");
            //得到当前编辑行商品的id
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            DataTable dt = (DataTable)Session["dt"];
            //在购物车中找当前商品，并修改商品数量
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (id == dt.Rows[i]["id"].ToString())
                {
                    dt.Rows[i]["num"] = txt.Text.Trim();
                    break;
                }
            }
            //保存购物车
            Session["dt"] = dt;
            GridView1.EditIndex = -1;//取消编辑状态
            data_bind();
        }
    }
}