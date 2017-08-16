<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="eTicaret.Web.Presentation.Admin.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="alert-warning" role="alert">
            <h3 class="text-center">Admin Girişi</h3>
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
        </div>
</asp:Content>
