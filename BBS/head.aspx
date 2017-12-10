<%@ Page Language="C#" AutoEventWireup="true" CodeFile="head.aspx.cs" Inherits="head" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .left {
            width:100%;
            height:100%;
            
        }
        .right {
            width:30%;
            height:100%;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
    <div class="left">
        <table style="width:100%;height:100%">
            <tr>
                <td> 
                    <asp:Label ID="labuser" runat="server" Text="用户id"></asp:Label>
                </td>
                <td> 
                    <asp:Label ID="labshenfen" runat="server" Text="身份"></asp:Label>
                </td>
                <td> 
                    <asp:Label ID="lablv" runat="server" Text="等级"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
