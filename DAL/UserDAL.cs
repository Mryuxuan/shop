using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modal;
using System.Data.OleDb;
namespace DAL
{
   public  class UserDAL
    {
       database db;
       //构造函数
       public UserDAL()
       {
           db = new database();//打开数据库连接
       }
      //定义一个方法，根据用户名得到用户的相关信息，返回为Users实体
       public Users getUserByName(string username)
       {
           Users u = new Users();
           string sql = "select * from users where username='" + username + "'";
           OleDbDataReader dr = db.GetDataReader(sql);//执行sql命令，返回DataReader对象
           if (dr.Read())//读取数据
           {
               u.Userid = int.Parse(dr["userId"].ToString());
               u.Username = dr["username"].ToString();
               u.Realname = dr["realname"].ToString();
               u.Password = dr["password"].ToString();
               u.Sex = dr["sex"].ToString();
               if (dr["birthday"].ToString() != "")
                   u.Birthday = DateTime.Parse(dr["birthday"].ToString());
               u.Edu = dr["edu"].ToString();
               u.Career = dr["career"].ToString();
               u.Address = dr["address"].ToString();
               u.IdCard = dr["idcard"].ToString();
               u.Phone = dr["phone"].ToString();
               u.Mobile = dr["mobile"].ToString();
               u.Email = dr["email"].ToString();
               u.CreateDate = DateTime.Parse(dr["createdate"].ToString());
               u.Status = Boolean.Parse(dr["status"].ToString());
               u.RoleId = int.Parse(dr["roleid"].ToString());
               u.Remark = dr["remark"].ToString();
               return u;
           }
           else//没有数据读取
               return null;


       }
       //定义一个方法检测用户名是否已经存在
       public Boolean UserNameIsExist(string username)
       {
           string sql = "select * from users where username='" + username + "'";
           DataSet ds = db.GetDataSet(sql);
           if (ds.Tables[0].Rows.Count > 0)
               return true;
           else
               return false;

       }
       //定义一个方法来添加一个用户
       public void AddUser(Users u)
       {
           DataRow dr;//数据行
           string sql = "select top 1 * from users";
           DataSet ds = db.GetDataSet(sql);
           dr = ds.Tables[0].NewRow();//新建的数据行的结构和表Users表一致
           //给dr数据行的列赋值
           dr["username"] = u.Username;
           dr["realname"] = u.Realname;
           dr["password"] = u.Password;
           dr["sex"] = u.Sex;
           dr["birthday"] = u.Birthday;
           dr["edu"] = u.Edu;
           dr["career"] = u.Career;
           dr["address"] = u.Address;
           dr["idcard"] = u.IdCard;
           dr["phone"] = u.Phone;
           dr["mobile"] = u.Mobile;
           dr["email"] = u.Email;
           dr["createDate"] = u.CreateDate;
           dr["status"] = u.Status;
           dr["roleId"] = u.RoleId;
           dr["remark"] = u.Remark;
           ds.Tables[0].Rows.Add(dr);//把数据行添加到数据集
           db.UpdateDataset(sql, ds);
           
       }
       public DataSet getAllUser()
       {
           string sql = "select * from users";
           DataSet ds = db.GetDataSet(sql);
           return ds;

       }
       //分页
       public DataSet getAllUserInfo(int pageNo, int pageSize)
       {
           string sql = "select top " + pageSize + " * from V_users where userId not in(select top " + (pageNo - 1) * pageSize + " UserId  from V_users  order by UserId desc)  order by UserId desc";
           DataSet ds = db.GetDataSet(sql);
           return ds;
       }
       //读出所有的用户个数
       public int getAllUsersCount()
       {
           string sql = "select  * from V_users ";
           DataSet ds = db.GetDataSet(sql);
           return ds.Tables[0].Rows.Count;

       }

    }
}
