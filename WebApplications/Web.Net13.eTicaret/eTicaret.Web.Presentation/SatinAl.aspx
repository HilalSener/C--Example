<%@ Page Title="" Language="C#" MasterPageFile="~/eTicaret.Master" AutoEventWireup="true" CodeBehind="SatinAl.aspx.cs" Inherits="eTicaret.Web.Presentation.SatinAl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section clearfix">
        <div class="container">
            <asp:Panel ID="pnlGiris" runat="server">
                <div class="alert alert-warning" role="alert">
                    <strong>Sitemizden alışveriş yapabilmeniz için üye olmanız gerekmektedir. Üye değilseniz <a href="UyeKayit.aspx">yeni üye işlemleri için tıklayınız...</a></strong>
                </div>
                 <div class="row">
                    <div class="col-md-3">
                    </div>
                    <div class="col-md-8">
                        <h3 class="page-title margin-top-clear">Üye Girişi</h3>
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:Label ID="Label1" CssClass="form-control-static" runat="server" Text="kullanıcı (email)"></asp:Label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                        <asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="txtEmail" runat="server" ErrorMessage="Kullanıcı adı boş geçilemez!" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regEmail" ControlToValidate="txtEmail" runat="server" ErrorMessage="Email uygun formatta değil!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:Label ID="Label2" CssClass="form-control-static" runat="server" Text="şifre"></asp:Label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="txtSifre" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                        <asp:RequiredFieldValidator ID="rfvSifre" ControlToValidate="txtSifre" runat="server" ErrorMessage="Şifre boş geçilemez!" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3"></div>
                    <div class="col-md-8">
                        <asp:Button ID="btnGiris" CssClass="btn btn-default text-center" runat="server" Text="Giriş" OnClick="btnGiris_Click" />
                    </div>
                </div>
                <div class="row">
                    <asp:Label ID="lblMesaj" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>
                <div class="row">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </div>
            </asp:Panel>
        </div>
        <div class="container">
            <asp:Panel ID="pnlAdres" runat="server" Visible="false">
                <div class="row">
                    <div class="col-md-3">
                    </div>
                    <div class="col-md-8">
                        <h3 class="page-title margin-top-clear">Adres Bilgileri</h3>
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:Label ID="Label3" CssClass="form-control-static" runat="server" Text="Adı"></asp:Label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="txtAdi" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                        <asp:RequiredFieldValidator ID="rfvAdi" ControlToValidate="txtAdi" runat="server" ErrorMessage="İsim alanı boş geçilemez!" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:Label ID="Label4" CssClass="form-control-static" runat="server" Text="Soyadı"></asp:Label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="txtSoyadi" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                        <asp:RequiredFieldValidator ID="rfvSoyadi" ControlToValidate="txtSoyadi" runat="server" ErrorMessage="Soyad alanı boş geçilemez!" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:Label ID="Label5" CssClass="form-control-static" runat="server" Text="Telefon"></asp:Label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="txtTelefon" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                        <asp:RequiredFieldValidator ID="rfvTelefon" ControlToValidate="txtTelefon" runat="server" ErrorMessage="Telefon alanı boş geçilemez!" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:Label ID="Label6" CssClass="form-control-static" runat="server" Text="TCKimlik"></asp:Label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="txtTc" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                        <asp:RequiredFieldValidator ID="rfvTCKNo" ControlToValidate="txtTc" runat="server" ErrorMessage="TC Kimlik bilgisi boş geçilemez!" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:Label ID="Label7" CssClass="form-control-static" runat="server" Text="Teslim Adresi"></asp:Label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="txtTeslimAdres" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                        <asp:RequiredFieldValidator ID="rfvAdres" ControlToValidate="txtTeslimAdres" runat="server" ErrorMessage="Teslim Adresi boş geçilemez!" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:Label ID="Label8" CssClass="form-control-static" runat="server" Text="İlçe"></asp:Label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="txtIlce" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <asp:Label ID="Label9" CssClass="form-control-static" runat="server" Text="İl"></asp:Label>
                    </div>
                    <div class="col-md-8">
                        <asp:TextBox ID="txtIl" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3"></div>
                    <div class="col-md-8">
                        <asp:Button ID="btnAdresOnay" CssClass="btn btn-default text-center" runat="server" Text="Adres Onay" OnClick="btnAdresOnay_Click" />
                    </div>
                </div>
                <div class="row">
                    <asp:Label ID="lblAdresMesaj" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>
                <div class="row">
                    <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" />
                </div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
