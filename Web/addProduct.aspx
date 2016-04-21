<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addProduct.aspx.cs" Inherits="Web.SPTJ" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="easyui/themes/default/easyui.css" rel="stylesheet" />
    <script src="easyui/jquery.min.js"></script>
    <script src="easyui/jquery.easyui.min.js"></script>
    <script src="easyui/easyui-lang-zh_CN.js"></script>
    <link href="kindeditor/themes/default/default.css" rel="stylesheet" />
    <link href="kindeditor/plugins/code/prettify.css" rel="stylesheet" />
    <script src="kindeditor/kindeditor.js"></script>
    <script src="kindeditor/lang/zh_CN.js"></script>
    <script src="kindeditor/plugins/code/prettify.js"></script>
    <script type="text/javascript">
        $(function () {
            //<a href="command/addProduct.ashx">command/addProduct.ashx</a>
            $("#form1").form({
                url: "command/addProduct.ashx",
                onSubmit: function () {
                    return $("#form1").form('validate')
                },
                success: function (data) {
                    alert(data)
                }
            });

            $('#ParentType').combobox({
                url: 'command/getCategory.ashx?id=1',
                valueField: 'CategoryID',
                textField: 'Desn',
                panelHeight: 'auto',
                editable: false,
                required: true,
                onChange: function (newValue, oldValue) {
                    $.get(
                        'command/getCategory.ashx', {
                            id: newValue
                        }, function (data) {
                            $('#categoryType').combobox('clear').combobox('loadData', data);
                        }, 'json'
                        )
                }
            });
            $('#categoryType').combobox({
                url: 'command/getCategory.ashx?id=1',
                valueField: 'CategoryID',
                textField: 'Desn',
                panelHeight: 'auto',
                editable: false,
                required: true
            })
        });
       
        KindEditor.ready(function (K) {
            var editor1 = K.create('#desn', {
                cssPath: 'kindeditor/plugins/code/prettify.css',
                uploadJson: 'kindeditor/asp.net/upload_json.ashx',
                fileManagerJson: 'kindeditor/asp.net/file_manager_json.ashx',
                allowFileManager: true,
                afterCreate: function () {
                    var self = this;
                    K.ctrl(document, 13, function () {
                        self.sync();
                        K('form[name=form1]')[0].submit();
                    });
                    K.ctrl(self.edit.doc, 13, function () {
                        self.sync();
                        K('form[name=form1]')[0].submit();
                    });
                }
            });
            prettyPrint();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="100%" cellpadding="0" cellspacing="0">
        <tr>
            <td colspan="3" align="left" class="title">当前位置<img alt="" class="auto-style1" src="image/rightArrow.gif" />商品添加</td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">商品名称：</td>
         <td class="tdRight">
            <input class="easyui-textbox" type="text" name="productName"  data-options="required:true"></input>
              <%--data-options="prompt:'请输入商品名称...',
                  框内信息
                  required:true,missingMessage:'商品名必须输入！'"--%>
            <!-- <input class="easyui-textbox" style="width:200px;height:24px" data-options="prompt:'输入商品名称...',required:true,missingMessage:'商品名称必须输入！'" />-->
             
            </td>
        </tr>
        
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">商品类别：</td>
         <td class="tdRight">
             商品大类：<%--<input class="easyui-combobox" name="language" data-options="
					url:'command/getCategory.ashx?id=1',
					method:'get',
					valueField:'CategoryID',
					textField:'Desn',
					panelHeight:'auto'
			">--%>
             <input class="easyui-combobox" id="ParentType" name="ParentType" />
             选择小类：<input class="easyui-combobox" id="categoryType" name="categoryId" />
             
            </td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">商品描述：</td>
         <td class="tdRight">
            <textarea id="desn" name="desn" cols="100" rows="8" style="width:700px;height:200px;visibility:hidden;"></textarea>
             &nbsp;</td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">有效期：</td>
         <td class="tdRight">
             <input class="easyui-datebox" name="sellIndate"></input>
         </td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">单位：</td>
         <td class="tdRight">
             <select class="easyui-combobox" name="unit" data-options="required:true,panelHeight:'auto'"  style="width:200px;">
                    <option value="件">件</option>
		            <option value="个">个</option>
		            <option value="本">本</option>
		            <option value="袋">袋</option>
		            <option value="斤">斤</option>
		            <option value="克">克</option>
		            <option value="包">包</option>
	         </select>

             &nbsp;</td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">数量：</td>
         <td class="tdRight">
             <input class="easyui-numberbox" name="quantity" data-options="required:true" value="10">

             &nbsp;</td>
        </tr>
        <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">最大库存量：</td>
         <td class="tdRight">
             <input class="easyui-numberbox" data-options="required:true" name="upper">
             &nbsp;</td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">最小库存量：</td>
         <td class="tdRight">
             <input class="easyui-numberbox" data-options="required:true" name="lower">
             &nbsp;</td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">进货价格：</td>
         <td class="tdRight">
            <input class="easyui-numberbox" data-options="precision:2,required:true" name="inPrice">

             &nbsp;</td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">卖出价格：</td>
         <td class="tdRight">
            <input class="easyui-numberbox" data-options="precision:2,required:true" name="outPrice">

             &nbsp;</td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">图片：</td>
         <td class="tdRight">
             <input class="easyui-filebox" name="file1" data-options="prompt:'请选择上传的图片...'" style="width:500px">
             &nbsp;</td>
        </tr>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">备注：</td>
         <td class="tdRight">
             <input class="easyui-textbox" name="remark" data-options="multiline:true" style="width:500px;height:100px">
             &nbsp;</td>
        </tr>
         <%--<tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">&nbsp;</td>
         <td class="tdRight" style="text-align:center">
             <a href="#" class="easyui-linkbutton c3" style="width:120px">提交</a>

             &nbsp;</td>
        </tr>--%>
         <tr>
         <td width="150"></td>
         <td class="tdMiddle" width="200">&nbsp;</td>
         <td class="tdRight" style="text-align:center">
            <input type="submit" class="easyui-linkbutton" value="提  交"></input>
         </td>
        </tr>
    </table>
</asp:Content>
