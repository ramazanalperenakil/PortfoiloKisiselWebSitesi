<%@ Page Title="" Language="C#" MasterPageFile="~/ana.master" AutoEventWireup="true" CodeFile="hakkimda.aspx.cs" Inherits="hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container mt-2 mb-2 my-2 bg-white">


        <div class="row">

            <div class="col-lg-8 ">
                <asp:Repeater ID="RepeaterHakkimda" runat="server">
                    <ItemTemplate>
                        <h1 class="text-center"><%#Eval("sayfaAd")%></h1>
                        <p>
                            <%#Eval("sayfaMetin")%>
                        </p>
                        <img class="w-50 container" src=" <%#Eval("sayfaResim")%>" />
                    </ItemTemplate>
                </asp:Repeater>



            </div>

            <div class="col-lg-4  ">
                <h1 class="text-center">Projelerim</h1>
                
                <asp:Repeater ID="RepeaterProje" runat="server">
                    <ItemTemplate>
                       <a href="projeler.aspx?uId=<%#Eval("projeId")%>"><p class="container"><%#Eval("projeAd")%></p></a>
                    </ItemTemplate>
                </asp:Repeater>




            </div>


        </div>
    </div>
</asp:Content>

