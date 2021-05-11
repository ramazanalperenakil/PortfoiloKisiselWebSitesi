using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class iletisim : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        RepeaterİletisimBilgileri.DataSource = kod.GetDataTable("SELECT *  FROM [bilgi]");
        RepeaterİletisimBilgileri.DataBind();
        RepeaterSayflarİframae.DataSource = kod.GetDataTable("SELECT *  FROM [sayfalar] WHERE [sayfaAd] = 'Benimle İletişime Geçin'");
        RepeaterSayflarİframae.DataBind();
       

    }

    protected void btnGonder_Click(object sender, EventArgs e)
    {
       try
       { 
            string adSoyad = txtAdSoyad.Text;
            string konu = "Kişisel Web Sitesi İletişim";
            string epostaAdresi = txtEmail.Text;
            string mesaji = txtMesaj.Text;
            string ipAdresi = ""; 
            if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
                ipAdresi = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
                ipAdresi = HttpContext.Current.Request.UserHostAddress;

            string mesajIcerik = "";
            mesajIcerik += "<b>İletişim Formundan Gelen Mesaj</b> / " + DateTime.Now.ToString() + " / " + ipAdresi + "<br/>";
            mesajIcerik += "<b>Adı Soyadı: </b>" + adSoyad + "<br/>";
            mesajIcerik += "<b>E-posta: </b>" + epostaAdresi + "<br/>";
            mesajIcerik += "<b>Konu: </b>" + konu + "<br/>";
            mesajIcerik += "<b>İleti: </b>" + mesaji;

            MailMessage yeniMesaj = new MailMessage();
            yeniMesaj.IsBodyHtml = true;
            yeniMesaj.To.Add("ramazanalperenakilkmu@gmail.com");
            yeniMesaj.From = new MailAddress("@gmail.com", "Site İletişim", System.Text.Encoding.UTF8); 
            yeniMesaj.Subject = konu+ " - " + adSoyad  ; 
            yeniMesaj.Body = mesajIcerik + "<br/>" + "<br/>" +"Gönderen İp: " +ipAdresi;

            SmtpClient gonder = new SmtpClient();
            gonder.Credentials = new NetworkCredential("@gmail.com", "");
            gonder.Port = 587; 
            gonder.Host = "smtp.gmail.com"; 
            gonder.EnableSsl = true;
            gonder.Send(yeniMesaj);
            lblBilgi.Visible = true;
            lblBilgi.Text = "Mesajınız Başarıyla Gönderildi!";
            lblBilgi.ForeColor = System.Drawing.ColorTranslator.FromHtml("#00a186");
        }
        catch
        {
            lblBilgi.Text = "Mesajınız gönderilirken bir hata oluştu, lütfen daha sonra tekrar deneyin.";
            lblBilgi.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff4081");
        }
        finally
        {
            txtAdSoyad.Text = "";
            txtEmail.Text = "";
            txtMesaj.Text = "";
        }
    }
}
