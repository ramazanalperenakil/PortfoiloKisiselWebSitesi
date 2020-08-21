<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="uyeDuzenle.aspx.cs" Inherits="yonetim_uyeDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2 class="text-center mb-3 p-2">Üye İşlemleri</h2>
    <table class="table mx-auto" style="max-width: 500px">

        <tr>
            <td>Üye Adı</td>
            <td>Üye şifre</td>
            <td>Üye Türü</td>
            <td>Avatar</td>
            <td>Üye Durum</td>
            <td>Güncelle</td>
            <td>Sil</td>
        </tr>

        <asp:Repeater ID="listeleRepeater" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("uyeAd")%></td>
                    <td><%#Eval("uyeSifre")%></td">
                    <td><%#Eval("uyeTuru")%></td>
                    <td><%#Eval("avatar")%></td>
                    <td><%#Eval("uyeDurum")%></td>
                    <td><a href="uyeIslem.aspx?id=<%#Eval("uyeId")%>">  <img src="../img/icon/duzenle.png" width="32" /></a>
                      </td>
                    <td><a href="uyeDuzenle.aspx?id=<%#Eval("uyeId")%>&islem=sil" onclick="return confirm('Kayıt Silmek İstediğinizden Emin Misiniz ? ' )">
                        <img src="../img/icon/sil.png" width="32" /></a></td>
                </tr>
            </ItemTemplate>

        </asp:Repeater>

    </table>
</asp:Content>

