<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Yetenek_Ekle.aspx.cs" Inherits="yonetim_Yetenek_Ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="text-center mb-3 p-2">Yetenek Ekle</h2>
    <table class="table mx-auto" style="max-width:500px">
        <tr>
            <td>Yetenek Adı</td>
            <td><asp:TextBox ID="txtYetenekAdi" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Yetenek Oranı</td>
            <td><asp:TextBox ID="txtYetenekOrani"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2" class="text-center">
                <asp:Label ID="lblDurum" runat="server" Text="Kayıt Başarılı" Visible="false" CssClass="form-control alert-success"></asp:Label>
                 <asp:Label ID="LblHata" runat="server" Text="Bir Hata Oluştu" Visible="false" CssClass="form-control alert alert-danger"></asp:Label>
                <asp:Button ID="btnEkle" runat="server" Text="Yetenek Ekle" CssClass="btn btn-success form-control w-50 " OnClick="btnEkle_Click" />
            </td>
        </tr>



    </table>
</asp:Content>

