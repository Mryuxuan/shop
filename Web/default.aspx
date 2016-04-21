<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Web._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>电子购物</title>
    <script src="js/jquery-1.8.3.js"></script>
    <link href="CSS/StyleSheet1.css" rel="stylesheet" />
    <script type="text/javascript">
        //定义一个函数 用户名文本框得到焦点时执行
        function gotFocus() {
            //得到用户名文本框
            if (document.getElementById("txtName").value == "请输入用户名") {
                //清空文本框的内容
                document.getElementById("txtName").value = "";
            }

        }
        function lostFocus() {
            if (document.getElementById("txtName").value == "") {
                document.getElementById("txtName").value = "请输入用户名";
            } 
        }
        //当鼠标划过标题时执行
        function showTab(num) {
            //设置当前鼠标划过的标题的背景
            document.getElementById("title" + num).className = "tdGotFocus";
            //显示和标题对应的div
            document.getElementById("content" + num).className = "active";
            //设置其它标题背景为白色，且让其它标题对应的div不显示
            for (var i = 1; i <= 4; i++) {
                if (i != num) {
                    document.getElementById("title" + i).className = "tdLostFocus";
                    document.getElementById("content" + i).className = "none";
                }
            }
        }
        $(function () {
            $('#btnOK').click(function () {
                $.post("command/loginCheck.ashx", {//post用户信息加密get附加用户名和密码
                    name: $('#txtName').val(),
                    pwd: $('#txtPwd').val()
                }, function (data) {
                    if (data == "1") {
                        $('#lblUserName').html($('#txtName').val());
                        $('#txtName').val("请输入用户名");
                        $('#txtPwd').val("");
                        alert("登录成功");
                    }       
                    else
                        alert("登录失败");

                });

            });
        });
    </script>

    <style>
        .none {
            display:none;
        }
        .active {
            display:block;
            padding-top:10px;
            border:3px solid #FF6600;
        }
        .tdGotFocus {
            background-image:url('image/bart.jpg');
        }
        .tdLostFocus {
            background-color:#FFFFFF;
        }
   A:link {
    text-decoration: none;
    color: #000000;
    font-size: 12px;
}
A:hover {
    color: #FF0000;
    text-decoration: underline;
     font-size: 12px;
}
A:visited {
    color: #3366FF;
     font-size: 12px;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 100%; height: 900px; top: 0px; left: 0px; position: absolute; text-align: center;">
    <center>
         <div style="width: 1200px; height: 900px">
             <div id="top" style="background-color:#bdb7b7; width: 1200px; height: 25px">
                 <asp:Label ID="lblUserName" runat="server" Font-Bold="True" Font-Size="16pt" ForeColor="Red"></asp:Label>
                 你好！欢乐购物欢迎你！用户名：<asp:TextBox ID="txtName" runat="server" Width="139px" onfocus="gotFocus()" onblur="lostFocus()">请输入用户名</asp:TextBox>
&nbsp;密码：<asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">登录</asp:LinkButton>
                 <input type="button" id="btnOK" value="登录" />
             </div>
             <div id="logo" style="background-color: #FFFFFF; width: 400px; height: 100px; float: left"><img src="image/logo.jpg" /></div>
             <div id="search" style="background-color: #ffFFff; width: 800px; height: 100px; float: right; text-align: left;">
                 <%--搜索条--%>
                 <table align="left" border="0" cellpadding="0" cellspacing="0"  style="padding: 0px; margin: 0px">
                     <tr>
                         <td id="title1" width="75" height="35" align="center" class="tdGotFocus" onmouseover="showTab(1)">宝贝</td>
                         <td id="title2" width="75" height="35" align="center" onmouseover="showTab(2)">店铺</td>
                         <td id="title3" width="75" height="35" align="center" onmouseover="showTab(3)">商城</td>
                         <td id="title4" width="75" height="35" align="center" onmouseover="showTab(4)">新闻</td>
                     </tr>
                 </table>
                 <div id="content1" class="active" align="left"  style="width: 600px; height: 40px; clear: both;"><asp:TextBox ID="TextBox1" runat="server" Width="348px">1</asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/image/search.jpg"></asp:ImageButton></div>
                 <div id="content2" class="none" align="left"  style="width: 600px; height: 40px; clear: both;"><asp:TextBox ID="TextBox2" runat="server" Width="348px">2</asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/image/search.jpg"></asp:ImageButton></div>
                 <div id="content3" class="none" align="left"  style="width: 600px; height: 40px; clear: both;"><asp:TextBox ID="TextBox3" runat="server" Width="348px">3</asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/image/search.jpg"></asp:ImageButton></div>
                 <div id="content4" class="none" align="left"  style="width: 600px; height: 40px; clear: both;"><asp:TextBox ID="TextBox4" runat="server" Width="348px">4</asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/image/search.jpg"></asp:ImageButton></div>
             </div>
             <%--<div id="menu" style="background-color:#bdb7b7; width: 1200px; height: 25px; clear: both">
                 <a href="addProduct.aspx">商品发布</a>

                 <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click"> 商品发布1</asp:LinkButton>
                 <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click"> 新闻管理</asp:LinkButton>
             </div>--%>
             <div id="left" style="background-color: #ffffff; width: 250px; height: 700px; float: left">
                 <table style="width: 239px" cellpadding="0" cellspacing="0" >
                     <tr>
                         <td class="tdTitle">今日特价</td>
                     </tr>
                     <tr>
                         <td>
                             <asp:DataList ID="DataList1" runat="server" DataKeyField="productId" OnItemCommand="DataList1_ItemCommand">
                                 <ItemTemplate>
                                     <table style="width:100%;">
                                         <tr>
                                             <td colspan="2" align="left" class="auto-style2"><asp:HyperLink ID="HyperLink1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"name") %>' NavigateUrl='<%# "productInfo.aspx?id="+DataBinder.Eval(Container.DataItem,"productId") %>'></asp:HyperLink></td>
                                           
                                         </tr>
                                         <tr>
                                             <td rowspan="4">
                                                 <asp:ImageButton ID="ImageButton5" runat="server" Height="95px" Width="103px" CommandName="select" ImageUrl='<%# "image"+DataBinder.Eval(Container.DataItem,"picture") %>' />
                                             </td>
                                             <td>原价：<asp:Label ID="Label1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"outprice") %>'></asp:Label>
                                             </td>
                                            
                                         </tr>
                                         <tr>
                                             <td class="auto-style1">现价：<asp:Label ID="Label2" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"inPrice") %>'></asp:Label>
                                             </td> 
                                         </tr>
                                          <tr>
                                             <td>卖家：<asp:Label ID="Label3" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"username") %>'></asp:Label>
                                              </td> 
                                         </tr>
                                          <tr>
                                             <td>
                                                 <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/image/buy.jpg" CommandName="buy" />
                                              </td> 
                                         </tr>
                                     </table>
                                 </ItemTemplate>
                             </asp:DataList>  
                         </td>
                     </tr>
                 </table>

             </div>
             <div id="main" style="width: 650px; height: 700px; float: left; background-color: #ffffff;">
                 <script type="text/javascript">
                     var swf_width = 650;//动画的宽度
                     var swf_height = 200;//动画的高度
                     var config = '3|0xffffff|0x0099ff|50|0xffffff|0xff0000|0x000000';
                     //-- config 参数设置 -- 自动播放时间(秒)|文字颜色|文字背景色|文字背景透明度|按键数字颜色|当前按键颜色|普通按键色彩 --
                     var files = 'image/001.jpg|image/002.jpg|image/003.jpg|image/004.jpg|image/005.jpg';//轮换显示的图片名称
                     var links = 'image/001.jpg|image/002.jpg|image/003.jpg';//单击图片时，链接的位置
                     var texts = '||';
                     document.write('<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" width="' + swf_width + '" height="' + swf_height + '">');
                     document.write('<param name="movie" value="image/focus.swf" />');
                     document.write('<param name="quality" value="high" />');
                     document.write('<param name="menu" value="false" />');
                     document.write('<param name=wmode value="opaque" />');
                     document.write('<param name="FlashVars" value="config=' + config + '&bcastr_flie=' + files + '&bcastr_link=' + links + '&bcastr_title=' + texts + '" />');
                     document.write('<embed src="image/focus.swf" wmode="opaque" FlashVars="config=' + config + '&bcastr_flie=' + files + '&bcastr_link=' + links + '&bcastr_title=' + texts + '& menu="false" quality="high" width="' + swf_width + '" height="' + swf_height + '" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" />');
                     document.write('</object>');
                 </script>
                 <table width="100%" cellpadding="0" cellspacing="0"  >
                     <tr class="tdTitle">
                         <td>热销商品</td>
                     </tr>
                      <tr>
                         <td>
                            <asp:DataList ID="DataList2" runat="server" DataKeyField="productId" RepeatColumns="4" RepeatDirection="Horizontal" OnItemCommand="DataList2_ItemCommand">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton7" runat="server" Height="140px" ImageUrl='<%# "image"+DataBinder.Eval(Container.DataItem, "picture") %>' Width="142px" CommandName="select" />
                                    <br />
                                    <br />
                                    <asp:HyperLink ID="HyperLink2" runat="server" Text='<%# bind("name") %>' NavigateUrl='<%# "productInfo.aspx?id="+DataBinder.Eval(Container.DataItem,"productId") %>'></asp:HyperLink>
                                    <br />
                                    <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" Text='<%# bind("outprice") %>'></asp:Label>
                                    元
                                </ItemTemplate>
                             </asp:DataList>                  
                    
                         </td>
                     </tr>
                 </table>
             </div>
             <div id="right" style="background-color: #FFffff; width: 300px; height: 700px; float: right">
                 <table width="100%" cellpadding="0" cellspacing="0">
                     <tr>
                         <td align="left" class="tdTitle">网站公告</td>
                     </tr>
                      <tr>
                         <td><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
                     </tr>
                      <tr>
                         <td align="left" class="tdTitle" style="border-left-style: solid; border-left-width: 1px; border-left-color: #FFFFFF">网站新闻</td>
                     </tr>
                      <tr>
                         <td>
                           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" GridLines="None" ShowHeader="False" Width="270px" ShowFooter="True">
                               <Columns>
                                   <asp:TemplateField>
                                       <FooterTemplate>
                                           <asp:HyperLink ID="HyperLink3" runat="server" ImageUrl="~/image/more.gif" NavigateUrl="AllNews.aspx">HyperLink</asp:HyperLink>
                                       </FooterTemplate>
                                       <ItemTemplate>
                                           <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"desn").ToString().Length>20?DataBinder.Eval(Container.DataItem,"desn").ToString().Substring(0,17)+"...":DataBinder.Eval(Container.DataItem,"desn") %>' NavigateUrl='<%# "DispNews.aspx?id="+DataBinder.Eval(Container.DataItem,"newsid").ToString() %>' ToolTip='<%# DataBinder.Eval(Container.DataItem ,"desn") %>'></asp:HyperLink>
                                       </ItemTemplate>
                                   </asp:TemplateField>
                               </Columns>
                               <FooterStyle HorizontalAlign="Right" />
                               <RowStyle HorizontalAlign="Left" />
                             </asp:GridView>
                         </td>
                        
                        
                     </tr>
                     <tr> <td align="left" class="tdTitle">新品推荐</td></tr>
                     <tr><td><asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" GridLines="None" ShowFooter="True" ShowHeader="False" Width="264px">
                         <Columns>
                             <asp:TemplateField>
                                 <FooterTemplate>
                                     <asp:HyperLink ID="HyperLink4" runat="server" ImageUrl="~/image/more.gif" NavigateUrl="~/AllProduct.aspx">HyperLink</asp:HyperLink>
                                 </FooterTemplate>
                                 <ItemTemplate>
                                     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "productInfo.aspx?id="+DataBinder.Eval(Container.DataItem,"productId") %>' Text='<%# DataBinder.Eval(Container.DataItem,"name").ToString().Length>20?DataBinder.Eval(Container.DataItem,"name").ToString().Substring(0,17)+"...":DataBinder.Eval(Container.DataItem,"name") %>'></asp:HyperLink>
                                 </ItemTemplate>
                             </asp:TemplateField>
                         </Columns>
                         <FooterStyle HorizontalAlign="Right" />
                         <RowStyle HorizontalAlign="Left" />
                         </asp:GridView></td></tr>
                      
                          
                 </table>

             </div>
             <div id="foot" style="background-color: #bdb7b7; width: 1200px; height: 30px; clear: both">
                 九江职业技术学院（2015）
             </div>
         </div>

    </center>
    </div>
    </form>
</body>
</html>
