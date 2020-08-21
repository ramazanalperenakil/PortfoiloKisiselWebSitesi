<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="P_Alt_Kat_2_guncelle.aspx.cs" Inherits="yonetim_P_Alt_Kat_2_guncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h2 class="text-center mb-3 p-2">Proje Alt Kategorinin Alt Kategorisini Güncelle </h2>
    <table class="table mx-auto" style="max-width: 500px">
        <tr >
            <td>Proje  Alt Kategorinin Alt Kategori Adı</td>
            <td>
                <asp:TextBox ID="txtKategori" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
       
        <tr>
            <td>Proje  Alt Kategorinin ANA Kategori Adı</td>
            <td>
                <asp:TextBox ID="txtAna" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Proje  Alt Kategorinin Üst Kategori Adı</td>
            <td>
                <asp:TextBox ID="txtUst" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
       
      
        <tr>
            <td>Mevcut Kategoriyi Güncellemek</td>
            <td>
                <asp:DropDownList ID="ddlEH" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlEH_SelectedIndexChanged">
                    <asp:ListItem Value="1">Evet</asp:ListItem>
                    <asp:ListItem Selected="True" Value="0">Hayır</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        
       
        <asp:Panel ID="Panel3" runat="server">
        <tr>
            <td>Proje Ana Kategori Adı
            </td>
            <td>

              
                <asp:DropDownList ID="ddlAna" OnSelectedIndexChanged="ddlAna_SelectedIndexChanged" CssClass="form-control" runat="server" AutoPostBack="true"></asp:DropDownList>
            </td>

        </tr>

        <tr>
            <td>Proje Alt Kategori Adı</td>
            <td>
                <asp:DropDownList ID="ddlAltKategori" CssClass="form-control" runat="server">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>


            </td>
        </tr>

       </asp:Panel>

        <tr>
            <td colspan="2" class="text-center">
                <asp:Label ID="lblDurum" runat="server" Text="Güncelleme Başarılı" Visible="false" CssClass="form-control alert-success"></asp:Label>
                 <asp:Label ID="LblHata" runat="server" Text="Bir Hata Oluştu" Visible="false" CssClass="form-control alert alert-danger"></asp:Label>
                <asp:Button ID="btnEkle" runat="server" Text="Proje Alt Kategorinin Alt Kategorisini Güncelle" CssClass="btn btn-success form-control w-75 " OnClick="btnEkle_Click" />
            </td>
        </tr>



    </table>

</asp:Content>

