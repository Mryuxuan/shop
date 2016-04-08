using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Modal;
using System.IO;
using System.Data;
using System.Web.SessionState;
using DAL;

namespace Web.command
{
    /// <summary>
    /// addProduct 的摘要说明
    /// </summary>
    public class addProduct : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
           // string name = context.Request["productName"].ToString();
            //得到商品名称
            string name = context.Request["productName"].ToString();
            int categoryId = int.Parse(context.Request["categoryId"].ToString());//商品类别
            string desn = context.Request["desn"].ToString();//商品描述
            //读出当前登录用户的信息
            Users u = (Users)context.Session["users"];
            DateTime sellIndate = DateTime.Parse(context.Request["sellIndate"].ToString());
            string unit = context.Request["unit"].ToString();
            int quantity = int.Parse(context.Request["quantity"].ToString());
            int upper = int.Parse(context.Request["upper"].ToString());
            int lower = int.Parse(context.Request["lower"].ToString());
            double inPrice = 0;
            if (context.Request["inPrice"] != null)
            {
                inPrice = double.Parse(context.Request["inPrice"].ToString());
            }

            double outPrice = double.Parse(context.Request["outPrice"].ToString());
            string remark = "";
            if (context.Request["remark"] != null)
                remark = context.Request["remark"].ToString();
            string fileDir;//图片文件的上传的路径
            string filename;//文件名
            if (context.Request.Files.Count > 0)//判断用户是否上传了文件
            {
                HttpPostedFile file = context.Request.Files[0];
                //得到档的扩展名(包含.)
                string ext = Path.GetExtension(file.FileName);
                if (file.ContentType == "image/jpeg" || file.ContentType == "image/jpg")
                {
                    Random ran = new Random();
                    filename = DateTime.Now.ToString("yyyyMMddhhmmss") + ran.Next(100, 1000) + ext;//给文件取名
                    fileDir = context.Server.MapPath("/image/" + u.Userid);//用户文件夹的物理路径（绝对路径）
                    fileDir = fileDir + "/" + filename;//档的完整名称
                    file.SaveAs(fileDir);//保存档到服务器
                    Product p = new Product();
                    p.Name = name;
                    p.CategroyId = categoryId;
                    p.Desn = desn;
                    p.UserId = u.Userid;
                    p.CreateDate = DateTime.Now;
                    p.SellInDate = sellIndate;
                    p.Quantity = quantity;
                    p.Unit = unit;
                    p.Upper = upper;
                    p.Lower = lower;
                    p.InPrice = inPrice;
                    p.OutPrice = outPrice;
                    p.Picture = "/" + u.Userid + "/" + filename;
                    p.Remark = remark;
                    //ProductBLL bll = new ProductBLL();
                    //bll.addProduct(p);
                    ProdcutBLL bll = new ProdcutBLL();
                    bll.AddProduct(p);
                    context.Response.Write("资料保存成功！");
                }
            }
            else
            {

                context.Response.Write("请选择要上传图片!");
            }


        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}