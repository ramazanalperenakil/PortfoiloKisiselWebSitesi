<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Proje_Ekle.aspx.cs" Inherits="yonetim_Proje_Ekle" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2 class="text-center mb-3 p-2">Proje Ekle</h2>
    <table class="table mx-auto" style="max-width:500px">
        <tr>
            <td>Proje Adı</td>
            <td><asp:TextBox ID="txtProjeAd" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Proje Fiyatı</td>
            <td><asp:TextBox ID="txtProjeFiyat"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Proje Bilgisi</td>
            <td><asp:TextBox ID="txtProjeBilgi" TextMode="MultiLine"   CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Ana Kategori</td>
            <td>
                <asp:DropDownList ID="ddlAna" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlAna_SelectedIndexChanged"  AutoPostBack="True" ></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Alt Kategori</td>
            <td>
                <asp:DropDownList ID="ddlAlt" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlAlt_SelectedIndexChanged"></asp:DropDownList></td>
        </tr>

        <tr>
            <td>Alt Kategorinin Alt Kategorisi</td>
            <td>
                <asp:DropDownList ID="ddlEnAlt" CssClass="form-control" runat="server" AutoPostBack="True"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Yayın Durumu</td>
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
                <asp:Button ID="btnEkle" runat="server" Text="Kayıt Ekle" CssClass="btn btn-success form-control w-50 " OnClick="btnEkle_Click"  />
            </td>
        </tr>



    </table>
</asp:Content>

