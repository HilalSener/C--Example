<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebRepeater.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Sablon.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
<div id="govde">
    gövde (body)
        <div id="baslik">
            başlık (header)
        </div>
        <div id="ustmenu">
            üst menu (top menu)
        </div>
        <div id="solmenu">
            sol menü (nav)
        </div>
        <div id="icerik">
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
        <div id="sagmenu">
            sağ menü (aside)
            <div class="sagicmenu egik kirmizi">
                kullanıcı işlemleri
            </div>
            <div class="sagicmenu">
                sepet işlemleri
            </div>
            <div class="sagicmenu">
                reklam
            </div>
        </div>
        <div id="altbaslik">
            &copy;Copyright HSS-Yaz 13 2017 
        </div>
    </div>

    </form>
</body>
</html>
