using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_uyeEkle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            string uyeAd = txtUyeAdi.Text, sifre = txtSifre.Text, tur = ddlUyeTuru.SelectedValue, durum = ddlDurum.SelectedValue, avatar = "";
            if (sifre == txtSifreTekrar.Text)
            {

                
                string sifrem = FormsAuthentication.HashPasswordForStoringInConfigFile(sifre, "MD5");
                kod.komut("insert into kullanici (uyeAd, uyeSifre, uyeTuru, avatar, uyeDurum) values('" + uyeAd + "', '" + sifrem + "','" + tur + "', '" + avatar + "', '" + durum + "')");

                lblDurum.Visible = true;
                lblDurum.Text = "başarılı";
                lblDurum.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblDurum.Visible = true;
                lblDurum.Text = "hata";
                lblDurum.ForeColor = System.Drawing.Color.Red;
            }
        }
        catch 
        {

            LblHata.Visible = true;
        }
    }
}