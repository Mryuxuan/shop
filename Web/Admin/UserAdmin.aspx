<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="UserAdmin.aspx.cs" Inherits="Web.Admin.UserAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../js/jquery-1.8.3.js"></script>
    <script type="text/javascript" >
        $(function () {
            $('#userInfo').datagrid({
                title: '用户信息列表',
                height: 400,
                loadMsg: "正在加载，请稍等...",
                striped: true,
                fitColumns: true,
                pagination: true,
                width:1164,
                
                pageSize: 4,//每页显示的记录条数，默认为10           
                pageList: [2,4, 5, 8, 50],//可以设置每页记录条数的列表  
                
                url: '../command/getUserInfo.ashx?type=show',//查看收件箱内容

                columns: [[
                    { field: 'UserName', title: '用户名' },
                    { field: 'RealName', title: '真实姓名' },
                    { field: 'Password', title: '密码' },
                    { field: 'sex', title: '性别' },
                    { field: 'birthday', title: '出生年月' },
                    { field: 'edu', title: '教育程度' },
                    { field: 'career', title: '职业' },
                     { field: 'Address', title: '家庭地址' },
                     { field: 'IdCard', title: '身份证' },
                     { field: 'Phone', title: '电话' },
                     { field: 'Mobile', title: '电子信箱' },
                     { field: 'CreateDate', title: '注册日期' },
                     { field: 'Status', title: '状态' },
                     { field: 'RoleName', title: '角色' },
                     { field: 'Remark', title: '备注' },
                ]],
                singleSelect: true,
                rownumbers: true,//行号  
                
            });
            var p = $("#userInfo").datagrid("getPager");
            $(p).pagination({
                beforePageText: '第',//页数文本框前显示的汉字           
                afterPageText: '页    共 {pages} 页',
                displayMsg: '当前显示 {from} - {to} 条记录   共 {total} 条记录'

            });
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table id="userInfo"></table>
   
</asp:Content>
