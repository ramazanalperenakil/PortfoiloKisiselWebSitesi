using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class yonetim_Makale_Guncelle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("Makale_Guncelle.aspx");
        }
        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from makaleler WHERE makaleId=" + Request.QueryString["id"]);
            txtMakaleAd.Text = dr[1].ToString();
            txtMakaleOzet.Text = dr[2].ToString();
            txtProjeBilgi.Text = dr[3].ToString();


            DataRow drAna = kod.GetDataRow("Select * from makaleAltKategori where makaleAltKategori=" + dr[6].ToString());
            txtalt.Text = drAna[1].ToString();
            DataRow drust = kod.GetDataRow("Select * from makaleKategori where makaleKategoriId=" + drAna[2].ToString());
            txtkat.Text = drust[1].ToString();

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

    protected void ddlEH_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlEH.SelectedValue == "1")
        {
            Panel1.Visible = true;
        }
        else
        {
            Panel1.Visible = false;
        }

    }

    protected void ddlResim_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlResim.SelectedValue == "1")
        {
            Panel2.Visible = true;
        }
        else
        {
            Panel2.Visible = false;
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
            string makaleAd = txtMakaleAd.Text, makaleOzet = txtMakaleOzet.Text, makaleIcerik = txtProjeBilgi.Text,
                makaleResimUrl = "", makaleTarih = DateTime.Now.ToString("MM/dd/yyyy").ToString(), makaleAltKategori = ddlAlt.SelectedValue, durum = ddlDurum.SelectedValue, makaleSliderResim = "";
            if (ddlEH.SelectedValue == "1")
            {
                if (ddlResim.SelectedValue == "1")
                {
                    //hem resim Hem kategori
                    string url = kod.KodOlustur(makaleAd);

                    kod.komut("UPDATE makaleler set makaleResimUrl='" + makaleResimUrl + "' , makaleSliderResimUrl='" + makaleSliderResim + "'  WHERE makaleId=" + Request.QueryString["id"].ToString());
                    makaleResimUrl = kod.FotoKaydetOptimize(fuMakaleResim, 284, "/img/makaleler/", url);
                    makaleSliderResim = kod.SliderKaydet(fuMakaleSliderResim, 1200, 500, "/img/makaleler/slider/", url);
                    kod.komut("UPDATE makaleler set makaleAd='" + txtMakaleAd.Text.Replace("'", "''") + "',makaleOzet='" + txtMakaleOzet.Text.Replace("'", "''") + "',makaleİcerik='" + txtProjeBilgi.Text.Replace("'", "''") + "',makaleResimUrl='" + makaleResimUrl + "',makaleTarih='" + makaleTarih + "',makaleAltKategori='" + makaleAltKategori + "',makaleDurum='" + durum + "',makaleSliderResimUrl='" + makaleSliderResim + "' WHERE makaleId=" + Request.QueryString["id"].ToString()); lblDurum.Visible = true;
                }
                else
                {
                    kod.komut("UPDATE makaleler set makaleAd='" + txtMakaleAd.Text.Replace("'", "''") + "',makaleOzet='" + txtMakaleOzet.Text.Replace("'", "''") + "',makaleİcerik='" + txtProjeBilgi.Text.Replace("'", "''") + "',makaleTarih='" + makaleTarih + "',makaleAltKategori='" + makaleAltKategori + "',makaleDurum='" + durum + "' WHERE makaleId=" + Request.QueryString["id"].ToString()); lblDurum.Visible = true;
                }

            }
            else if (ddlEH.SelectedValue == "0")
            {

                if (ddlResim.SelectedValue == "1")
                {
                    string url = kod.KodOlustur(makaleAd);
                    kod.komut("UPDATE makaleler set makaleResimUrl='" + makaleResimUrl + "' , makaleSliderResimUrl='" + makaleSliderResim + "'  WHERE makaleId=" + Request.QueryString["id"].ToString());
                    makaleResimUrl = kod.FotoKaydetOptimize(fuMakaleResim, 284, "/img/makaleler/", url);
                    makaleSliderResim = kod.SliderKaydet(fuMakaleSliderResim, 1200, 500, "/img/makaleler/slider/", url);
                    kod.komut("UPDATE makaleler set makaleAd='" + txtMakaleAd.Text.Replace("'", "''") + "',makaleOzet='" + txtMakaleOzet.Text.Replace("'", "''") + "',makaleİcerik='" + txtProjeBilgi.Text.Replace("'", "''") + "',makaleResimUrl='" + makaleResimUrl + "',makaleTarih='" + makaleTarih + "', makaleDurum='" + durum + "',makaleSliderResimUrl='" + makaleSliderResim + "' WHERE makaleId=" + Request.QueryString["id"].ToString()); lblDurum.Visible = true;
                }
                else
                {

                    kod.komut("UPDATE makaleler set makaleAd='" + txtMakaleAd.Text.Replace("'", "''") + "',makaleOzet='" + txtMakaleOzet.Text.Replace("'", "''") + "',makaleİcerik='" + txtProjeBilgi.Text.Replace("'", "''") + "',makaleTarih='" + makaleTarih + "',makaleDurum='" + durum + "' WHERE makaleId=" + Request.QueryString["id"].ToString()); lblDurum.Visible = true;
                }


            }


        }


        catch 
        {

            LblHata.Visible = true;
        }
    }
}