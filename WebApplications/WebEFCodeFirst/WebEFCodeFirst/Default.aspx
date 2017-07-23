<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebEFCodeFirst.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server">
            <HeaderTemplate><h3>Kategoriler</h3></HeaderTemplate>
            <ItemTemplate>
                <div>
                    <%#Eval("KategoriAdi")%>
                </div>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <div style="background-color:silver">
                   <%#Eval("KategoriAdi")%>
                </div>
            </AlternatingItemTemplate>
            <SeparatorTemplate><hr /></SeparatorTemplate>
        </asp:Repeater>
        <asp:Menu ID="mnuKategoriler" runat="server" BackColor="#FFFBD6" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="Medium" ForeColor="#990000" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="#990000" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#FFFBD6" />
            <DynamicSelectedStyle BackColor="#FFCC66" />
            <StaticHoverStyle BackColor="#990000" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#FFCC66" />

        </asp:Menu>
    </div>
    </form>
</body>
</html>
