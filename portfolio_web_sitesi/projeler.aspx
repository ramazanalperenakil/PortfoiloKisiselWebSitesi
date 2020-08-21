<%@ Page Title="" Language="C#" MasterPageFile="~/ana.master" AutoEventWireup="true" CodeFile="projeler.aspx.cs" Inherits="projeler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="urunler" class="container-fluid row m-0 p-0 ">
        <div id="solmenu" class="col-12 col-md-4  col-lg-3 col-xl-2 pl-0 accordion ">
            <asp:Repeater ID="RepeaterSolMenu" runat="server">
                <ItemTemplate>
                    <div class="flex ">
                        <div class="card-header" id="headingOne">
                            <a href="projeler.aspx?kId=<%#Eval("kategoriId")%>" target="_blank" class="text-decoration-none text-dark" data-toggle="collapse" data-target='#<%#Eval("kategoriAd").ToString().Replace(" ","") %>'><%#Eval("kategoriAd")%></a>
                        </div>

                        <div id="<%#Eval("kategoriAd").ToString().Replace(" ","") %>" class="collapse <%#(Container.ItemIndex == 0 ? "show":"") %>" data-parent="#solmenu">

                            <ul class="list-group list-group-flush pl-3">
                                <%#altKategoriGetir((int)Eval("kategoriId"))%>
                            </ul>

                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>






        </div>
        <div id="sagmenü" class="col-12 col-md-8  col-lg-9 col-xl-10 row">
            <asp:Panel ID="PanelUrunler" runat="server" CssClass="row w-100">
                <asp:Repeater ID="RepeaterUrunler" runat="server">
                    <ItemTemplate>
                        <div class="card col-xl-3 col-lg-4 col-md-6 p-4  border-0 w-100">
                            <a href='projeler.aspx?uId=<%#Eval("projeId")%>' class="card-link shadow-sm  h-100">
                                <div class="overflow-hidden">
                                    <img src='<%#urunGorselGetir((int)Eval("projeId"))%>' class="card-img-top img-fluid " />
                                </div>
                                <div class="card-body">
                                    <div class="card-title  h6 text-center text-dark"><%#Eval("projeAd")%></div>
                                    <div class="card-footer text-center h6 bg-secondary text-white">Proje Görüntüle</div>
                                </div>
                            </a>
                        </div>
                    </ItemTemplate>
                    <FooterTemplate>
                        <asp:Image ID="Image1" CssClass="w-50 m-auto" ImageUrl="img/proje_yok.png" runat="server" Visible="<%#RepeaterUrunler.Items.Count==0 %>" />
                    </FooterTemplate>
                </asp:Repeater>
            </asp:Panel>
            <asp:Panel ID="PanelTekUrun" runat="server" Visible="false" CssClass="row w-100">
                <div id="caruserTekUrun" class="col-xl-6 carousel slide " data-ride="carousel">
                    <ol class="carousel-indicators m-0" runat="server" id="sliderGosterge">
                    </ol>
                    <div class="  p-2  carousel-inner">
                        <asp:Repeater ID="RepeaterUrunGorseller" runat="server">
                            <ItemTemplate>

                                <div class="carousel-item kutu gallery  <%#(Container.ItemIndex == 0 ? "active":"") %>">
                                    <a href='<%#Eval("projeGorselUrl")%>' class="gallery">
                                        <img width="400" height="400" src='<%#Eval("projeGorselUrl")%>' class="d-block w-100 foto-zoom " alt="..."></a>
                                </div>
                            </ItemTemplate>
                            <FooterTemplate>
                                    <asp:Image ID="Image1" CssClass="w-75 m-auto container" ImageUrl="img/resim_yok.png" runat="server" Visible="<%#RepeaterUrunGorseller.Items.Count==0 %>" />
                                </FooterTemplate>
                        </asp:Repeater>
                    </div>
                </div>
                <div id="urunBilgi" class="col-xl-6 p-2">
                    <div class="card">
                        <div class="card-header">Ürün Bilgileri</div>
                        <div class="card-body">
                            <asp:Repeater ID="RepeaterTekUrun" runat="server">
                                <ItemTemplate>
                                    <h5 class="card-title"><%#Eval("projeAd")%></h5>
                                    <p class="card-text"><%#Eval("projeBilgi")%></p>
                                    </hr>
                                    <p class="card-text text-right text-success  font-weight-bold"><%#Eval("projeFiyat")%>  ₺ </p>
                                </ItemTemplate>
                                
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </asp:Panel>



        </div>
    </div>


</asp:Content>

