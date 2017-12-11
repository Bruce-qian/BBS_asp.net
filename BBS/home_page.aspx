<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home_page.aspx.cs" Inherits="home_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
        
          html, body ,div 
         {  
        padding: 0;  
        margin: 0;  
        height: 100%;  

          }  
        .head {
        width:100%;
        height:10%;
        margin-left:auto;
        margin-right:auto;
        }
        .left {
            clear:both;
        width:10%;
        height:500px;
       margin-bottom:0px;
       margin-top:0px;
        
        }
        .right {
        width:90%;
        height:500px;
       margin-bottom:0px;
       margin-top:0px;
        
        }
        .headleft {
            width:30%;
            height:100%;
            
            margin-bottom:0px;
            margin-top:0px;
            
        }
        .headright {
        width:30%;
        height:100%;
        margin-bottom:0px;
       margin-top:0px;
       
       
        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="head" id ="head">
    <!--page head-->
        <div class="headleft" style="float:left">
            <iframe id="headfrm"  runat="server" width="100%" height="100%"><!--head页面-->
            </iframe>
        </div>
        <div class="headright" style="float:right">
         <table style="width:100%">
            <tr>
                <td> 
                    <asp:Button ID="btnSet" runat="server" Text="设置" />
                </td>
                <td> 
                    <asp:Button ID="btnQuit" runat="server" Text="退出" OnClick="btnQuit_Click" />
                </td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="登陆" OnClick="btnLogin_Click" />
                </td>
                <td>
                    <asp:Button ID="btnPost" runat="server" Text="发帖" OnClick="btnPost_Click" />
                </td>
            </tr>
        </table>
    
        </div>
    </div>
    <div class="left" style="float:left" id ="col1">
        <!--left-->
        <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
            <Nodes>
                <asp:TreeNode Text="C++" Value="C++"></asp:TreeNode>
                <asp:TreeNode Text="JAVA" Value="JAVA"></asp:TreeNode>
                <asp:TreeNode Text="C#" Value="C#"></asp:TreeNode>
            </Nodes>
        </asp:TreeView>
    </div>
    <div class="right" style ="float:right" id="col2">
        <!--right-->
        <iframe id="rightfrm"  runat="server" width="100%" height="100%">
            <!--右边内容区-->
        </iframe>
    </div>
    </form>
    <script>
    total = document.body.clientHeight;//获取body的高度
    colHeight = total - document.getElementById("head").offsetHeight;//去掉head的高度
    document.getElementById("col1").style.height = colHeight + "px";
    document.getElementById("col2").style.height = colHeight + "px";
</script>
</body>
</html>
