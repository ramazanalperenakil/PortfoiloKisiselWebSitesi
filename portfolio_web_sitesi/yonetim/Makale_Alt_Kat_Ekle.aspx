<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Makale_Alt_Kat_Ekle.aspx.cs" Inherits="yonetim_Makale_Alt_Kat_Ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="text-center mb-3 p-2">Makale Alt Kategori Ekle </h2>
    <table class="table mx-auto" style="max-width:500px">
        <tr>
            <td> Alt Kategori Adı</td>
            <td><asp:TextBox ID="txtKategori" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Üst Kategori Adı</td>
            <td><asp:DropDownList ID="ddlAltKategori" CssClass="form-control" runat="server"></asp:DropDownList></td>
        </tr>


        <tr>
            <td colspan="2" class="text-center">
                <asp:Label ID="lblDurum" runat="server" Text="Kayıt Başarılı" Visible="false" CssClass="form-control alert-success"></asp:Label>
                 <asp:Label ID="LblHata" runat="server" Text="Bir Hata Oluştu" Visible="false" CssClass="form-control alert alert-danger"></asp:Label>
                <asp:Button ID="btnEkle" runat="server" Text="Makale Kategori Ekle" CssClass="btn btn-success form-control w-50 " OnClick="btnEkle_Click"    />
            </td>
        </tr>



    </table>
</asp:Content>

