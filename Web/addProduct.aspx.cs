using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using Modal;
using System.IO;


namespace Web
{
    public partial class SPTJ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["users"]==null)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('您还未登录，不能发布商品！')", true);
                Response.Redirect("default.aspx");

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
                    //判断用户手否第一次发布商品,以用户的userid为名称，在image 文件夹下面为用户建立文件夹，用来存放用户文件
                    if (Directory.Exists(Server.MapPath("/image/" + u.Userid)) == false)//表示用户文件夹不存在
                    {
                        Directory.CreateDirectory(Server.MapPath("/image/") + u.Userid);//创建用户文件夹
                    }

                }

            }
        }
    }
}