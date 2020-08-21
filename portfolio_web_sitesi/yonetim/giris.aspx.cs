using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

public partial class yonetim_giris : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["kullanici"] != null)
        {
            Response.Redirect("Default.aspx");

        }
    }

    protected void btnGiris_Click(object sender, EventArgs e)
    {
        string kullanici = txtKullaniciAdi.Text, sifre = txtSifre.Text;

        // kod.Sifrele(sifre);
        string sifrem = FormsAuthentication.HashPasswordForStoringInConfigFile(sifre, "MD5");
        DataTable dt = kod.GetDataTable("Select * from kullanici where (uyeAd='" + kullanici + "' AND uyeSifre='" + sifrem + "' )"); /*AND uyeTuru='admin'*/

        if (dt.Rows.Count == 0)
        {
            lblHata.Visible = true;
        }
        else
        {
            Session["kullanici"] = kullanici;
            Response.Redirect("Default.aspx");
        }

    }
}