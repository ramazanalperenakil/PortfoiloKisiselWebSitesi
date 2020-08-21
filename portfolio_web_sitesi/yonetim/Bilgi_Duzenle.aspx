<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Bilgi_Duzenle.aspx.cs" Inherits="yonetim_Bilgi_Duzenle" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2 class="text-center mb-3 p-2">Kişisle Bilgilerimi Düzenle</h2>

    <table class="table mx-auto" >
        <tr>
            <td>İsim Soyisim</td>
            <td>
                <asp:TextBox ID="txtIsimSoyisim" CssClass="form-control" runat="server"></asp:TextBox></td>
            <td>Meslek</td>
            <td>
                <asp:TextBox ID="txtMeslek" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Üniversiteniz</td>
            <td>
                <asp:TextBox ID="txtuni" CssClass="form-control" runat="server"></asp:TextBox></td>
            <td>Fakülteniz</td>
            <td>
                <asp:TextBox ID="txtFakulte" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Cep Telefonunuz</td>
            <td>
                <asp:TextBox ID="txtTel" CssClass="form-control" runat="server"></asp:TextBox></td>
            <td>Hitap Cümlesi</td>
            <td>
                <asp:TextBox ID="txtHitap" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
            <td>E-Posta 1</td>
            <td>
                <asp:TextBox ID="txtEPosta1" CssClass="form-control" runat="server"></asp:TextBox></td>
            <td>E-Posta 2</td>
            <td>
                <asp:TextBox ID="txtEPosta2" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>

         
            <td>Fotoğraf Güncelleme</td>
            <td>
                <asp:DropDownList ID="ddlFotoSecim" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlFotoSecim_SelectedIndexChanged">
                    <asp:ListItem Value="1">EVET</asp:ListItem>
                    <asp:ListItem Value="0" Selected="True">Hayır</asp:ListItem>
                </asp:DropDownList>
                
            </td>
               <td colspan="2">Mevcut Fotoğrafınız
           
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <img src="<%#Eval("foto")%>" class="img-fluid ml-5" height="100" width="100" />
                    </ItemTemplate>
                </asp:Repeater>

                  <asp:FileUpload ID="fuDosya" CssClass="form-control-file" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="4" class="text-center">
                <asp:Label ID="lblDurum" runat="server" Text="Kayıt Başarılı" Visible="false" CssClass="form-control alert  alert-success"></asp:Label>
                 <asp:Label ID="LblHata" runat="server" Text="Bir Hata Oluştu" Visible="false" CssClass="form-control alert alert-danger"></asp:Label>
               
            </td>
        </tr>
    </table>
    <asp:Button ID="btnEkle" runat="server" Text="Güncelle" CssClass="btn btn-success form-control container" OnClick="btnEkle_Click" />
</asp:Content>

