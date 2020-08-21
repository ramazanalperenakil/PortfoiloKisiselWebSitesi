<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Proje_Guncelle.aspx.cs" Inherits="yonetim_Proje_Guncelle" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2 class="text-center mb-3 p-2">Proje Güncelle</h2>
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
            <td>Proje Ana Kategori</td>
            <td><asp:TextBox ID="txtAna"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Proje Alt Kategori</td>
            <td><asp:TextBox ID="txtAlt"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Proje Alt Kategorinin Alt Kategorisi</td>
            <td><asp:TextBox ID="txtEnALt"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
             <tr>
            <td>Mevcut Kategoriyi Güncellemek</td>
            <td>
                <asp:DropDownList ID="ddlEH" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlEH_SelectedIndexChanged" >
                    <asp:ListItem Value="1">Evet</asp:ListItem>
                    <asp:ListItem Value="0" Selected="True">Hayır</asp:ListItem>
                </asp:DropDownList></td>
        </tr>

        <asp:Panel ID="Panel1" runat="server">
        <tr>
            <td>Ana Kategori</td>
            <td>
                <asp:DropDownList ID="ddlAna" OnSelectedIndexChanged="ddlAna_SelectedIndexChanged" CssClass="form-control" runat="server"   AutoPostBack="True" >
                   
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>Alt Kategori</td>
            <td>
                <asp:DropDownList ID="ddlAlt" OnSelectedIndexChanged="ddlAlt_SelectedIndexChanged" CssClass="form-control" runat="server" AutoPostBack="True" >
                     
                </asp:DropDownList></td>
        </tr>

        <tr>
            <td>Alt Kategorinin Alt Kategorisi</td>
            <td>
                <asp:DropDownList ID="ddlEnAlt" CssClass="form-control" runat="server" AutoPostBack="True">
                    
                </asp:DropDownList></td>
        </tr>
        </asp:Panel>
        
        <tr>
            <td>Fotoğraf Güncellemek İstermisiniz</td>
            <td>
              <asp:DropDownList ID="ddlDurumFoto" CssClass="form-control" runat="server">
                  <asp:ListItem Value="1">Evet</asp:ListItem>
                    <asp:ListItem Value="0" Selected="True">Hayır</asp:ListItem>
                </asp:DropDownList>
            </td>
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
                <asp:Label ID="lblDurum" runat="server" Text="Güncelleme Başarılı" Visible="false" CssClass="form-control alert-success"></asp:Label>
                 <asp:Label ID="LblHata" runat="server" Text="Bir Hata Oluştu" Visible="false" CssClass="form-control alert alert-danger"></asp:Label>
                <asp:Button ID="btnEkle" runat="server" Text="Proje Güncelle" CssClass="btn btn-success form-control w-50 " OnClick="btnEkle_Click"  />
            </td>
        </tr>



    </table>
</asp:Content>

