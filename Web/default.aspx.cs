using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Modal;
using System.Data;
using System.Data.OleDb;
using DAL;
namespace Web
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //在服务器执行
            if (Page.IsPostBack == false)//页面加载有2种情况，首次加载，回送加载 IsPostback为false 时，页面是第一次加载
            {
                //读出特价商品
                //以下代码页面首次加载时执行
                string sql;
                ProdcutBLL bll = new ProdcutBLL();
                DataSet ds;
                sql = "select top 5 * from productView  ";
                ds = bll.getProduct(sql);
                DataList1.DataSource = ds.Tables[0];
                DataList1.DataBind();
                sql = "select top 8 * from productview order by createdate desc";
                ds = bll.getProduct(sql);
                DataList2.DataSource = ds.Tables[0];
                DataList2.DataBind();
                //读出公告标题 ,没有使用三层
                sql = "select top 5 * from notify order by date desc";
                database db=new database();
                OleDbDataReader dr = db.GetDataReader(sql);
                string t = "";
                t = "<marquee direction=up scrolldelay=200 width=295 height=170 onmouseover=this.stop() onmouseout=this.start()>";
                while (dr.Read())
                {
                    t = t + "<a href=dispNotify.aspx?id=" + dr["notifyId"].ToString() + ">" + "★—" + dr["desn"].ToString() + "</a><br>";

                 }
                t = t + "</marquee>";
                Label5.Text = t;
                //读出新闻
                sql = "select top 12 * from news order by date desc";
                ds = db.GetDataSet(sql);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();             
                //新品推荐
                sql="select top 10 * from productView order by createDate desc";
                ds = bll.getProduct(sql);
                GridView2.DataSource = ds.Tables[0];
                GridView2.DataBind();
                db.close();
            }            
        }
        protected void LinkButton1_Click(object sender, EventArgs e)//登录按钮单击事件
        {
            if (txtName.Text.Trim() == "请输入用户名")
            {
               Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('请输入用户名！')", true);               
               // Response.Write("<script>alert('请输入用户名！')</script>");
                return;
            }
            if (txtPwd.Text.Trim() == "")
            {
                //Response.Write("<script>alert('请输入密码！')</script>");
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('请输入密码！')", true);
                return;
            }
            string username;
            Users u;
            UserBLL bll = new UserBLL();
            username = txtName.Text.Trim();
            u = bll.getUserByName(username);//读出用户的信息
            if (u != null && u.Password == txtPwd.Text.Trim())
            {
                lblUserName.Text = username;
                txtName.Text = "请输入用户名";
                //Response.Write("<script>alert('登录成功！')</script>");
                //保存用户信息
                Session["users"] = u; 
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('登录成功！')", true);
            }
            else
            {
                //Response.Write("<script>alert('用户名或密码错误！')</script>");
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('用户名或密码错误！')", true);
            }           

        }
        //单击datalist中按钮，该事件都会发生
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "select")
                Response.Redirect("productInfo.aspx?id=" + DataList1.DataKeys[e.Item.ItemIndex].ToString());
            if (e.CommandName == "buy")
                Response.Redirect("productInfo.aspx?id=" + DataList1.DataKeys[e.Item.ItemIndex].ToString());

        }

        protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "select")
                Response.Redirect("productInfo.aspx?id=" + DataList2.DataKeys[e.Item.ItemIndex].ToString());
                    
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            if (Session["users"] == null)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('您还未登录，不能发布商品！')", true);
               // Response.Redirect("default.aspx");

            }
            else
            {
                //Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('您已经登录，发布商品！')", true);
                //检测用户是否具有发布商品的权限,如果为普通客户
                Users u = (Users)Session["users"];
                if (u.RoleId > 2)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('您没有发布商品的权限！')", true);
                    Response.Write("<script>window.opener=null;window.close();</script>");//关闭当前窗口
                }
                else//具有发布商品的权限
                {
                    Response.Redirect("addProduct.aspx");
                }
            }
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            if (Session["users"] != null)
            {
                Response.Redirect("Admin/NewsInfo.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('您还未登录，请登录后尝试！')", true);
            }
        }
    }
}