<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HariciCss.aspx.cs" Inherits="WebDivCss.HariciCss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Harici .css dosyası ile biçimlendirme</title>
    <%--<link href="Sablon.css" rel="stylesheet" />--%>
    <style>
        @import "Sablon.css";
    </style>
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
            içerik (content)
        </div>
        <div id="sagmenu">
            sağ menü (aside)
            <div class="sagicmenu">
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
