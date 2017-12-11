<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regist.aspx.cs" Inherits="regist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type ="text/css">
        body {
            width:80%;
            text-align:center;
            margin-left:auto;
            margin-right:auto;
        }
        .auto-style1 {
            width: 50%;
            height:40px;
            margin-left:auto;
            margin-right:auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPsw" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="性别"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtSex" runat="server"></asp:TextBox>
            </td>
        </tr
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="出生日期"></asp:Label>
        </td>
            <td>
                <asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>
        </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="手机号"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="E-mail"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="地址"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAdress" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
        <table class="auto-style1">
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnOk" runat="server" Text="注册" Height="32px" Width="94px" OnClick="btnOk_Click" />
                </td>
                <td>
                    <asp:Button ID="btnHome" runat="server" Text="主页" OnClick="btnHome_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
