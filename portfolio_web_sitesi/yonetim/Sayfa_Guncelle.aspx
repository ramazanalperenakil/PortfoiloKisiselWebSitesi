<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Sayfa_Guncelle.aspx.cs" Inherits="yonetim_Sayfa_Guncelle" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 class="text-center mb-3 p-2">Sayfa Güncelle</h2>
    <table class="table mx-auto" style="max-width:500px">
        <tr>
            <td>Sayfa Adı</td>
            <td><asp:TextBox ID="txtSayfaAdi" CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Sayfa Metin</td>
            <td><asp:TextBox ID="txtSayfaMetin"  CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <asp:Panel ID="Panel1" runat="server">
        <tr>

            <td colspan="2">Mevcut Fotoğrafınız
           
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <img src="<%#Eval("sayfaResim")%>" class="img-fluid ml-5" height="100" width="100" />
                    </ItemTemplate>
                </asp:Repeater>
                  <asp:FileUpload ID="fuDosya" CssClass="form-control-file" runat="server" />
            </td>
        </tr>
        
        <tr>
             
            <td>Fotoğraf Güncellemek İstiyor Musunuz?</td>
            <td>
                <asp:DropDownList ID="ddlFotoSecim" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlFotoSecim_SelectedIndexChanged" CssClass="form-control">
                    <asp:ListItem Value="1">EVET</asp:ListItem>
                    <asp:ListItem Value="0" Selected="True">Hayır</asp:ListItem>
                </asp:DropDownList>
                
            </td>
        </tr>
        </asp:Panel>
        <tr>
            <td colspan="2" class="text-center">
                <asp:Label ID="lblDurum" runat="server" Text="Güncelleme Başarılı" Visible="false" CssClass="form-control alert-success"></asp:Label>
                 <asp:Label ID="LblHata" runat="server" Text="Bir Hata Oluştu" Visible="false" CssClass="form-control alert alert-danger"></asp:Label>
                <asp:Button ID="btnEkle" runat="server" Text="Güncelle" CssClass="btn btn-success form-control w-50 " OnClick="btnEkle_Click" />
            </td>
        </tr>



    </table>
</asp:Content>

