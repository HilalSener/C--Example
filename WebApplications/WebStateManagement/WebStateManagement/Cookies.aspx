<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="WebStateManagement.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="ddlMarkalar" runat="server" AutoPostBack="True" Height="35px" OnSelectedIndexChanged="ddlMarkalar_SelectedIndexChanged" ValidationGroup="1" Width="142px">
            <asp:ListItem>Marka Seçiniz</asp:ListItem>
            <asp:ListItem Value="1">Apple</asp:ListItem>
            <asp:ListItem Value="2">Samsung</asp:ListItem>
            <asp:ListItem Value="3">LG</asp:ListItem>
            <asp:ListItem Value="4">Sony</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
