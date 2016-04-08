using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using System.IO;//文件操作
using Modal;
namespace Web
{
    public partial class addProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                //判断用户是否已经登录
                if (Session["users"] == null)
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('您还未登录，请到首页登录!')", true);
                    Response.Redirect("default.aspx");//转到首页

                }
               //用户已经登录
                 Users u = (Users)Session["users"];
                 if (u.RoleId > 2)
                    {
                        Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('对不起，您没有无权操作！')", true);
                        Response.Redirect("default.aspx");//转到首页
                    }
                 //用户有权限发布商品
                //判断用户问文件夹是否已经存在
                 if(Directory.Exists(Server.MapPath("image/"+u.Userid))==false)
                 {
                     //创建用户的文件夹
                     Directory.CreateDirectory(Server.MapPath("image/"+u.Userid));

                 }
                  Editor1.SetSecurityImageGalleryPath(Server.MapPath("/image/") + u.Userid);
                  Editor1.SetSecurityGalleryPath(Server.MapPath("/image/") + u.Userid);
                  Editor1.SetSecurityImageBrowserPath(Server.MapPath("/image/") + u.Userid);                 
                //读出商品类别
                //大类parentid=1
                  CategoryBLL bll = new CategoryBLL();
                  DataSet ds = bll.getCategoryByParentId(1);
                  ddlType1.DataSource = ds.Tables[0].DefaultView;
                  ddlType1.DataTextField = "desn";//文本字段 ，显示的文本
                  ddlType1.DataValueField = "categoryId";//值字段
                  ddlType1.DataBind();
                  ddlType1.SelectedIndex = 0;//选中第一项
                //子类
                  ds = bll.getCategoryByParentId(int.Parse(ddlType1.SelectedValue));
                  ddlType2.DataSource = ds.Tables[0];
                  ddlType2.DataTextField = "desn";
                  ddlType2.DataValueField = "categoryid";
                  ddlType2.DataBind();
            }
        }

        protected void ddlType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //父类中选择的商品类别
            int parentId = int.Parse(ddlType1.SelectedValue.ToString());
            CategoryBLL bll = new CategoryBLL();
            DataSet ds = bll.getCategoryByParentId(parentId);
            ddlType2.DataTextField = "desn";
            ddlType2.DataValueField = "categoryId";
            ddlType2.DataSource = ds.Tables[0];
            ddlType2.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Users u = (Users)Session["users"];
            string dir = "";//文件上传的位置
            try
            {
                if (FileUpload1.HasFile)//判断用户选择要上传的文件
                {
                    dir = Server.MapPath("/image/" + u.Userid);
                    //判断用户上传文件是否已经存在
                    if (File.Exists(dir + FileUpload1.FileName))
                    {
                        Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('文件已经存在！')", true);
                        return;

                    }
                    FileUpload1.SaveAs(dir + "/" + FileUpload1.FileName);//上传文件

                }
                else//用户没有选择要上传的文件
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('请选择要上传的文件！')", true);
                    return;
                }
                Product p = new Product();
                p.Name = txtName.Text;
                p.CategroyId = int.Parse(ddlType2.SelectedValue.ToString());
                p.Desn = Editor1.Text;
                p.UserId = u.Userid;
                p.CreateDate = DateTime.Now;
                p.SellInDate = DateTime.Today.AddDays(int.Parse(txtDay.Text.Trim()));
                p.Unit = ddlUnit.SelectedItem.Text;
                p.Quantity = int.Parse(txtNum.Text);
                p.Upper = int.Parse(txtUpper.Text);
                p.Lower = int.Parse(txtLower.Text);
                p.InPrice = double.Parse(txtInPrice.Text);
                p.OutPrice = double.Parse(txtOutPrice.Text);
                p.Picture = "/" + u.Userid + "/" + FileUpload1.FileName;
                p.Remark = txtRemark.Text;
                ProdcutBLL bll = new ProdcutBLL();
                bll.AddProduct(p);
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('数据提交成功！')", true);
            }
            catch (Exception ee)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('保存失败！')", true);
            }

        }
    }
}