<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TabControl.aspx.cs" Inherits="WebAjaxToolKits.TabControl" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="2" Width="400px">
            <asp:TabPanel runat="server" HeaderText="Ürün İşlemleri" ID="TabPanel1">
                <ContentTemplate>
                    İstediğiniz ürünleri seçip, adetinin belirleyip sepete atabilirsiniz.
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel runat="server" HeaderText="Sepet İşlemleri" ID="TabPanel2">
                <ContentTemplate>
                    Sepet içeriğini görüntüleyebilir, istediğiniz ürünleri silebilir veya Satın Alama aşamasına geçebilirsiniz.
                </ContentTemplate>
            </asp:TabPanel>
            <asp:TabPanel runat="server" HeaderText="Üyelik İşlemleri" ID="TabPanel3">
                <ContentTemplate>
                    Ürünleri satın alabilmek için öncelikle üye olmalı ve teslimat bilgilerini girmelisiniz.
                </ContentTemplate>
            </asp:TabPanel>
        </asp:TabContainer>
    </div>
    </form>
</body>
</html>
