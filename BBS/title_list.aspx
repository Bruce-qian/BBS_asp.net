﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="title_list.aspx.cs" Inherits="title_list" %>

<!DOCTYPE html>
<!--罗列某个论坛里的帖子标题，并能通过点击阅读某个帖子的详细内容-->
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

                    <asp:Button ID="btnApplication" runat="server" OnClick="btnApplication_Click" Text="申请版主" />

                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSourceViewItem" AllowPaging="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="2">
            <Columns>
                <asp:BoundField DataField="post_id" HeaderText="帖子编号" SortExpression="post_id" />
                <asp:BoundField DataField="user_id" HeaderText="用户id" SortExpression="user_id" />
                <asp:BoundField DataField="post_title" HeaderText="标题" SortExpression="post_title" />
                <asp:BoundField DataField="post_publish_time" HeaderText="发表时间" SortExpression="post_publish_time" />
                <asp:BoundField DataField="reade_count" HeaderText="阅读量" SortExpression="reade_count" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    
        <asp:SqlDataSource ID="SqlDataSourceViewItem" runat="server" ConnectionString="<%$ ConnectionStrings:strConn %>" SelectCommand="SELECT [post_id], [user_id], [post_title], [post_publish_time], [reade_count] FROM [Send_Post_Count_Table] WHERE ([bbs_id] = @bbs_id)">
            <SelectParameters>
                <asp:SessionParameter Name="bbs_id" SessionField="class" Type="Int32" />
            </SelectParameters>
                    </asp:SqlDataSource>
    
                </td>
            </tr>
        </table>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
</body>
</html>
