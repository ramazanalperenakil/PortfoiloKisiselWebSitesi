<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="UrunFoto.aspx.cs" Inherits="yonetim_UrunFoto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2 class="text-center mb-3 p-2">Proje Foto Ekle</h2>
    <table class="table mx-auto" style="max-width: 600px">
        <tr>
            <th>Proje Foto</th>
            <th>Sil</th>
        </tr>
        <asp:Repeater ID="RepeaterUrunFoto" runat="server">
            <ItemTemplate>
                <tr>
                    <td><asp:Image ID="ImageFoto" Width="150" ImageUrl='<%#Eval("projeGorselUrlKucuk") %>' runat="server" /></td>
                    <td><a href="UrunFoto.aspx?id=<%#Eval("projeGorselId")%>&islem=sil&uId=<%#Eval("projeId")%>" onclick="return confirm('Kayıt Silmek İstediğinizden Emin Misiniz ? ' )">
                        <img src="../img/icon/sil.png" width="32" /></a></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        <tr>
            <td>Proje Foto Ekle</td>
            <td><asp:FileUpload ID="fuDosya" CssClass="form-control-file" runat="server" /></td>
        </tr>
         <tr>
            <td colspan="2" class="text-center">
                <asp:Label ID="lblDurum" runat="server" Text="Kayıt Başarılı" Visible="false" CssClass="form-control alert-success"></asp:Label>
                 <asp:Label ID="LblHata" runat="server" Text="Bir Hata Oluştu" Visible="false" CssClass="form-control alert alert-danger"></asp:Label>
                <asp:Button ID="btnEkle" runat="server" Text="Kayıt Ekle" CssClass="btn btn-success form-control w-50 " OnClick="btnEkle_Click"   />
            </td>
        </tr>
    </table>
</asp:Content>

