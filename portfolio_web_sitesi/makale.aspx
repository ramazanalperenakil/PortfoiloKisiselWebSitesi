<%@ Page Title="" Language="C#" MasterPageFile="~/ana.master" AutoEventWireup="true" CodeFile="makale.aspx.cs" Inherits="makale" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="makaleler" class="container-fluid row m-0 p-0 ">
        <div id="solmenu" class="col-12 col-md-4  col-lg-3 col-xl-2 pl-0 accordion ">
       <asp:Repeater ID="RepeaterSolMenu" runat="server">
                <ItemTemplate>
                 
                    <div class="flex ">
                        <div class="card-header" id="headingOne">
                            <a href="makale.aspx?kId=<%#Eval("makaleKategoriId")%>" class="text-decoration-none text-dark" data-toggle="collapse" data-target='#<%#Eval("makalekategoriAd").ToString().Replace(" ","") %>'><%#Eval("makalekategoriAd")%></a>
                        </div>

                        <div id="<%#Eval("makalekategoriAd").ToString().Replace(" ","") %>" class="collapse <%#(Container.ItemIndex == 0 ? "show":"") %>" data-parent="#solmenu">

                            <ul class="list-group list-group-flush pl-3">
                                <%#altKategoriGetir((int)Eval("makaleKategoriId"))%>
                            </ul>

                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>







        </div>
        <div id="sagmenü" class="col-12 col-md-8  col-lg-9 col-xl-10 row">


         
                <div class="container p-0 m-2 ">

                    <asp:Repeater ID="Repeatermakaleler" runat="server">
                        <ItemTemplate>
                 

                            <div class="card m-3">
                                <div class="row ">
                                    <div class="col-md-4">
                                        <img src="<%#Eval("makaleResimUrl")%>" class="w-100">
                                    </div>
                                    <div class="col-md-8  ">
                                        <div class="card-block ">
                                            <h4class="card-title m-3"><%#Eval("makaleAd")%></h4>
                                            <p class="card-text"><%#Eval("makaleOzet")%></p>
                                            <a href="makale.aspx?uId=<%#Eval("makaleId")%>" class="btn btn-primary m-2">Devamını Oku..</a>
                                        </div>
                                    </div>

                                </div>
                            </div>

                        </ItemTemplate>
                    </asp:Repeater>
                </div>
        </div>
    </div>
</asp:Content>

