<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InlineCss.aspx.cs" Inherits="WebDivCss.InlineCss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:1020px; height:580px; background-color:lightblue; color:white">
    gövde (body)
        <div style="width:1000px; height:130px; background-color:steelblue; color:white; margin:10px">
            başlık (header)
        </div>
        <div style="width:1000px; height:40px; background-color:steelblue; color:white; margin:10px">
            üst menu (top menu)
        </div>
        <div style="float:left;width:200px; height:300px; background-color:lightgreen; color:white; margin-left:10px; margin-right:10px; margin-bottom:10px">
            sol menü (nav)
        </div>
        <div style="float:left;width:560px; height:300px; background-color:lightgreen; color:white; margin-left:10px; margin-right:10px">
            içerik (content)
        </div>
        <div style="float:left;width:200px; height:300px; background-color:lightgreen; color:white; margin-left:10px; margin-right:10px">
            sağ menü (aside)
            <div style="width:180px; height:80px; background-color:forestgreen; margin:10px">
                kullanıcı işlemleri
            </div>
            <div style="width:180px; height:80px; background-color:forestgreen; margin:10px">
                sepet işlemleri
            </div>
            <div style="width:180px; height:80px; background-color:forestgreen; margin:10px">
                reklam
            </div>
        </div>
        <div style="clear:both; width:1000px; height:30px; background-color:darkblue; color:white; margin:10px; margin-top:20px;text-align:center">
            &copy;Copyright HSS-Yaz 13 2017 
        </div>
    </div>
    </form>
</body>
</html>
