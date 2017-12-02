<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pushessay.aspx.cs" Inherits="pushessay" %>

<!DOCTYPE html>
<!--创建帖子内容包括标题内容-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
        div {
            margin-bottom:50px;
            margin-left:auto;
            margin-right:auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtTittle" runat="server" Width="204px"></asp:TextBox>
    
    </div>
     <div>


         <asp:TextBox ID="txtessay" runat="server" Height="222px" TextMode="MultiLine" Width="555px" OnTextChanged="txtessay_TextChanged"></asp:TextBox>


     </div>
        <div>

            <asp:Button ID="btnOk" runat="server" Text="提交" OnClick="btnOk_Click" />

        </div>
    </form>
</body>
</html>
