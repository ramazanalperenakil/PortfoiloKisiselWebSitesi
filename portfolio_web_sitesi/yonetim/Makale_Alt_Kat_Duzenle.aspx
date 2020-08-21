<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Makale_Alt_Kat_Duzenle.aspx.cs" Inherits="yonetim_Makale_Alt_Kat_Duzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2 class="text-center mb-3 p-2">Makale Alt Kategori İşlemleri</h2>
    <table class="table mx-auto" style="max-width: 500px">

        <tr>
            <td>Makale Alt Kategori Adı</td>
            
           
            <td>Güncelle</td>
            <td>Sil</td>
        </tr>

        <asp:Repeater ID="listeleRepeater" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("makaleAltKategoriAd")%></td>

                   


                    <td><a href="Makale_AltKategori_Guncelle.aspx?id=<%#Eval("makaleAltKategori")%>">
                        <img src="../img/icon/duzenle.png" width="32" /></a>
                    </td>
                    <td><a href="Makale_Alt_Kat_Duzenle.aspx?id=<%#Eval("makaleAltKategori")%>&islem=sil" onclick="return confirm('Kayıt Silmek İstediğinizden Emin Misiniz ? ' )">
                        <img src="../img/icon/sil.png" width="32" /></a></td>
                </tr>
            </ItemTemplate>

        </asp:Repeater>

    </table>
</asp:Content>

