using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modal;
using DAL;
using System.Data;
namespace BLL
{
   public   class ProdcutBLL
    {
       ProductDAL dal = new ProductDAL();
          //定义一个函数，根据sql语句得到商品的信息
       public DataSet getProduct(string sql)
       {
           return dal.getProduct(sql);
       }
         //定义一个方法，根据商品编号得到商品信息
       public Product getProductById(int productId)
       {
           return dal.getProductById(productId);

       }
         //定义一个方法，添加一件商品
       public void AddProduct(Product p)
       {
           dal.AddProduct(p);
       }
    }
}
