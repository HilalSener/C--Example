<%@ Page Title="" Language="C#" MasterPageFile="~/eTicaret.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="eTicaret.Web.Presentation.Default" %>

<%@ Register Src="~/ucUrunler.ascx" TagPrefix="uc1" TagName="ucUrunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucUrunler runat="server" id="ucUrunler" />
</asp:Content>
