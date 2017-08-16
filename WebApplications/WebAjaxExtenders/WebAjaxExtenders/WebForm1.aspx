<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAjaxExtenders.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .waterStyle{
            font-family:Verdana;
            font-size:medium;
            color:white;
            background-color:grey;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:Panel ID="Panel1" runat="server" Width="400px" Height="200px" BackColor="LightBlue">
            <table style="width:380px; margin:10px; text-align:center">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label1" runat="server" Text="Personel Başvuru Formu" Font-Bold="true" Font-Size="Medium" Font-Names="Verdana"></asp:Label>
                        <asp:BalloonPopupExtender ID="Label1_BalloonPopupExtender" runat="server" CustomCssUrl="" DynamicServicePath="" Enabled="True" ExtenderControlID="" TargetControlID="Label1" BalloonStyle="Cloud" BalloonSize="Medium" BalloonPopupControlID="Panel2">
                        </asp:BalloonPopupExtender>
                        <asp:Panel ID="Panel2" runat="server">Bilgileri eksiksiz doldurunuz!</asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="250px" Height="30px"></asp:TextBox>
                        <asp:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" runat="server" Enabled="True" TargetControlID="TextBox1" WatermarkText="Adınızı ve Soyadınızı giriniz..." WatermarkCssClass="waterStyle">
                        </asp:TextBoxWatermarkExtender>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="250px" Height="30px"></asp:TextBox>
                        <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox2" Format="dd.MM.yyyy" TodaysDateFormat="dd.MMM.yyyy">
                        </asp:CalendarExtender>
                        <asp:TextBoxWatermarkExtender ID="TextBox2_TextBoxWatermarkExtender" runat="server" Enabled="True" TargetControlID="TextBox2" WatermarkCssClass="waterStyle" WatermarkText="Doğum tarihinizi giriniz...">
                        </asp:TextBoxWatermarkExtender>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Tamam" OnClick="Button1_Click" />
                        <asp:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" ConfirmText="Onaylıyor musunuz?" Enabled="True" TargetControlID="Button1">
                        </asp:ConfirmButtonExtender>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:RoundedCornersExtender ID="Panel1_RoundedCornersExtender" runat="server" Enabled="True" TargetControlID="Panel1" Corners="All" Radius="20">
        </asp:RoundedCornersExtender>
        <asp:DropShadowExtender ID="Panel1_DropShadowExtender" runat="server" Enabled="True" TargetControlID="Panel1">
        </asp:DropShadowExtender>
    </div>
    </form>
</body>
</html>
