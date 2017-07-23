<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebDiv.aspx.cs" Inherits="WebDivCss.WebDiv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="float:left;background-color:blue; color:yellow; width:300px; height:200px; font-size:large">
    Div'ler default olarak ilk boş satırda sola yaslanarak oluşurlar.
        <div style="width:150px;height :100px; background-color:red">İçerdeki div sonra başlayıp, önce bitmelidir.</div>
    </div>
    <div style="float:left;background-color:maroon; color:white; width:200px; height:200px; font-size:large">
    float:left kullanırsak, yeni gelen div öncekini solda bırakarak yerleşir.
    </div>
    <div style="float:right;background-color:gray; color:white; width:200px; height:200px; font-size:large">
    float:right kullanırsak, yeni gelen div formun sağ tarafına yerleşir.
    </div>
    <div style="clear:both;background-color:gray; color:white; width:800px; height:100px; font-size:large">
    clear:both kullanırsak, önceki float ayarları temizlenir, yeni div boş satırın solundan itibaren yerleşir.
    </div>
    </form>
</body>
</html>
