<%@ Page Language="C#" AutoEventWireup="true" CodeFile="essay.aspx.cs" Inherits="essay" %>

<!DOCTYPE html>
<!--显示文章的详细内容-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!--显示文章标题-->
        <asp:Label ID="labTitle" runat="server" Text="labTitle"></asp:Label>
    
    </div>
        <div>
            <!--显示文章内容-->

            <asp:Label ID="labContent" runat="server" Text="空"></asp:Label>


            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="删除" />


        </div>
        <div>
            <asp:TextBox ID="txtConment" runat="server" Height="32px" Width="214px"></asp:TextBox>

            <asp:Button ID="btnOk" runat="server" Text="评论" OnClick="btnOk_Click" />

        </div>
        <div>
            <!--用来显示评论-->
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

        </div>
    </form>
</body>
</html>
