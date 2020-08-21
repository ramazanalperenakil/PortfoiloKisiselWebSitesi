<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="yonetim_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="jumbotron">
        <div class="row w-100">

            <div class="col-md-6 w-100">
                <div class="card border-info mx-sm-1 p-3 w-100">
                    <center> <img src="../img/icon/projeler.png"/></center>
                    <div class="text-info mt-3">
                        <h4 class="text-center">Toplam Proje Sayısı</h4>
                    </div>
                    <div class="text-info text-center mt-2">
                        <h1 id="Tp" runat="server">234</h1>
                    </div>

                    <div class="card border-0 mx-sm-1 p-3">
                        <div class="notice notice-info">
                            <strong class="text-center">En Son Projeler</strong><br /> <br /> 
                            <asp:Repeater ID="RepeaterProjeler" runat="server">
                                <ItemTemplate>
                                    <a href="../projeler.aspx?uId=<%#Eval("projeId")%>"><p class="text-black-50"><%#Eval("projeAd")%></p></a>
                                </ItemTemplate>
                            </asp:Repeater>
   
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-6 w-100">
                <div class="card border-info mx-sm-1 p-3 w-100">
                    <center> <img src="../img/icon/makaleler.png"/></center>
                    <div class="text-info mt-3">
                        <h4 class="text-center">Toplam Makale Sayısı</h4>
                    </div>
                    <div class="text-info text-center mt-2">
                        
                        <h1 id="Mt" runat="server">234</h1>
                    </div>
                       <div class="card border-0 mx-sm-1 p-3">
                        <div class="notice notice-info">
                            <strong class="text-center">En Son Makaleler</strong><br /> <br /> 
                            <asp:Repeater ID="RepeaterMakaleler" runat="server">
                                <ItemTemplate>
                                    <a href="../makale.aspx?uId=<%#Eval("makaleId")%>"><p class="text-black-50"><%#Eval("makaleAd")%></p></a>
                                </ItemTemplate>
                            </asp:Repeater>
   
                        </div>
                    </div>
                </div>
            </div>

        </div>



    </div>
</asp:Content>

