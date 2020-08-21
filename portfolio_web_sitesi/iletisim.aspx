<%@ Page Title="" Language="C#" MasterPageFile="~/ana.master" AutoEventWireup="true" CodeFile="iletisim.aspx.cs" Inherits="iletisim" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container contact-form p-2">
        <asp:Repeater ID="RepeaterİletisimBilgileri" runat="server">
            <ItemTemplate>
                <h1><%#Eval("isimSoyisim")%></h1>
                <hr>

                <div class="row">

                    <div class="col-md-6">
                        <address><%#Eval("universite")%></address>
                        <p>Email: <a href="mailto:<%#Eval("emai1")%>"><%#Eval("emai1")%></a> </p>
                        <p>Email: <a href="mailto:<%#Eval("email2")%>"><%#Eval("email2")%></a> </p>
                        <p>GSM  : <%#Eval("tel")%></p>
            </ItemTemplate>
        </asp:Repeater>
        <div class="img-fluid">
            <asp:Repeater ID="RepeaterSayflarİframae" runat="server">
                <ItemTemplate>
                 
                    <iframe src="<%#Eval("sayfaMetin")%>" width="350" height="250" style="border:0;" aria-hidden="false" tabindex="0"></iframe>

                </ItemTemplate>
            </asp:Repeater>

        </div>
    </div>




    <div class="col-md-6">

        <div class="form-group">
            <label>Adınız ve Soyadınız</label>
            <asp:TextBox ID="txtAdSoyad" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Email</label>
             <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

        <div class="form-group">
            <label>Mesajınız</label>
             <asp:TextBox ID="txtMesaj" CssClass="form-control"  runat="server" TextMode="MultiLine" Height="173"></asp:TextBox>
        </div>

        <div class="form-group">
            <asp:Label ID="lblBilgi" CssClass="form-control alert-success mb-3" Visible="false" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="btnGonder" CssClass="btn btn-primary btn-block" runat="server" Text="Gonder" OnClick="btnGonder_Click" />
      
        </div>

    </div>

    </div>

    </div>
</asp:Content>

