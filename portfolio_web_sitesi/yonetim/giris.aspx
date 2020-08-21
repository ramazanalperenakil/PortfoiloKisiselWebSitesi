<%@ Page Language="C#" AutoEventWireup="true" CodeFile="giris.aspx.cs" Inherits="yonetim_giris" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html;" />
    <title>Yönetim Paneli Giriş Ekranı</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="icon" href="img/favicon.png" type="image/png">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../stiller/yonetim.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.0.0.slim.min.js"></script>
    <script src="../Scripts/popper.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="sidenav bg-dark">
        <div class="login-main-text">
            <h2>Ramazan ALperen AKIL <br>
                Kişisel Web Sitesi</h2>
            <p>Giriş Ekranı</p>
        </div>
    </div>
    <div class="main">
        <div class="col-md-6 col-sm-12">
            
            <div class="login-form pt-3">
                <form>
                    <div class="form-group">
                        <label>Kullanıcı Adı</label>
                        <asp:TextBox ID="txtKullaniciAdi" CssClass="form-control" runat="server"></asp:TextBox>
                        <%--<input type="text" class="form-control" placeholder="User Name">--%>
                    </div>
                    <div class="form-group">
                        <label>Şifre</label>
                        <asp:TextBox ID="txtSifre" CssClass="form-control"  TextMode="Password" runat="server"></asp:TextBox>
                        <asp:Label ID="lblHata" runat="server" Text="Girişte Hata Var" CssClass="alert-danger form-control"  ForeColor="red" Visible="false"></asp:Label>
                       <%-- <input type="password" class="form-control" placeholder="Password">--%>
                    </div>
                    <asp:Button ID="btnGiris" runat="server" Text="Giriş Yap" CssClass="btn btn-lg btn-outline-success" OnClick="btnGiris_Click"/>

                </form>
            </div>
        </div>
    </div>
        </div>
    </form>
    
</body>
</html>
