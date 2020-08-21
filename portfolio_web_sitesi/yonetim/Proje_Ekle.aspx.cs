using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class yonetim_Proje_Ekle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
             getir();
            
        }
    }

   

    protected void ddlAna_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlAlt.DataSource = kod.GetDataTable("Select * from altkategori  WHERE kategoriId=" + ddlAna.SelectedItem.Value);
        ddlAlt.DataValueField = "altKategoriId";
        ddlAlt.DataTextField = "altKategoriAd";
        ddlAlt.DataBind();
        ddlEnAlt.DataSource = kod.GetDataTable("Select * from altKategorininAltKategorisi  WHERE altKategoriId=" + ddlAlt.SelectedItem.Value);
        ddlEnAlt.DataValueField = "altKategorininAltKategori_Id";
        ddlEnAlt.DataTextField = "altKategorininAltKategoriAdi";
        ddlEnAlt.DataBind();
    }

    protected void ddlAlt_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlEnAlt.DataSource = kod.GetDataTable("Select * from altKategorininAltKategorisi  WHERE altKategoriId=" + ddlAlt.SelectedItem.Value);
        ddlEnAlt.DataValueField = "altKategorininAltKategori_Id";
        ddlEnAlt.DataTextField = "altKategorininAltKategoriAdi";
        ddlEnAlt.DataBind();

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            string ProjeAd = txtProjeAd.Text, ProjeFiyat = txtProjeFiyat.Text, ProjeBilgi = txtProjeBilgi.Text, altKatId = ddlAlt.SelectedValue.ToString(), EnALtKat = ddlEnAlt.SelectedValue.ToString(), durum = ddlDurum.SelectedValue;
            kod.komut("Insert Into proje (projeAd,projeFiyat,projeBilgi,projeDurum,altKategoriId,altKategorininAltKategori_Id) Values('" + txtProjeAd.Text.Replace("'", "''") + "', '" + ProjeFiyat + "','" + txtProjeBilgi.Text.Replace("'", "''") + "', '" + durum + "', '" + altKatId + "', '" + EnALtKat + "')");
            lblDurum.Visible = true;
            string idAl = kod.getDataCell("Select Top 1 projeId from proje Order BY projeId Desc");
            Response.Redirect("urunFoto.aspx?uId=" + idAl);
        }
        catch 
        {

            LblHata.Visible = true;
        }
    }

    private void getir()
    {
        ddlAna.DataSource = kod.GetDataTable("Select * from kategoriler");
        ddlAna.DataValueField = "kategoriId";
        ddlAna.DataTextField = "kategoriAd";
        ddlAna.DataBind();
        ddlAlt.DataSource = kod.GetDataTable("Select * from altkategori  WHERE kategoriId=" + ddlAna.SelectedItem.Value);
        ddlAlt.DataValueField = "altKategoriId";
        ddlAlt.DataTextField = "altKategoriAd";
        ddlAlt.DataBind();
        ddlEnAlt.DataSource = kod.GetDataTable("Select * from altKategorininAltKategorisi  WHERE altKategoriId=" + ddlAlt.SelectedItem.Value);
        ddlEnAlt.DataValueField = "altKategorininAltKategori_Id";
        ddlEnAlt.DataTextField = "altKategorininAltKategoriAdi";
        ddlEnAlt.DataBind();
    }
}