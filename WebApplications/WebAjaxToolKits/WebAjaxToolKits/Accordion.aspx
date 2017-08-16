<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Accordion.aspx.cs" Inherits="WebAjaxToolKits.Accordion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .accgovde {
            width:400px;
        }
        .accbaslik{
            background-color:black;
            color:white;
            border:1px solid black;
            cursor:pointer;
            font-family:Verdana;
            font-size:12px;
            padding:5px;
        }
        .accsecili{
            background-color:black;
            color:white;
            border:1px solid black;
            cursor:pointer;
            font-family:Verdana;
            font-size:12px;
            padding:5px;
        }
        .accicerik{
            background-color:silver;
            color:black;
            border:1px dashed black;
            cursor:pointer;
            font-family:Verdana;
            font-size:12px;
            padding:5px;
            padding-top:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
            <asp:Accordion ID="Accordion1" runat="server" CssClass="accgovde" ContentCssClass="accicerik" HeaderCssClass="accbaslik" HeaderSelectedCssClass="accsecili">
                <Panes>
                    <asp:AccordionPane ID="AccrodionPane1" runat="server" >
                        <Header>ASP.Net Ajax hangi nesneleri kullanır?</Header>
                        <Content>Javascript, XML dışında HTML/XHTML, CSS, DOM ve HttpRequest nesnelerini kullanır.</Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane ID="AccordionPane2" runat="server">
                        <Header>XMLHttpRequest sınıfı ne amaçla kullanılır?</Header>
                        <Content>Normal web sayfasının işlenişini arka tarafta client side olarak takip eder, asenkron olarak sayfanın sadece istenen bölümünün güncellenmesini sağlar.</Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane ID="AccordionPane3" runat="server">
                        <Header>ASP.Net Ajax nasıl bir postpack işlemi gerçekleştirir?</Header>
                        <Content>Update panel içinde bulunan bölüm Partial Page Postback işlemine maruz kalır</Content>
                    </asp:AccordionPane>
                    <asp:AccordionPane ID="AccordionPane4" runat="server">
                        <Header>ToolkitScriptManager ne amaçla kullanılır?</Header>
                        <Content>Ajax Control Toolkit araçlarını kullanmak için öncelikle sayfaya ScriptManager yerine ToolkitScriptManager nesnesi atılmalıdır.</Content>
                    </asp:AccordionPane>
                </Panes>
            </asp:Accordion>
    </div>
    </form>
</body>
</html>
