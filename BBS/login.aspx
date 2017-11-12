<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            text-align:center;
            margin-left:auto;
            margin-right:auto;
        }
        .auto-style3 {
            height: 40px;
        }

        body {
            width:80%;
            text-align:center;
            margin-left:auto;
            margin-right:auto;
        }
        .auto-style4 {
            height: 40px;
            width: 50%;
        }
   
        .auto-style5 {
            width: 100%;
        }
   
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class ="auto-style1 ">
        <tr>
            <td class="auto-style4" >
                <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
            </td>
            <td class="auto-style4" >
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
        <table class =" auto-style1">
            <tr>
            <td class  ="auto-style4">
                <asp:Button ID="btnLog" runat="server" Text="登陆" Height="35px" OnClick="btnLog_Click" Width="78px" />
            </td>
            <td class  =" auto-style4">
                <asp:Button ID="btnRegist" runat="server" Text="注册" Height="35px" OnClick="btnRegist_Click" Width="78px" />
            </td>
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
