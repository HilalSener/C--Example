<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StyleCss.aspx.cs" Inherits="WebDivCss.StyleCss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Style elementiyle Css Biçimlendirme</title>
    <style type="text/css">
        #govde {width:1020px; height:580px; background-color:lightblue; color:white}
        #baslik {width:1000px; height:130px; background-color:steelblue; color:white; margin:10px}
        #ustmenu {width:1000px; height:40px; background-color:steelblue; color:white; margin:10px}
        #solmenu {float:left;width:200px; height:300px; background-color:lightgreen; color:white; margin-left:10px; margin-right:10px; margin-bottom:10px}
        #icerik {float:left;width:560px; height:300px; background-color:lightgreen; color:white; margin-left:10px; margin-right:10px}
        #sagmenu {float:left;width:200px; height:300px; background-color:lightgreen; color:white; margin-left:10px; margin-right:10px}
        .sagicmenu {width:180px; height:80px; background-color:forestgreen; margin:10px}
        #altbaslik {clear:both; width:1000px; height:30px; background-color:darkblue; color:white; margin:10px; margin-top:20px;text-align:center}
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
