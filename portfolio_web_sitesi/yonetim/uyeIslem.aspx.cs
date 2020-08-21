using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_uyeIslem : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("uyeDuzenle.aspx");
        }
        if(!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from kullanici where uyeId="+Request.QueryString["id"].ToString());
            txtUyeAdi.Text = dr[1].ToString();
            ddlUyeTuru.SelectedValue = dr[3].ToString();
            
            ddlDurum.SelectedValue = dr[5].ToString();

        }

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
          string  avatar = "/img/";
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                string sifrem = FormsAuthentication.HashPasswordForStoringInConfigFile(txtSifre.Text, "MD5");
                kod.komut("UPDATE kullanici Set uyeAd='" + txtUyeAdi.Text + "', uyeSifre='" + sifrem + "', uyeTuru='" + ddlUyeTuru.SelectedValue + "', avatar='" + avatar + "', uyeDurum='" + ddlDurum.SelectedValue + "' WHERE uyeId=" + Request.QueryString["id"].ToString());
                lblDurum.Text = "Güncelleme Başarılı";
                lblDurum.ForeColor = System.Drawing.Color.Green;
                lblDurum.Visible = true;

            }
            else
            {
                lblDurum.Text = "hata";
                lblDurum.ForeColor = System.Drawing.Color.Red;
                lblDurum.Visible = true;

            }
        }
        catch 
        {

            LblHata.Visible = true;
        }
    }
}