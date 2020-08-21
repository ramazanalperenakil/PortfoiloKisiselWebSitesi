<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Makale_Guncelle.aspx.cs" Inherits="yonetim_Makale_Guncelle" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2 class="text-center mb-3 p-2">Makale Güncelle</h2>
    <table class="table mx-auto" style="max-width:500px">
        <tr>
            <td>Makale Adı</td>
            <td><asp:TextBox ID="txtMakaleAd" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Makale Özet</td>
            <td><asp:TextBox ID="txtMakaleOzet"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Makale İçerik</td>
            <td><asp:TextBox ID="txtProjeBilgi" TextMode="MultiLine"   CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Mevcut Kategori</td>
            <td><asp:TextBox ID="txtkat"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Mevcut Alt Kategori</td>
            <td><asp:TextBox ID="txtalt"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Kategori Güncelle</td>
            <td>
                <asp:DropDownList ID="ddlEH" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlEH_SelectedIndexChanged"  >
                    <asp:ListItem Value="1">Evet</asp:ListItem>
                    <asp:ListItem Value="0" Selected="True">Hayır</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <asp:Panel ID="Panel1" Visible="false" runat="server">
             <tr>
            <td>Ana Kategori</td>
            <td>
                <asp:DropDownList ID="ddlAna" OnSelectedIndexChanged="ddlAna_SelectedIndexChanged" CssClass="form-control" runat="server"   AutoPostBack="True"  ></asp:DropDownList></td>
        </tr>
        <tr>
            <td>Alt Kategori</td>
            <td>
                <asp:DropDownList ID="ddlAlt" CssClass="form-control" runat="server" AutoPostBack="True" ></asp:DropDownList></td>
        </tr>
          </asp:Panel> 
       <tr>
            <td>Resim Güncelle</td>
            <td>
                <asp:DropDownList ID="ddlResim" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlResim_SelectedIndexChanged"  >
                    <asp:ListItem Value="1">Evet</asp:ListItem>
                    <asp:ListItem Value="0" Selected="True">Hayır</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <asp:Panel ID="Panel2" Visible="false" runat="server">
             <tr>
            <td>Makale Rersim</td>
            <td>
                <asp:FileUpload ID="fuMakaleResim" CssClass="form-control-file" runat="server" /></td>
        </tr>
        <tr>
            <td>Slider Rersim</td>
            <td>
                <asp:FileUpload ID="fuMakaleSliderResim"  CssClass="form-control-file" runat="server" /> Slider İçin 1200x500 Zorunludur</td>
        </tr>
        </asp:Panel>

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
                <asp:Button ID="btnEkle" runat="server" Text="Güncelle" CssClass="btn btn-success form-control w-50 " OnClick="btnEkle_Click"  />
            </td>
        </tr>



    </table>
</asp:Content>

