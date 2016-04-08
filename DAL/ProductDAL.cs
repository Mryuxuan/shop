using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modal;
using System.Data;
using System.Data.OleDb;
namespace DAL
{
   public  class ProductDAL
    {
       database db;
       public ProductDAL()
       {
           db = new database();
       }
       //定义一个函数，根据sql语句得到商品的信息
       public DataSet getProduct(string sql)
       {
           DataSet ds;
           ds = db.GetDataSet(sql);
           return ds;

       }
       //定义一个方法把数据集中的行转换为Modal
       public Product DatasetToProduct(DataSet ds)
       {
           Product p = new Product();
           p.ProductId = int.Parse(ds.Tables[0].Rows[0]["productId"].ToString());
           p.Name = ds.Tables[0].Rows[0]["Name"].ToString();
           p.Desn = ds.Tables[0].Rows[0]["desn"].ToString();
           p.CreateDate = DateTime.Parse(ds.Tables[0].Rows[0]["createDate"].ToString());
           p.SellInDate = DateTime.Parse(ds.Tables[0].Rows[0]["SellIndate"].ToString());
           p.Unit = ds.Tables[0].Rows[0]["unit"].ToString();
           p.Quantity = int.Parse(ds.Tables[0].Rows[0]["quantity"].ToString());
           p.Upper = int.Parse(ds.Tables[0].Rows[0]["Upper"].ToString());
           p.Lower = int.Parse(ds.Tables[0].Rows[0]["Lower"].ToString());
           p.InPrice = double.Parse(ds.Tables[0].Rows[0]["Inprice"].ToString());
           p.OutPrice = double.Parse(ds.Tables[0].Rows[0]["outprice"].ToString());
           p.Picture = ds.Tables[0].Rows[0]["picture"].ToString();
           p.Remark = ds.Tables[0].Rows[0]["remark"].ToString();
           p.CategroyId = int.Parse(ds.Tables[0].Rows[0]["CategoryId"].ToString());
           p.Title = ds.Tables[0].Rows[0]["title"].ToString();
           p.ParentId = int.Parse(ds.Tables[0].Rows[0]["ParentId"].ToString());
           p.UserName = ds.Tables[0].Rows[0]["username"].ToString();
           p.RealName = ds.Tables[0].Rows[0]["realname"].ToString();
           p.UserId = int.Parse(ds.Tables[0].Rows[0]["userId"].ToString());
           return p;
       }
       //定义一个方法，根据商品编号得到商品信息
       public Product getProductById(int productId)
       {
           string sql = "select * from productView where productId=" + productId;
           DataSet ds = db.GetDataSet(sql);
           Product p = DatasetToProduct(ds);
           return p;
       }    
       //定义一个方法，添加一件商品
       public void AddProduct(Product p)
       {
           string sql = "select top 1 * from product";
           DataSet ds = db.GetDataSet(sql);
           //新建一个数据行
           DataRow dr = ds.Tables[0].NewRow();
           //设置改行各列的值
           dr["name"] = p.Name;//商品名称
           dr["CategoryId"] = p.CategroyId;//类别id
           dr["desn"] = p.Desn;
           dr["userid"] = p.UserId;
           dr["createDate"] = p.CreateDate;
           dr["sellIndate"] = p.SellInDate;
           dr["unit"] = p.Unit;
           dr["quantity"] = p.Quantity;
           dr["upper"] = p.Upper;
           dr["lower"] = p.Lower;
           dr["inprice"] = p.InPrice;
           dr["outprice"] = p.OutPrice;
           dr["picture"] = p.Picture;
           dr["remark"] = p.Remark;
           //把改行添加到数据集中
           ds.Tables[0].Rows.Add(dr);
           //用数据集来更新数据库
           db.UpdateDataset(sql, ds);

       }



    }
}
