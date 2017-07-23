<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPostback.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>İlk ASP.Net Projesi</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtAdi" runat="server"></asp:TextBox>
        <asp:Button ID="btnGonder" runat="server" Text="Kaydet" OnClick="btnGonder_Click" />
    
        <br />
        <asp:Label ID="lblMesaj" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
