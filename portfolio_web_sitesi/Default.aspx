<%@ Page Title="" Language="C#" MasterPageFile="~/ana.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="slider" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators" runat="server" id="sliderGosterge">
        </ol>
        <div class="carousel-inner">
            <asp:Repeater ID="RepeaterSlider" runat="server">
                <ItemTemplate>
                    <div class="carousel-item <%#(Container.ItemIndex == 0 ? "active":"") %>">
                        <a href='makale.aspx?uId=<%#Eval("makaleId")%>'>
                            <img src='<%#Eval("makaleSliderResimUrl")%>' class="d-block w-100" alt="...">
                        </a>
                    </div>

                </ItemTemplate>
            </asp:Repeater>


        </div>
        <a class="carousel-control-prev" href="#slider" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#slider" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>

    <section class="py-5">
        <asp:Repeater ID="RepeaterBilgiler" runat="server">
            <ItemTemplate>


                <div class="container">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="row">
                                <img class="w-100 rounded-circle h-100" width="360" height="360" src="<%#Eval("foto")%>" />
                            </div>
                        </div>

                        <div class="col-md-6">
                            <div class="my-text">
                                <br />
                                <h6><%#Eval("hitap")%></h6>
                                <h3><%#Eval("isimSoyisim")%></h3>
                                <h4><%#Eval("meslek")%></h4>
                                <p><%#Eval("universite")%></p>
                                <ul style="list-style-type: none;" class="p-0">
                                    <li>
                                        <img src="img/icon/iconfinder_21_Media_social_website_phone_2657555.png" width="50" height="50" />
                                        &nbsp; GSM : <%#Eval("tel")%>
                                        <br />
                                        <br />
                                    </li>

                                    <li><a href="mailto:<%#Eval("emai1")%>">
                                        <img src="img/icon/iconfinder_mail_287692.png" width="50" height="50" />
                                        &nbsp;<%#Eval("emai1")%></a><br />
                                        <br />
                                    </li>

                                    <li><a href="mailto:<%#Eval("email2")%>">
                                        <img src="img/icon/iconfinder_mail_287692.png" width="50" height="50" />
                                        &nbsp;<%#Eval("email2")%></a><br />
                                    </li>
                                </ul>

                            </div>


                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </section>
    <section class="py-2 container">
        <div class="container">
            <h1 style="text-align: center">Yeteneklerlim</h1>

            <div class="row">


                <div class="col-md-12">
                    <br />
                    <div>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>


                                <div class="progress">

                                    <div class="progress-bar progress-bar-success progress-bar-striped" role="progressbar" aria-valuenow="<%#Eval("yetenekYuzdesi")%>" aria-valuemin="0" aria-valuemax="100" style="width: <%#Eval("yetenekYuzdesi")%>% ">
                                       <h6 class="mt-2" style="font-size:17px"><%#Eval("yetenekAdi")%>   (%<%#Eval("yetenekYuzdesi")%>)</h6> 
                                    </div>
                                </div>
                                <br />
                            </ItemTemplate>
                        </asp:Repeater>

                    </div>
                </div>


            </div>
        </div>
    </section>


    <section class="bg-yellow py-2 ">
        <h1 class="text-center ">Hizmetlerimiz</h1>
        



            <asp:Repeater ID="RepeaterHizmetler" runat="server">
                <ItemTemplate>

                    <div class="container py-3">
                        <div class="card w-100">
                            <div class="row ">
                                <div class="col-md-4">
                                    <img src="<%#Eval("hizmetResimUrlsi")%>" class="  mb-1 img-fluid">
                                </div>
                                <div class="col-md-8 px-3">
                                    <div class="card-block px-3">
                                        <h4 class="card-title p-1"><%#Eval("hizmetAdi")%></h4>
                                        <p class="card-text"><%#Eval("hizmetOzellik")%></p>
                                        <a  href='<%#Eval("hizmetDetayUrl")%>' class="btn btn-primary m-4">Benimle İletişime Geçin</a>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
     
    </section>



</asp:Content>

