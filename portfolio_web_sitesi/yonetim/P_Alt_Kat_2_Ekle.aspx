<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="P_Alt_Kat_2_Ekle.aspx.cs" Inherits="yonetim_P_Alt_Kat_2_Ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2 class="text-center mb-3 p-2">Proje Alt Kategorinin Alt Kategorisini Ekle </h2>
    <table class="table mx-auto" style="max-width: 500px">
        <tr>
            <td>Proje  Alt Kategorinin Alt Kategori Adı</td>
            <td>
                <asp:TextBox ID="txtKategori" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Proje Ana Kategori Adı
                </td>
            <td>
                <asp:DropDownList ID="ddlAna" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlAna_SelectedIndexChanged" AutoPostBack="True" ></asp:DropDownList>
            </td>
           
        </tr>
        
            <tr>
                <td>Proje Üst Kategori Adı</td>
                <td>
                    <asp:DropDownList ID="ddlAltKategori"  CssClass="form-control" runat="server" >
                        <asp:ListItem ></asp:ListItem>
                    </asp:DropDownList>
                    
      
                </td>
            </tr>

        

        <tr>
            <td colspan="2" class="text-center">
                <asp:Label ID="lblDurum" runat="server" Text="Kayıt Başarılı" Visible="false" CssClass="form-control alert-success"></asp:Label>
                 <asp:Label ID="LblHata" runat="server" Text="Bir Hata Oluştu" Visible="false" CssClass="form-control alert alert-danger"></asp:Label>
                <asp:Button ID="btnEkle" runat="server" Text="Proje Alt Kategori Ekle" CssClass="btn btn-success form-control w-50 " OnClick="btnEkle_Click"  />
            </td>
        </tr>



    </table>


</asp:Content>

