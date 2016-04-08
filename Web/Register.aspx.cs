using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Modal;
using System.Data;
namespace Web
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)//页面为首次加载
            {
                int year, month, day;
                //添加年份
                for (year = 1900; year <= DateTime.Now.Year; year++)
                    ddlYear.Items.Add(year.ToString());
                //添加月份
                for (month = 1; month <= 12; month++)
                    ddlMonth.Items.Add(month.ToString());
                //添加月份的天数
                for (day = 1; day <= 31; day++)
                    ddlDay.Items.Add(day.ToString());
                ddlYear.SelectedIndex = 100;

            }

        }

        //根据用户选择的年和月，来确定月份的天数
        private void addDays()
        {
            int year, month, days=0;
            year = int.Parse(ddlYear.SelectedItem.Text);//用户选择的年份
            month = int.Parse(ddlMonth.SelectedItem.Text);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: days = 31; break;
                case 4:
                case 6:
                case 9:
                case 11: days = 30; break;
                case 2:
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                        days = 29;
                    else
                        days = 28;
                    break;
            }
            //清空天数
            ddlDay.Items.Clear();
            //添加新的天数
            for (int i = 1; i <= days; i++)
                ddlDay.Items.Add(i.ToString());

          }

        protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            addDays();
        }

        protected void ddlMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            addDays();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string username = txtName.Text.Trim();
            UserBLL bll=new UserBLL();
            if (bll.UserNameIsExist(username) == true)//存在
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('用户名已经存在，不能使用')", true);

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('用户名可以使用')", true);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //检测用户名是否已经存在
            string username;
            username = txtName.Text.Trim();
            UserBLL bll = new UserBLL();
            if (bll.UserNameIsExist(username) == true)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('用户名已经存在！')", true);
                return;

            }
            Users u = new Users();
            u.Username = username;
            u.Realname = txtRealName.Text.Trim();
            u.Password = txtPwd.Text.Trim();
            if (rbSex.SelectedIndex == 0)
                u.Sex = "男";
            else
                u.Sex = "女";
            u.Birthday = DateTime.Parse(ddlYear.SelectedItem.Text + "-" + ddlMonth.SelectedItem.Text + "-" + ddlDay.SelectedItem.Text);
            u.Career = ddlCareer.SelectedItem.Text;
            u.Edu = ddlEdu.SelectedItem.Text;
            u.Address = txtAddress.Text.Trim();
            u.IdCard = txtIDCard.Text.Trim();
            u.Phone =txtTel.Text.Trim();
            u.Mobile = txtPhone.Text.Trim();
            u.Email = txtEmail.Text.Trim();
            u.CreateDate = DateTime.Now;
            u.Status = true;
            u.RoleId = 3;
            u.Remark = txtRemark.Text;
            try
            {
                bll.AddUser(u);
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('注册成功！')", true);

            }
            catch (Exception ee)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "", "alert('注册失败！')", true);

            }
           

        }
    }
}