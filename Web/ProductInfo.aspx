<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductInfo.aspx.cs" Inherits="Web.ProductInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        .auto-style1 {
            height: 15px;
            width: 20px;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td colspan="3" align="left" class="title">当前位置<img alt="" class="auto-style1" src="image/rightArrow.gif" />商品信息</td>
           
        </tr>
        <tr>
            <td width="150" height="30">&nbsp;</td>
            <td width="200" rowspan="5">
                <asp:Image ID="Image1" runat="server" Height="161px" Width="162px" />
            </td>
            <td align="left">商品名称：<asp:Label ID="lblName" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td width="150" height="30">&nbsp;</td>
            <td align="left">商品卖家：<asp:Label ID="lblSell" runat="server"></asp:Label>
                <asp:HyperLink ID="HyperLink4" runat="server" ImageUrl="~/image/qq.jpg">HyperLink</asp:HyperLink>
            </td>
        </tr>
         <tr>
            <td width="150" ></td>
            <td  align="left">商品价格：<asp:Label ID="lblPrice" runat="server"></asp:Label>
             </td>
        </tr>
         <tr>
            <td width="150" height="30">&nbsp;</td>
            <td align="left">商品数量：<asp:Label ID="lblNum" runat="server"></asp:Label>
             </td>
        </tr>
         <tr>
            <td width="150" height="30">&nbsp;</td>
            <td align="left">买<asp:TextBox ID="txtNum" runat="server" Width="69px">1</asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="必须输入整数！" ControlToValidate="txtNum" Display="Dynamic" ForeColor="Red" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                 <asp:Label ID="lblUnit" runat="server" Text="Label"></asp:Label>
&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/buy1.jpg" OnClick="ImageButton1_Click" />
&nbsp;&nbsp;
                &nbsp;<asp:HyperLink ID="HyperLink5" runat="server" ImageUrl="~/image/cart.jpg" NavigateUrl="~/shopCar.aspx" Target="_blank">HyperLink</asp:HyperLink>
                &nbsp;
                <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/image/order.jpg" OnClick="ImageButton3_Click"  />
             </td>
        </tr>
         <tr>
            <td width="150" height="30">&nbsp;</td>
            <td colspan="2">
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
             </td>
        </tr>
    </table>
</asp:Content>
