<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type ="text/css">
        body {
            width:70%;
            margin-left:auto;
            margin-right:auto;
        }
        .auto-style {
            width:100%;
            margin-left:auto;
            margin-right:auto;
            height:500px;
        }
        .auto-style-td {
            width:10%;
            height:400px;
             margin-left: 0px;
            margin-right: 0px;
            text-align:right;
           
        }
        .auto-style-td1 {
            width:30%;
            height:400px;
             margin-left: 0px;
            margin-right: 0px;
            text-align:right;
           
        }
        .auto-style-tdd {
             margin-left: 0px;
            margin-right: 0px;
            width:70%;
            height:400px;
            text-align:left;
        }
        #frame1 {
            height: 720px;
            /*width: 831px;*/
            width:100%;
            margin-left: 0px;
            margin-right: 0px;
        }
        .treview {
            width:100%;
            margin-left: 0px;
            margin-right: 0px;
        }
        .auto-style1 {
            width: 238px;
            height: 400px;
            margin-left: 0px;
            margin-right: 0px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class ="auto-style">
            <tr>
                <td class="auto-style-td">
                    <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" >
                        <Nodes>
                            <asp:TreeNode Text="论坛分类" Value="论坛分类">
                                <asp:TreeNode Text="C++" Value="C++"></asp:TreeNode>
                                <asp:TreeNode Text="JAVA" Value="JAVA"></asp:TreeNode>
                                <asp:TreeNode Text="PHP" Value="PHP"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="保留" Value="保留"></asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
                </td>
                <td class =" auto-style-tdd">
                    <iframe id="frame1" src="SourcePage.extension / URL of the external Site" scrolling="auto" runat="server" width ="100%">

                    </iframe>
                </td>
                <td class="auto-style-td1">
                   <table>
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
                              <asp:Label ID="Label2" runat="server" Text="身份"></asp:Label></td>
                          <td>
                              <asp:TextBox ID="txtShengfeng" runat="server"></asp:TextBox>
                          </td>
                      </tr>
                       <tr>
                           <td>
                               <asp:Label ID="Label3" runat="server" Text="等级"></asp:Label>
                           </td>
                           <td>
                               <asp:TextBox ID="txtLv" runat="server"></asp:TextBox>
                           </td>
                       </tr>
                   </table>
                </td>
            </tr>
        </table>     
    </form>
</body>
</html>
