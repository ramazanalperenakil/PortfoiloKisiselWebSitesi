<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="uyeEkle.aspx.cs" Inherits="yonetim_uyeEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="text-center mb-3 p-2">Üye Ekle</h2>
    <table class="table mx-auto" style="max-width:500px">
        <tr>
            <td>Kullanıcı Adı</td>
            <td><asp:TextBox ID="txtUyeAdi" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Şifreniz</td>
            <td><asp:TextBox ID="txtSifre" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Şifreniz (Tekrar)</td>
            <td><asp:TextBox ID="txtSifreTekrar"  TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Üyelik Türü</td>
            <td>
                <asp:DropDownList ID="ddlUyeTuru" CssClass="form-control" runat="server">
                    <asp:ListItem>admin</asp:ListItem>
                    <asp:ListItem>&#252;ye</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

        <tr>
            <td>Üye Durum</td>
            <td>
              <asp:DropDownList ID="ddlDurum" CssClass="form-control" runat="server">
                  <asp:ListItem Value="1">Aktif</asp:ListItem>
                  <asp:ListItem Value="0">Pasif</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        
        <tr>
            <td colspan="2" class="text-center">
                <asp:Label ID="lblDurum" runat="server" Text="Kayıt Başarılı" Visible="false" CssClass="form-control alert-success"></asp:Label>
                 <asp:Label ID="LblHata" runat="server" Text="Bir Hata Oluştu" Visible="false" CssClass="form-control alert alert-danger"></asp:Label>
                <asp:Button ID="btnEkle" runat="server" Text="Kayıt Ekle" CssClass="btn btn-success form-control w-50 " OnClick="btnEkle_Click" />
            </td>
        </tr>



    </table>
</asp:Content>

