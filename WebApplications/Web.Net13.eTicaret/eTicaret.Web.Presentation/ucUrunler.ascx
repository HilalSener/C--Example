<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucUrunler.ascx.cs" Inherits="eTicaret.Web.Presentation.ucUrunler" %>
<div class="section clearfix">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
            <asp:DataList ID="dlstUrunler" runat="server" RepeatColumns="4" DataKeyField="urunid" OnItemCommand="dlstUrunler_ItemCommand">
                <ItemTemplate>
                    <div><span class="badge default-bg">%50 indirim</span></div>
                    <h3 class="title">
                        <asp:Label ID="lblUrunAd" runat="server" Text='<%#Eval("urunad") %>'></asp:Label></h3>
                    <div class="overlay-container">
                    <img src='<%#Eval("urunresimyolu1") %>' title="" alt=""/>
                    <a href="UrunDetay.aspx?id=<%#Eval("urunid") %>" class="overlay small"><i class="fa fa-plus"></i><span>detaylar...</span></a>
                    </div> <p>Özel kampanyalı kdv dahil fiyatlardır.</p>
                    <div class="listing-item-body clearfix">
                        <asp:Label CssClass="price" ID="lblFiyat" runat="server" Text='<%#Eval("urunfiyat", "{0:C}") %>'></asp:Label>
                    <asp:TextBox CssClass="pull-right" ID="txtAdet" runat="server" TextMode="Number" Text="1" Min="1" Max='<%#Eval("miktar") %>'></asp:TextBox></div>
                    <div>
                        <asp:ImageButton ID="btnSepeteEkle" CssClass="pull-right small"  runat="server" ImageUrl="Content/images/sepet.png" CommandName="sepet" CommandArgument='<%#Eval("urunid") %>' />
                    </div>
                </ItemTemplate>
        </asp:DataList>
        </div>
        </div>
    </div>
</div>
