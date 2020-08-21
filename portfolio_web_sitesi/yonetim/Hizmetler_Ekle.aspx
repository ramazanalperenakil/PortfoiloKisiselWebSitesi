<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Hizmetler_Ekle.aspx.cs" Inherits="yonetim_Hizmetler_Ekle" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2 class="text-center mb-3 p-2">Hizmet Ekle </h2>
    <table class="table mx-auto" style="max-width: 500px">
        <tr>
            <td>Hizmet Adı</td>
            <td>
                <asp:TextBox ID="txtHizmetAdi" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Fotoğraf Yükle</td>
            <td>
                <asp:FileUpload ID="fuDosya" CssClass="form-control-file" runat="server" />

            </td>
        </tr>
        <tr>
            <td>Hizmet Bilgi Yazısı</td>
            <td>
                <asp:TextBox ID="txtHizmetBilgi" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Sayfa Seçin</td>
            <td>
                <asp:DropDownList ID="ddlSayfa" runat="server" CssClass="form-control">
                    <asp:ListItem Value="iletisim.aspx">İletisim</asp:ListItem>
                    <asp:ListItem Value="hakkimda.aspx">Hakkımda</asp:ListItem>
                </asp:DropDownList></td>
        </tr>



        <tr>
            <td colspan="2" class="text-center">
                <asp:Label ID="lblDurum" runat="server" Text="Kayıt Başarılı" Visible="false" CssClass="form-control alert-success"></asp:Label>
                  <asp:Label ID="LblHata" runat="server" Text="Bir Hata Oluştu" Visible="false" CssClass="form-control alert alert-danger"></asp:Label>
                <asp:Button ID="btnEkle" runat="server" Text="Hizmet Ekle" CssClass="btn btn-success form-control w-50 " OnClick="btnEkle_Click" />
            </td>
        </tr>



    </table>
</asp:Content>

