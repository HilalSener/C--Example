<%@ Page Title="" Language="C#" MasterPageFile="~/eTicaret.Master" AutoEventWireup="true" CodeBehind="Sepet.aspx.cs" Inherits="eTicaret.Web.Presentation.Sepet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="page-intro">
				<div class="container">
					<div class="row">
						<div class="col-md-12">
							<ol class="breadcrumb">
								<li><i class="fa fa-home pr-10"></i><a href="Default.aspx">Anasayfa</a></li>
								<li class="active">Alışveriş Sepeti</li>
							</ol>
						</div>
					</div>
				</div>
			</div>
		<section class="main-container">

				<div class="container">
					<div class="row">

						<!-- main start -->
						<!-- ================ -->
						<div class="main col-md-12">

							<!-- page-title start -->
							<!-- ================ -->
							<h3 class="page-title margin-top-clear">Alışveriş Sepeti</h3>
							<!-- page-title end -->
							<div class="space"></div>
							<table class="table cart table-hover table-striped">
                                <asp:Repeater ID="repSepet" runat="server" OnItemCommand="repSepet_ItemCommand">
                                <HeaderTemplate>
								<thead>
									<tr>
										<th>Ürün Adı </th>
										<th>Fiyat </th>
										<th>Adet</th>
										<th>Sil </th>
										<th class="amount">Toplam </th>
									</tr>
								</thead>
                                </HeaderTemplate>
                                <ItemTemplate>
								<tbody>
									<tr class="remove-data">
										<td class="product"><a href="UrunDetay.aspx?id=<%#Eval("urunid") %>"><%#Eval("urunad") %></a> <small><%#Eval("urunad") %></small></td>
										<td class="price"><%#Eval("fiyat") %></td>
                                        <td class="quantity"><%#Eval("adet") %></td>
										<td class="remove"><asp:ImageButton ID="btnSil" runat="server" ImageUrl="Content/images/delete.png" Width="20px" Height="20px" CommandName="sil" CommandArgument='<%#Eval("urunid") %>' />
										<td class="amount"><%#Eval("tutar") %></td>
									</tr>
								</tbody>
                                </ItemTemplate>
                                <FooterTemplate>
									<tr>
										<td class="total-quantity" colspan="4">Toplam <%if (Session["toplamadet"] != null){%> <%=Session["toplamadet"].ToString() %><%} %> adet</td>
										<td class="total-amount"><%if (Session["toplamtutar"] != null){%> <%=Session["toplamtutar"].ToString() %><%} %></td>
									</tr>
                                </FooterTemplate>
                                </asp:Repeater>
							</table>
							<div class="text-right">	
								<a href="Default.aspx" class="btn btn-group btn-default btn-sm">Alışverişe Devam</a>
								<a href="SatinAl.aspx" class="btn btn-group btn-default btn-sm">Satın Al</a>
							</div>
						</div>
						<!-- main end -->

					</div>
				</div>
			</section>
</asp:Content>
