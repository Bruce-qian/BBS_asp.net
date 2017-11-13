<%@ Page Language="C#" AutoEventWireup="true" CodeFile="title_list.aspx.cs" Inherits="title_list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
        body {
           width:100%;
            text-align:center;
        }
        table {
           width:auto;
           margin:0 auto;
           text-align:center;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceViewItem" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="2">
            <Columns>
                <asp:BoundField DataField="bbs_title" HeaderText="bbs_title" SortExpression="bbs_title" />
                <asp:BoundField DataField="bbs_moderator" HeaderText="bbs_moderator" SortExpression="bbs_moderator" />
                <asp:BoundField DataField="bbs_start_time" HeaderText="bbs_start_time" SortExpression="bbs_start_time" />
                <asp:BoundField DataField="bbs_end_time" HeaderText="bbs_end_time" SortExpression="bbs_end_time" />
                <asp:CommandField SelectText="进入" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    
        <asp:SqlDataSource ID="SqlDataSourceViewItem" runat="server" ConnectionString="<%$ ConnectionStrings:strConn %>" SelectCommand="SELECT [bbs_title], [bbs_moderator], [bbs_start_time], [bbs_end_time] FROM [BBS_Column_Table]"></asp:SqlDataSource>
    
                </td>
            </tr>
        </table>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
</body>
</html>
