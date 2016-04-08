<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table width="100%" cellpadding="0" cellspacing="0">
      <tr>
          <td colspan="3" class="title">当前位置<img alt="" class="auto-style1" src="image/rightArrow.gif" />用户注册</td>
         
      </tr>
      <tr>
          <td width="250"></td>
          <td class="tdMiddle">用户名：</td>
          <td class="tdRight">
              <asp:TextBox ID="txtName" runat="server" Width="204px"></asp:TextBox>
              <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" OnClick="LinkButton1_Click">检测用户名是否可用！</asp:LinkButton>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" Display="Dynamic" ErrorMessage="用户名必须输入！" ForeColor="Red">*</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="用户名必须有6-10位字母、数字和下划线组成！" ForeColor="Red" ValidationExpression="\w{6,10}"></asp:RegularExpressionValidator>
          </td>
      </tr>
    <tr>
          <td width="200"></td>
          <td class="tdMiddle">真实姓名：</td>
          <td class="tdRight">
              <asp:TextBox ID="txtRealName" runat="server" Width="204px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtRealName" ErrorMessage="真实姓名必须输入！" ForeColor="Red">*</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtRealName" ErrorMessage="真实姓名由2个以上汉字组成！" ForeColor="Red" ValidationExpression="[\u4e00-\u9fa5]{2,}"></asp:RegularExpressionValidator>
          </td>
      </tr>
      <tr>
          <td width="200"></td>
          <td class="tdMiddle">密码：</td>
          <td class="tdRight">
              <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="204px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPwd" ErrorMessage="密码必须输入！" ForeColor="Red">*</asp:RequiredFieldValidator>
          </td>
      </tr>
      <tr>
          <td width="200" class="auto-style2"></td>
          <td class="tdMiddle">确认密码：</td>
          <td class="tdRight">
              <asp:TextBox ID="txtConfirmPwd" runat="server" TextMode="Password" Width="204px"></asp:TextBox>
              <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtConfirmPwd" ErrorMessage="两次输入的密码不一致！" ForeColor="Red"></asp:CompareValidator>
          </td>
      </tr>
      <tr>
          <td width="200"></td>
          <td class="tdMiddle">性别：</td>
          <td class="tdRight">
              <asp:RadioButtonList ID="rbSex" runat="server" Height="16px" RepeatDirection="Horizontal" style="margin-bottom: 0px" Width="236px">
                  <asp:ListItem Selected="True">男</asp:ListItem>
                  <asp:ListItem>女</asp:ListItem>
              </asp:RadioButtonList>
          </td>
      </tr>
      <tr>
          <td width="200"></td>
          <td class="tdMiddle">出生日期：</td>
          <td class="tdRight">
              <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
               <asp:DropDownList ID="ddlYear" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlYear_SelectedIndexChanged">
              </asp:DropDownList>
              年<asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMonth_SelectedIndexChanged">
              </asp:DropDownList>
              月<asp:DropDownList ID="ddlDay" runat="server">
              </asp:DropDownList>
              日</ContentTemplate></asp:UpdatePanel>
                  </td>
      </tr>
      <tr>
          <td width="200"></td>
          <td class="tdMiddle">教育程度：</td>
          <td class="tdRight">
              <asp:DropDownList ID="ddlEdu" runat="server">
                  <asp:ListItem>小学以下</asp:ListItem>
                  <asp:ListItem>初中</asp:ListItem>
                  <asp:ListItem>高中</asp:ListItem>
                  <asp:ListItem>大专</asp:ListItem>
                  <asp:ListItem>本科</asp:ListItem>
                  <asp:ListItem>硕士研究生及以上</asp:ListItem>
              </asp:DropDownList>
          </td>
      </tr>
      <tr>
          <td width="200"></td>
          <td class="tdMiddle">职业：</td>
          <td class="tdRight">
              <asp:DropDownList ID="ddlCareer" runat="server">
                  <asp:ListItem>无业游民</asp:ListItem>
                  <asp:ListItem>工人</asp:ListItem>
                  <asp:ListItem>学生</asp:ListItem>
                  <asp:ListItem>公司白领</asp:ListItem>
                  <asp:ListItem>农民</asp:ListItem>
              </asp:DropDownList>
          </td>
      </tr>
      <tr>
          <td width="200"></td>
          <td class="tdMiddle">地址：</td>
          <td class="tdRight">
              <asp:TextBox ID="txtAddress" runat="server" Width="362px"></asp:TextBox>
          </td>
      </tr>
       <tr>
          <td width="200" class="auto-style4"></td>
          <td class="tdMiddle">身份证：</td>
          <td class="tdRight">
              <asp:TextBox ID="txtIDCard" runat="server" Width="181px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtIDCard" ErrorMessage="身份证必须输入！" ForeColor="Red">*</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtIDCard" ErrorMessage="身份证格式输入错误！" ForeColor="Red" ValidationExpression="\d{17}[\d|X]|\d{15}"></asp:RegularExpressionValidator>
           </td>
      </tr>
       <tr>
          <td width="200"></td>
          <td class="tdMiddle">电话：</td>
          <td class="tdRight">
              <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
           </td>
      </tr>
       <tr>
          <td width="200"></td>
          <td class="tdMiddle">手机：</td>
          <td class="tdRight">
              <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPhone" ErrorMessage="手机必须输入！" ForeColor="Red">*</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtPhone" ErrorMessage="手机输入错误！" ForeColor="Red" ValidationExpression="1\d{10}"></asp:RegularExpressionValidator>
           </td>
      </tr>
      <tr>
          <td width="200"></td>
          <td class="tdMiddle">电子信箱：</td>
          <td class="tdRight">
              <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtEmail" ErrorMessage="电子信箱输入错误！" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
           </td>
      </tr>
      <tr>
          <td width="200" style=" border-bottom: 1px solid #33CC33"></td>
          <td class="tdMiddle">备注：</td>
          <td class="tdRight">
              <asp:TextBox ID="txtRemark" runat="server" Height="107px" TextMode="MultiLine" Width="484px"></asp:TextBox>
           </td>
      </tr>
      <tr>
          <td width="200"></td>
          <td colspan="2" style="text-align:center;height:40px" >
              <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
              <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" />
           </td>
      </tr>
  </table>

</asp:Content>
