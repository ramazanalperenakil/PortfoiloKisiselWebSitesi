using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Makale_Ekle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataTable dt = kod.GetDataTable("Select * from makaleKategori");
            ddlAna.DataSource = dt;
            ddlAna.DataValueField = "makaleKategoriId";
            ddlAna.DataTextField = "makalekategoriAd";
            ddlAna.DataBind();

            DataTable dt2 = kod.GetDataTable("Select * from makaleAltKategori  WHERE makaleKategoriId=" + ddlAna.SelectedValue);
            ddlAlt.DataSource = dt2;
            ddlAlt.DataValueField = "makaleAltKategori";
            ddlAlt.DataTextField = "makaleAltKategoriAd";
            ddlAlt.DataBind();
        }

    }

    protected void ddlAna_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt2 = kod.GetDataTable("Select * from makaleAltKategori  WHERE makaleKategoriId=" + ddlAna.SelectedValue);
        ddlAlt.DataSource = dt2;
        ddlAlt.DataValueField = "makaleAltKategori";
        ddlAlt.DataTextField = "makaleAltKategoriAd";
        ddlAlt.DataBind();
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            string makaleAd = txtMakaleAd.Text, makaleResim = "", sliderResim = "", makaleOzet = txtMakaleOzet.Text, makaleIcerik = txtProjeBilgi.Text, kategori = ddlAna.SelectedValue, altKat = ddlAlt.SelectedValue, durum = ddlDurum.SelectedValue, onad = ddlAna.SelectedItem.Text;
            string donuştur = makaleAd;
            if (fuMakaleResim.HasFile && fuMakaleSliderResim.HasFile)
            {
                string url = kod.KodOlustur(donuştur);
                makaleResim = kod.MakaleKaydet(fuMakaleResim, 500,500, "/img/makaleler/", url);
                sliderResim = kod.SliderKaydet(fuMakaleSliderResim, 1200, 500, "/img/makaleler/slider/", url);
                kod.komut("Insert Into makaleler (makaleAd, makaleOzet, makaleİcerik, makaleResimUrl,makaleTarih,makaleAltKategori,makaleDurum,makaleSliderResimUrl) Values('" + txtMakaleAd.Text.Replace("'", "''") + "', '" + txtMakaleOzet.Text.Replace("'", "''") + "', '" + txtProjeBilgi.Text.Replace("'", "''") + "' , '" + makaleResim + "','" + DateTime.Now.ToString("MM/dd/yyyy").ToString() + "','" + altKat + "','" + durum + "','" + sliderResim + "')");
                lblDurum.Visible = true;
            }
        }
        catch 
        {

            LblHata.Visible = true;
        }
    }
}