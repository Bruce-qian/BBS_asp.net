<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Moderator.aspx.cs" Inherits="Moderator" %>

<!DOCTYPE html>
<!--版主申请页面-->
<!--版主申请按钮放在板块的上面，申请的时候把当前板块的代号发过去，并且要重新输入账号密码用来确认-->
<!--界面布局：用户名，密码，申请的板块以及确认按钮-->
<!--版主申请需要会员及以上权限，并且活跃度要高-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>请确认信息</td>
            </tr>
        </table>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td >
                <asp:Label ID="Label3" runat="server" Text="板块"></asp:Label>
            </td>
            <td >
                <asp:TextBox ID="txtModerate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" OnTextChanged="txtPassword_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnOk" runat="server" Text="确认" OnClick="btnOk_Click" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
