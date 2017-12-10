<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Audit.aspx.cs" Inherits="Audit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <!--审核版主页面-->
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="111px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>C++</asp:ListItem>
            <asp:ListItem>JAVA</asp:ListItem>
        </asp:DropDownList>
    </div>
        <div>

            <asp:GridView ID="GridViewAudit" runat="server" OnSelectedIndexChanged="GridViewAudit_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField ButtonType="Button" Text="设置" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
