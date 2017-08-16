<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriEkle.aspx.cs" Inherits="eTicaret.Web.Presentation.Admin.KategoriEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="gvKategoriler" runat="server" CellPadding="4" DataKeyNames="id" ForeColor="#333333" GridLines="None" Width="528px" OnSelectedIndexChanged="gvKategoriler_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ButtonType="Button" HeaderText="&gt;&gt;" SelectText="&gt;&gt;" ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
    </div>
    <asp:LinkButton ID="lbYeniKategori" runat="server" OnClick="lbYeniKategori_Click">Yeni Kategori</asp:LinkButton>
    <asp:Panel ID="pnlKategorier" runat="server" Visible="false">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Kategori Adı"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAdi" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Açıklama"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAciklama" CssClass="form-control" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-right">
                        <asp:Button ID="btnKaydet" CssClass="btn btn-default text-center" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:Button ID="btnDegistir" CssClass="btn btn-default text-center" runat="server" Text="Değiştir" />&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSil" CssClass="btn btn-default text-center" runat="server" Text="Sil" />
                    </td>
                </tr>
            </table>
        </div>
    </asp:Panel>
</asp:Content>
