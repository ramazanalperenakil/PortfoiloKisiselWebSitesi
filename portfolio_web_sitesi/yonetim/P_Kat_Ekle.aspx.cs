using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_P_Kat_Ekle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        string katAd = txtKategori.Text, url = "", durum = ddlDurum.SelectedValue;

        kod.komut("Insert Into kategoriler (kategoriAd, kategoriFoto, kategoriAnasayfa) Values('" + katAd + "', '" + url + "', '" + durum + "')");
        lblDurum.Visible = true; try
        {

        }
        catch 
        {

            LblHata.Visible = true;
        }

    }
}