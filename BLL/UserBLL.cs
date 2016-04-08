using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modal;
using DAL;
using System.Data;
using System.Data.OleDb;
namespace BLL
{
  public   class UserBLL
    {
      //使用DAl对象
      UserDAL dal = new UserDAL();//访问数据库
      //定义一个方法getUserByName根据用户名，得到用户的相关信息
      public Users getUserByName(string username)
      {
          return dal.getUserByName(username);

      }
        //定义一个方法检测用户名是否已经存在
      public Boolean UserNameIsExist(string username)
      {
          return dal.UserNameIsExist(username);

      }
       //定义一个方法来添加一个用户
      public void AddUser(Users u)
      {
          dal.AddUser(u);

      }
      public DataSet getAllUser()
      {
          return dal.getAllUser();
      }
        //分页
      //分页读出用户的信息
      public DataSet getAllUserInfo(int pageNo, int pageSize)
      {
          return dal.getAllUserInfo(pageNo, pageSize);

      }
      //读出所有的用户个数
      public int getAllUsersCount()
      {
          return dal.getAllUsersCount();
      }

    }
}
