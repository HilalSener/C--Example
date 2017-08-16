<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebRepeater.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="repCategories" runat="server">
            <HeaderTemplate><h3>Categories</h3></HeaderTemplate>
            <ItemTemplate>
                <div>
                    <%--<%#DataBinder.Eval(Container.DataItem, "name") %>--%>
                    <%# Eval("name") %>
                </div>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <div style="background-color:silver">
                    <%# Eval("name") %>
                </div>
            </AlternatingItemTemplate>
            <SeparatorTemplate><hr /></SeparatorTemplate>
            <FooterTemplate><h5>DataControl olarak Repeater kullanılmıştır.</h5></FooterTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
