<%@ Page Title="" Language="C#" MasterPageFile="~/yonetim/yonetim.master" AutoEventWireup="true" CodeFile="Footer_Duzenle.aspx.cs" Inherits="yonetim_Footer_Duzenle" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <h2 class="text-center mb-3 p-2">Footer Düzenle</h2>
 
    
    <table class="table mx-auto" style="max-width:800px" >
   
    <th colspan="4">Footer Hakkımda</th>
           <tr>
               
               <td colspan="4">   <asp:TextBox ID="txtFooterHakkimda" CssClass="form-control" runat="server" TextMode="MultiLine" Width="800"></asp:TextBox></td>     </tr>
          <tr>
            <td>Facebook URL</td>
            <td><asp:TextBox ID="txtFacebook"  CssClass="form-control" runat="server"></asp:TextBox></td>
                <td>İnstagram URL</td>
            <td><asp:TextBox ID="txtInstagram"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
            <tr>
            <td>Linkedin URL</td>
            <td><asp:TextBox ID="txtLinkedin"  CssClass="form-control" runat="server"></asp:TextBox></td>
                <td>Footer Adres</td>
            <td><asp:TextBox ID="txtAdres"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>

          <tr>
            <td>Footer E-Posta 1</td>
            <td><asp:TextBox ID="txtEPosta1"  CssClass="form-control" runat="server"></asp:TextBox></td>
              <td>Footer E-Posta 2</td>
            <td><asp:TextBox ID="txtEPosta2"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>

            <tr>
            <td>Footer Telefon</td>
            <td><asp:TextBox ID="txtTel"  CssClass="form-control" runat="server"></asp:TextBox></td>
                <td>Footer Telif Hakkı Yazısı</td>
            <td><asp:TextBox ID="txtYazi"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>

            <tr >
            <td>Footer copyright</td>
            <td><asp:TextBox ID="txtCop"  CssClass="form-control" runat="server"></asp:TextBox></td>
                <td>Twitter URL</td>
            <td><asp:TextBox ID="txtTwitterUrl"  CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>


        <tr>
            <td colspan="4" class="text-center">
                <asp:Label ID="lblDurum" runat="server" Text="Güncelleme Başarılı" Visible="false" CssClass="form-control alert-success"></asp:Label>
                  <asp:Label ID="LblHata" runat="server" Text="Bir Hata Oluştu" Visible="false" CssClass="form-control alert alert-danger"></asp:Label>
                
            </td>
        </tr>
         <tr>
             <td colspan="4">
                 <asp:Button ID="btnEkle" runat="server" Text="Güncelle" CssClass="btn btn-success w-100 container" OnClick="btnEkle_Click"  />
             </td>
         </tr>
    </table>
   

</asp:Content>

