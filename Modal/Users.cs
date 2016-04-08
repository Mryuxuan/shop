using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modal
{
  public   class Users
    {
        int userid;//用户号
        public int Userid//属性
        {
            get { return userid; }
            set { userid = value; }
        }
        string username;//用户名
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        string realname;//真实姓名

        public string Realname
        {
            get { return realname; }
            set { realname = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        DateTime birthday;

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        string edu;

        public string Edu
        {
            get { return edu; }
            set { edu = value; }
        }
        string career;

        public string Career
        {
            get { return career; }
            set { career = value; }
        }
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        string idCard;

        public string IdCard
        {
            get { return idCard; }
            set { idCard = value; }
        }
        string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        string mobile;  
        public string Mobile
        {
             get { return mobile; }
            set { mobile = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        DateTime createDate;

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        Boolean status;

        public Boolean Status
        {
            get { return status; }
            set { status = value; }
        }
        int roleId;

        public int RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        string remark;

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

  }
}
