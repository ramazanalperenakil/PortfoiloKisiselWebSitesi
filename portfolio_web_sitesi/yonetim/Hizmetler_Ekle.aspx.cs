using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Hizmetler_Ekle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {

            string hizmetAdi = txtHizmetAdi.Text, url = "", hizmetOzellik = txtHizmetBilgi.Text, sayfa = ddlSayfa.SelectedValue;
            if (fuDosya.HasFile)
            {

                url = kod.fotoKaydet(fuDosya, 640, "/img/hizmetlerimiz/anasayfaHizmet/");
                kod.komut("Insert Into hizmetler (hizmetAdi, hizmetResimUrlsi, hizmetOzellik, hizmetDetayUrl) Values('" + txtHizmetAdi.Text.Replace("'", "''") + "', '" + url + "', '" + txtHizmetBilgi.Text.Replace("'", "''") + "' , '" + sayfa + "')");
                lblDurum.Visible = true;
            }
        }
        catch
        {

            LblHata.Visible = true;
        }
    }
}