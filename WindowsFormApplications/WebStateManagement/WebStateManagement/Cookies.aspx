<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="WebStateManagement.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlMarkalar" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Marka Seçiniz</asp:ListItem>
            <asp:ListItem>Apple</asp:ListItem>
            <asp:ListItem>Samsung</asp:ListItem>
            <asp:ListItem>LG</asp:ListItem>
            <asp:ListItem>Sony</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
