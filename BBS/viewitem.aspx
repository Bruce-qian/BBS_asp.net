<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewitem.aspx.cs" Inherits="viewitem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type ="text/css">
        body {
            width:60%;
            margin-left:auto;
            margin-right:auto;
        }
        .view-table {
            width:100%;
            height:auto;
        }
        .auto-style1 {
            height: 20px;
        }
    </style>
</head>
    
<body>
    <form id="form1" runat="server">
        <!--每个页面显示5个内容-->
        <table class ="view-table">
         <tr>
             <td>罗列所有帖子</td>
         </tr>
         <tr>
             <td></td>
         </tr>
         <tr>
             <td></td>
         </tr>
         <tr>
             <td></td>
         </tr>
         <tr>
             <td></td>
         </tr>
    </table>
    </form>
</body>
</html>
