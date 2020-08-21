<%@ Page Title="" Language="C#" MasterPageFile="~/ana.master" AutoEventWireup="true" CodeFile="makaledetay.aspx.cs" Inherits="makaledetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container mt-2 mb-2 my-2 bg-white">


        <div class="row">

            <div class="col-lg-8 ">
                <asp:Repeater ID="RepeaterMakaleDetay" runat="server">
                    <ItemTemplate>
                        <table class="table" >
                            <tbody>
                                <tr>
                                    <td colspan="2">
                                        <h1 class="text-center p-2"><%#Eval("makaleAd")%></h1>
                                    </td>

                                </tr>
                                <tr>
                                    <td style="width: 300px;" class="p-2">
                                        <a href='<%#Eval("makaleResimUrl")%>'    class="gallery"> 
                                        <img class="img-fluid" src=" <%#Eval("makaleResimUrl")%>" /></a>
                                    </td>
                                    <td class="p-2" <%--style="width: 60px;"--%>>
                                        <%#Eval("makaleOzet")%>
                                       
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="p-2" colspan="2" <%--style="width: 58px;"--%>>
                                        <p>
                                             <%#Eval("makaleTarih")%> Tarihinde Yayınlandı <br />
                                            <%#Eval("makaleİcerik")%>
                                        </p>
                                    </td>
                                </tr>
                            </tbody>
                        </table>


                     
                    </ItemTemplate>
                </asp:Repeater>



            </div>

            <div class="col-lg-4  ">
                <h1 class="text-center">Projelerim</h1>

                <asp:Repeater ID="RepeaterProje" runat="server">
                    <ItemTemplate>
                        <a href="projeler.aspx?uId=<%#Eval("projeId")%>">
                            <p class="container"><%#Eval("projeAd")%></p>

                        </a>
                    </ItemTemplate>
                </asp:Repeater>




            </div>


        </div>
    </div>
</asp:Content>

