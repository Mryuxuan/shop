<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="NewsInfo.aspx.cs" Inherits="Web.Admin.NewsInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../js/jquery-1.8.3.js"></script>
    <script type="text/javascript"> 
        var op;
        var newId;
        var obj = {
            search: function () {
                $('#newsInfo').datagrid('load', {
                    Desn: $.trim($('#desn').val())
                });
            },
            del: function () {
                var rows = $('#newsInfo').datagrid('getSelections');
                if (!rows || rows.length == 0)
                {
                    $.message.alert('提示', '请选择要删除的数据', 'info');
                    return;
                }
                $.messager.confirm('提示', '确认删除？', function (r) {
                    if (!r)
                    { return; }
                    var ids="";
                    for (var i = 0; i < rows.length; i++)
                        if (i == 0)
                            ids = rows[i].NewsID;
                        else
                            ids = ids + "," + rows[i].NewsID;
                    $.ajax({
                        url: '../command/getNewsInfo.ashx?type=del',
                        type: 'post',
                        data: {
                            id: ids
                        },
                        beforeSend: function () {
                            $('#newsInfo').datagrid('loading');
                        },
                        success: function (data) {
                            $('#newsInfo').datagrid('loaded');
                            $('#newsInfo').datagrid('load');
                            $('#newsInfo').datagrid('unselectAll');
                            $.messager.show({
                                title: '提示',
                                msg: data + "个新闻被删除",
                                timeout: 3000,
                                showtype: 'slide'
                            })
                        }
                    })
                });
               
            },
            add: function () {
                $('#dlg').dialog('open').dialog('setTitle', '添加');
                $('#frm').form('clear');
                op = 'add';
            },
            edit: function () {
                var row = $('#newsInfo').datagrid('getSelected');
                if (row) {
                    $('#dlg').dialog('open').dialog('setTitle', '编辑');
                    newId = row.NewsID;
                    $('#txtDesn').val(row.Desn);
                    $('#txtBody').val(row.Body);
                    op = 'edit';
                }
                else {
                    $.messager.alert("提示", "请选择数据");
                }
            },
            close: function () {
                $('#dlg').dialog('close');
            },
            save: function () {
                $.ajax({
                    url: '../command/getNewsInfo.ashx?type=' + op,
                    type: 'post',
                    data: {
                        id: newId,
                        desn: $('#txtDesn').val(),
                        body:$('#txtBody').val()
                    },
                    beforesend: function () {
                        $('#newsInfo').datagrid('loading');
                    },
                    success: function (data) {
                        $('#newsInfo').datagrid('loaded');
                        $('#newsInfo').datagrid('load');
                        $('#newsInfo').datagrid('unselectAll');
                        $.messager.show({
                            title: '提示',
                            msg: '1条新闻被' + data + '！',
                            timeout: 3000,
                            showType: 'slide'

                        });
                        $('#dlg').dialog('close');
                    }
                    

                })

            }
        };
        $(function () {           

            $('#search').click(function () {
                obj.search();
            })
            $('#del').click(function () {
                obj.del();
            })
            $('#newsInfo').datagrid({
                title: '新闻列表',
                height: 400,
                loadMsg: '正在加载，请稍后......',
                url: '../command/getNewsInfo.ashx?type=show',
                striped: true,
                columns: [[
                    {field:'ck',checkbox:true},
                    { field: 'NewsID', title: '新闻编号',hidden:true },
                    { field: 'Desn', title: '新闻标题',width:250 },
                    { field: 'Body', title: '新闻内容',width:400 },
                    { field: 'Date', title: '发布日期'},
                    { field: 'UserName', title: '作者' }
                    
                ]],
                singleSelect: true,
                rownumbers: true,
                pageSize: 5,
                pageList: [5, 10, 20],
                pagination: true,
                width: 1164,
                toolbar: '#tb',
                idField:'NewsID'
            })
            var p = $('#newsInfo').datagrid('getPager');
            $(p).pagination({
                beforePageText: '第',
                afterPageText: '页  共{pages}页',
                displayMsg: '当前显示 {from} - {to} 条记录   共 {total} 条记录'
            })          
        })       
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="newsInfo">
        <div id="tb">
            <div>
                <a href="#" class="easyui-linkbutton" iconCls="icon-add" plain="true" onclick="obj.add()">添加</a>
                <a href="#" class="easyui-linkbutton" iconCls="icon-edit" plain="true" onclick="obj.edit()">编辑</a>
                <a href="#" class="easyui-linkbutton" iconCls="icon-remove" plain="true" id="del">删除</a>
            </div>
            <div style="padding:0 0 0 10px">
                请输入新闻标题<input class="easyui-textbox" id="desn" data-options="prompt:'请输入新闻标题...'" style="width:200px;height:25px">
                <a href="#" class="easyui-linkbutton" iconCls="icon-search" plain="true" id="search">查询</a>
            </div>
        </div>
    </table>
    <div id="dlg" class="easyui-dialog" title="新闻添加" style="width:750px;height:500px;padding:10px 20px" data-options="closed:true,iconCls:'icon-edit'">
<div class="ftitle">
    <b>添加新闻</b>
    <hr />
</div>
<form id="frm" method="post">
    <table>
        <tr class="fitem">
            <td style="width:100px">新闻标题</td>
            <td style="width:500px"><input type="text" class="easyui-validatebox textbox" name="desn" id="txtDesn" size="40" data-options="required:true" /></td>

        </tr>
        <tr>
            <td>新闻内容</td>
            <td><textarea id="txtBody" name="body" cols="70" rows="20"></textarea></td>

        </tr>

    </table>
     <div id="dlg-buttons" style="text-align:center;padding:50px 20px 30px  0">
        <a href="javascript:void(0)"class="easyui-linkbutton" data-options="iconCls:'icon-ok'"onclick="obj.save()">确定</a>
        <a href="javascript:void(0)"class="easyui-linkbutton" data-options="iconCls:'icon-cancel'"onclick="obj.close()">关闭</a>
     </div>

</form>
</div>
</asp:Content>
