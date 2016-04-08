<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addProduct.aspx.cs" Inherits="Web.addProduct" %>
<%@ Register assembly="CuteEditor" namespace="CuteEditor" tagprefix="CE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 25px;
            height: 11px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <table width="100%" cellpadding="0" cellspacing="0">
        <tr>
            <td colspan="3" align="left" class="title">当前位置<img alt="" class="auto-style1" src="image/rightArrow.gif" />商品添加</td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">商品名称：</td>
         <td class="tdRight">
             <asp:TextBox ID="txtName" runat="server" Width="253px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="商品名称不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">商品类别：</td>
         <td class="tdRight">
             <asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate>
             <asp:DropDownList ID="ddlType1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlType1_SelectedIndexChanged">
             </asp:DropDownList>
             选择子类：<asp:DropDownList ID="ddlType2" runat="server">
             </asp:DropDownList>
                 </ContentTemplate></asp:UpdatePanel> 
            </td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">商品描述：</td>
         <td class="tdRight">
             <CE:Editor ID="Editor1" runat="server">
             </CE:Editor>
            </td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">有效期：</td>
         <td class="tdRight">
             <asp:TextBox ID="txtDay" runat="server" Width="98px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDay" ErrorMessage="有效期不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
             <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtDay" ErrorMessage="有效期必须为整数！" ForeColor="Red" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">单位：</td>
         <td class="tdRight">
             <asp:DropDownList ID="ddlUnit" runat="server">
                 <asp:ListItem>件</asp:ListItem>
                 <asp:ListItem>本</asp:ListItem>
                 <asp:ListItem>个</asp:ListItem>
                 <asp:ListItem>包</asp:ListItem>
                 <asp:ListItem>条</asp:ListItem>
             </asp:DropDownList>
            </td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">数量：</td>
         <td class="tdRight">
             <asp:TextBox ID="txtNum" runat="server" Width="102px"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNum" ErrorMessage="商品数量不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">最大库存量：</td>
         <td class="tdRight">
             <asp:TextBox ID="txtUpper" runat="server" Width="69px"></asp:TextBox>
            </td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">最小库存量：</td>
         <td class="tdRight">
             <asp:TextBox ID="txtLower" runat="server" Width="66px"></asp:TextBox>
             </td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">进货价格：</td>
         <td class="tdRight">
             <asp:TextBox ID="txtInPrice" runat="server"></asp:TextBox>
             <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtInPrice" ErrorMessage="进货价格必须为实数！" ForeColor="Red" Operator="DataTypeCheck" Type="Double"></asp:CompareValidator>
             </td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">卖出价格：</td>
         <td class="tdRight">
             <asp:TextBox ID="txtOutPrice" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtOutPrice" ErrorMessage="商品价格不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
             </td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">图片：</td>
         <td class="tdRight">
             <asp:FileUpload ID="FileUpload1" runat="server" Width="384px" />
             </td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">备注：</td>
         <td class="tdRight">
             <asp:TextBox ID="txtRemark" runat="server" Height="101px" TextMode="MultiLine" Width="504px"></asp:TextBox>
             </td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">&nbsp;</td>
         <td class="tdRight">
             <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">提交</asp:LinkButton>
             </td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">&nbsp;</td>
         <td class="tdRight"></td>
        </tr>
    </table>
</asp:Content>
