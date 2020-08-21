<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Proje_Duzenle.aspx.cs" Inherits="yonetim_Proje_Duzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2 class="text-center mb-3 p-2">Proje  İşlemleri</h2>
   

    <table class="table mx-auto" style="max-width: 500px">

        <tr>
            <td>Proje Adı</td>
           
            <td>Güncelle</td>
            <td>Sil</td>
        </tr>

        <asp:Repeater ID="listeleRepeater" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("projeAd")%></td>  
                  
                   
                    <td><a href="Proje_Guncelle.aspx?id=<%#Eval("projeId")%>">  <img src="../img/icon/duzenle.png" width="32" /></a>
                      </td>
                    <td><a href="Proje_Duzenle.aspx?id=<%#Eval("projeId")%>&islem=sil" onclick="return confirm('Kayıt Silmek İstediğinizden Emin Misiniz ? ' )">
                        <img src="../img/icon/sil.png" width="32" /></a></td>
                </tr>
            </ItemTemplate>

        </asp:Repeater>

    </table>
</asp:Content>

