<%@ Page Title="" Language="C#" MasterPageFile="~/eTicaret.Master" AutoEventWireup="true" CodeBehind="UrunDetay.aspx.cs" Inherits="eTicaret.Web.Presentation.UrunDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="page-intro">
				<div class="container">
					<div class="row">
						<div class="col-md-12">
							<ol class="breadcrumb">
								<li><i class="fa fa-home pr-10"></i><a href="Default.aspx">Anasayfa</a></li>
								<li class="active">Ürün Detayları</li>
							</ol>
						</div>
					</div>
				</div>
			</div>
			<section class="main-container">
				<div class="container">
					<div class="row">
						<div class="main col-md-12">
							<h3 class="page-title margin-top-clear">Ürün Detayları</h3>
							<div class="row">
								<div class="col-md-4">
            <asp:DataList ID="dlstUrunler" runat="server" DataKeyField="urunid" OnItemCommand="dlstUrunler_ItemCommand">
                <ItemTemplate>
                    <h3 class="title"><asp:Label ID="lblUrunAd" runat="server" Text='<%#Eval("urunad") %>'></asp:Label></h3>
									<div class="tab-content clear-style">
										<div class="tab-pane active" id="product-images">
											<div class="owl-carousel content-slider-with-controls-bottom">
												<div class="overlay-container">
													<img src='<%#Eval("urunresimyolu2") %>' title='<%#Eval("urunad") %>' alt='<%#Eval("urunad") %>'/>
													<a href='<%#Eval("urunresimyolu2") %>' class="popup-img overlay" title='<%#Eval("urunad") %>'><i class="fa fa-search-plus"></i></a>
												</div>
											</div>
										</div>
									</div>
									<!-- Tab panes end-->
									<hr>
                    <div class="listing-item-body clearfix">
                        <asp:Label CssClass="price" ID="lblFiyat" runat="server" Text='<%#Eval("urunfiyat", "{0:C}") %>'></asp:Label>
                    <asp:TextBox CssClass="pull-right" ID="txtAdet" runat="server" TextMode="Number" Text="1" Min="1" Max='<%#Eval("miktar") %>'></asp:TextBox></div>
                    <div>
                    <div>
                        <asp:ImageButton ID="btnSepeteEkle" CssClass="pull-right small"  runat="server" ImageUrl="Content/images/sepet.png" CommandName="sepet" CommandArgument='<%#Eval("urunid") %>' />
                    </div>                    
                    </ItemTemplate>
                </asp:DataList>
								</div>

								<!-- product side start -->
								<aside class="col-md-8">
									<div class="sidebar">
										<div class="side product-item vertical-divider-left">
											<div class="tabs-style-2">
												<!-- Nav tabs -->
												<ul class="nav nav-tabs" role="tablist">
													<li class="active"><a href="#h2tab1" role="tab" data-toggle="tab"><i class="fa fa-file-text-o pr-5"></i>Description</a></li>
													<li><a href="#h2tab2" role="tab" data-toggle="tab"><i class="fa fa-files-o pr-5"></i>Specifications</a></li>
													<li><a href="#h2tab3" role="tab" data-toggle="tab"><i class="fa fa-star pr-5"></i>(3) Reviews</a></li>
												</ul>
												<!-- Tab panes -->
												<div class="tab-content padding-top-clear padding-bottom-clear">
													<div class="tab-pane fade in active" id="h2tab1">
														<h4 class="title">Lorem ipsum dolor sit amet, consectetur adipisicing elit.</h4>
														<p>Perspiciatis necessitatibus accusamus eligendi ducimus architecto reiciendis odit officiis? Alias repellendus veritatis consectetur, aliquam laborum possimus dolorem quidem, sit saepe explicabo sint.</p>
														<h4>Nostrum, consequuntur laudantium ea suscipit minima</h4>
														<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nostrum, consequuntur laudantium ea suscipit minima aliquid vitae possimus dolor voluptatibus autem minus alias quos praesentium debitis veniam nemo et odit dolores!</p>
														<p>Alias odio, cupiditate sed, possimus aut quasi ullam. Provident dicta, officia sunt quis doloribus sed nobis, fuga ab repudiandae. Quam atque, consequuntur non nesciunt enim dolores incidunt quis officiis voluptate est asperiores mollitia quia accusamus a nulla architecto repellendus placeat. Explicabo cum nihil, recusandae numquam repudiandae temporibus aliquid saepe ea nobis aliquam vero eaque odit doloribus tempore dicta ratione! Rerum numquam doloribus delectus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Soluta praesentium unde perferendis beatae asperiores aspernatur vero, veritatis! Vel libero cum, culpa odio, est totam eaque, ipsam voluptates saepe, quo id!</p>
													</div>
													<div class="tab-pane fade" id="h2tab2">
														<h4 class="space-top">Specifications</h4>
														<hr>
														<dl class="dl-horizontal">
															<dt>Screen</dt>
															<dd>4.95” 1920x1080 display</dd>
															<dt>Cameras</dt>
															<dd>1.3MP front facing, 8MP rear facing with Optical Image Stabilization</dd>
															<dt>Dimensions</dt>
															<dd>69.17 x 137.84 x 8.59 mm (130g)</dd>
															<dt>Battery</dt>
															<dd>2300 mAh. Talk time up to 17 hours*. Standby time up to 300 hours†. Internet use time up to 8.5 hours on Wi-Fi, up to 7 hours on LTE‡. Wireless Charging built-in</dd>
															<dt>Audio</dt>
															<dd>Built-in speaker 3.5mm stereo audio connector</dd>
															<dt>Processing</dt>
															<dd>CPU: Qualcomm Snapdragon™ 800, 2.26GHz processor</dd>
															<dd>GPU: Adreno 330, 450MHz</dd>
															<dt>Wireless</dt>
															<dd>Dual-band Wi-Fi (2.4G/5G) 802.11 a/b/g/n/ac</dd>
														</dl>
														<hr>
													</div>
													<div class="tab-pane fade" id="h2tab3">
														<!-- comments start -->
														<div class="comments margin-clear space-top">
															<!-- comment start -->
															<div class="comment clearfix">
																<div class="comment-avatar">
																	<img src="images/avatar.jpg" alt="avatar">
																</div>
																<div class="comment-content">
																	<h3>Amazing!</h3>
																	<div class="comment-meta"> <i class="fa fa-star text-default"></i> <i class="fa fa-star text-default"></i> <i class="fa fa-star text-default"></i> <i class="fa fa-star text-default"></i> <i class="fa fa-star"></i> | Today, 12:31</div>
																	<div class="comment-body clearfix">
																		<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo </p>
																		<a href="blog-post.html" class="btn btn-gray more pull-right"><i class="fa fa-reply"></i> Reply</a>
																	</div>
																</div>
																
															</div>
															<!-- comment end -->

															<!-- comment start -->
															<div class="comment clearfix">
																<div class="comment-avatar">
																	<img src="images/avatar.jpg" alt="avatar">
																</div>
																<div class="comment-content clearfix">
																	<h3>Works Perfect!</h3>
																	<div class="comment-meta"> <i class="fa fa-star text-default"></i> <i class="fa fa-star text-default"></i> <i class="fa fa-star text-default"></i> <i class="fa fa-star text-default"></i> <i class="fa fa-star text-default"></i> | Oct 15</div>
																	<div class="comment-body">
																		<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo </p>
																		<a href="blog-post.html" class="btn btn-gray more pull-right"><i class="fa fa-reply"></i> Reply</a>
																	</div>
																</div>
															</div>
															<!-- comment end -->

															<!-- comment start -->
															<div class="comment clearfix">
																<div class="comment-avatar">
																	<img src="images/avatar.jpg" alt="avatar">
																</div>
																<div class="comment-content clearfix">
																	<h3>Worth to Buy</h3>
																	<div class="comment-meta"> <i class="fa fa-star text-default"></i> <i class="fa fa-star text-default"></i> <i class="fa fa-star text-default"></i> <i class="fa fa-star"></i> <i class="fa fa-star"></i> | Sep 25</div>
																	<div class="comment-body">
																		<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo </p>
																		<a href="blog-post.html" class="btn btn-gray more pull-right"><i class="fa fa-reply"></i> Reply</a>
																	</div>
																</div>
															</div>
															<!-- comment end -->

														</div>
														<!-- comments end -->

													</div>
												</div>
											</div>
										</div>
									</div>
								</aside>
								<!-- product side end -->
							</div>

						</div>
						<!-- main end -->

					</div>
				</div>
			</section>
</asp:Content>
