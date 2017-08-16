<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebDetailsView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="248px" AllowPaging="True" AutoGenerateRows="False" CellPadding="4" DataKeyNames="FilmNo" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="FilmNo" HeaderText="FilmNo" InsertVisible="False" ReadOnly="True" SortExpression="FilmNo" />
                <asp:BoundField DataField="FilmAd" HeaderText="FilmAd" SortExpression="FilmAd" />
                <asp:BoundField DataField="FilmTurNo" HeaderText="FilmTurNo" SortExpression="FilmTurNo" />
                <asp:BoundField DataField="Yonetmen" HeaderText="Yonetmen" SortExpression="Yonetmen" />
                <asp:BoundField DataField="Oyuncular" HeaderText="Oyuncular" SortExpression="Oyuncular" />
                <asp:BoundField DataField="Ozet" HeaderText="Ozet" SortExpression="Ozet" />
                <asp:BoundField DataField="Fiyat" HeaderText="Fiyat" SortExpression="Fiyat" />
                <asp:CheckBoxField DataField="Varmi" HeaderText="Varmi" SortExpression="Varmi" />
                <asp:BoundField DataField="Miktar" HeaderText="Miktar" SortExpression="Miktar" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VideoMarketConnectionString %>" DeleteCommand="DELETE FROM [Filmler] WHERE [FilmNo] = @FilmNo" InsertCommand="INSERT INTO [Filmler] ([FilmAd], [FilmTurNo], [Yonetmen], [Oyuncular], [Ozet], [Fiyat], [Varmi], [Miktar]) VALUES (@FilmAd, @FilmTurNo, @Yonetmen, @Oyuncular, @Ozet, @Fiyat, @Varmi, @Miktar)" SelectCommand="SELECT * FROM [Filmler]" UpdateCommand="UPDATE [Filmler] SET [FilmAd] = @FilmAd, [FilmTurNo] = @FilmTurNo, [Yonetmen] = @Yonetmen, [Oyuncular] = @Oyuncular, [Ozet] = @Ozet, [Fiyat] = @Fiyat, [Varmi] = @Varmi, [Miktar] = @Miktar WHERE [FilmNo] = @FilmNo">
            <DeleteParameters>
                <asp:Parameter Name="FilmNo" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="FilmAd" Type="String" />
                <asp:Parameter Name="FilmTurNo" Type="Int32" />
                <asp:Parameter Name="Yonetmen" Type="String" />
                <asp:Parameter Name="Oyuncular" Type="String" />
                <asp:Parameter Name="Ozet" Type="String" />
                <asp:Parameter Name="Fiyat" Type="Decimal" />
                <asp:Parameter Name="Varmi" Type="Boolean" />
                <asp:Parameter Name="Miktar" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="FilmAd" Type="String" />
                <asp:Parameter Name="FilmTurNo" Type="Int32" />
                <asp:Parameter Name="Yonetmen" Type="String" />
                <asp:Parameter Name="Oyuncular" Type="String" />
                <asp:Parameter Name="Ozet" Type="String" />
                <asp:Parameter Name="Fiyat" Type="Decimal" />
                <asp:Parameter Name="Varmi" Type="Boolean" />
                <asp:Parameter Name="Miktar" Type="Int32" />
                <asp:Parameter Name="FilmNo" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
