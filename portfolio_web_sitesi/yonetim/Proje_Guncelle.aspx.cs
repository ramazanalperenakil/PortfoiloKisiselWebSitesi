using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class yonetim_Proje_Guncelle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("Proje_Duzenle.aspx");
        }
        if (!Page.IsPostBack)
        {
            Panel1.Visible = false;
            getir();
            DataRow drana = kod.GetDataRow("Select * from proje WHERE projeId=" + Request.QueryString["id"].ToString());
            txtProjeAd.Text = drana[1].ToString();
            txtProjeFiyat.Text = drana[2].ToString();
            txtProjeBilgi.Text = drana[3].ToString();


            DataRow dr = kod.GetDataRow("Select * from altKategorininAltKategorisi where altKategorininAltKategori_Id=" + drana[6].ToString());
            txtEnALt.Text = dr[1].ToString();
            txtAlt.Text = dr[2].ToString();
            DataRow drAna = kod.GetDataRow("Select * from altkategori where altKategoriId=" + dr[2].ToString());
            txtAlt.Text = drAna[1].ToString();
            DataRow drust = kod.GetDataRow("Select * from kategoriler where kategoriId=" + drAna[3].ToString());
            txtAna.Text = drust[1].ToString();

        }
    }

    protected void ddlEH_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        DataTable dt = kod.GetDataTable("Select * from kategoriler");
        ddlAna.DataSource = dt;
        ddlAna.DataValueField = "kategoriId";
        ddlAna.DataTextField = "kategoriAd";
        ddlAna.DataBind();
    }

    protected void ddlAna_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt = kod.GetDataTable("Select * from altkategori  WHERE kategoriId=" + ddlAna.SelectedValue);
        ddlAlt.DataSource = dt;
        ddlAlt.DataValueField = "altKategoriId";
        ddlAlt.DataTextField = "altKategoriAd";
        ddlAlt.DataBind();
        DataTable dt2 = kod.GetDataTable("Select * from altKategorininAltKategorisi  WHERE altKategoriId=" + ddlAlt.SelectedItem.Value);
        ddlEnAlt.DataSource = dt2;
        ddlEnAlt.DataValueField = "altKategorininAltKategori_Id";
        ddlEnAlt.DataTextField = "altKategorininAltKategoriAdi";
        ddlEnAlt.DataBind();


    }

    protected void ddlAlt_SelectedIndexChanged(object sender, EventArgs e)
    {
        DataTable dt = kod.GetDataTable("Select * from altKategorininAltKategorisi  WHERE altKategoriId=" + ddlAlt.SelectedItem.Value);
        ddlEnAlt.DataSource = dt;
        ddlEnAlt.DataValueField = "altKategorininAltKategori_Id";
        ddlEnAlt.DataTextField = "altKategorininAltKategoriAdi";
        ddlEnAlt.DataBind();

    }

    private void getir()
    {
        DataTable dt = kod.GetDataTable("Select * from kategoriler");
        ddlAna.DataSource = dt;
        ddlAna.DataValueField = "kategoriId";
        ddlAna.DataTextField = "kategoriAd";
        ddlAna.DataBind();
        DataTable dt2 = kod.GetDataTable("Select * from altkategori  WHERE kategoriId=" + ddlAna.SelectedValue);
        ddlAlt.DataSource = dt2;
        ddlAlt.DataValueField = "altKategoriId";
        ddlAlt.DataTextField = "altKategoriAd";
        ddlAlt.DataBind();
        DataTable dt3 = kod.GetDataTable("Select * from altKategorininAltKategorisi  WHERE altKategoriId=" + ddlAlt.SelectedItem.Value);
        ddlEnAlt.DataSource = dt3;
        ddlEnAlt.DataValueField = "altKategorininAltKategori_Id";
        ddlEnAlt.DataTextField = "altKategorininAltKategoriAdi";
        ddlEnAlt.DataBind();

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {

            string projeAd = txtProjeAd.Text, projeFiyat = txtProjeFiyat.Text, projeBilgisi = txtProjeBilgi.Text, projeYeniKat = ddlAna.SelectedValue, projeYeniAltKat = ddlAlt.SelectedValue, ProjeEnAlt = ddlEnAlt.SelectedValue, durum = ddlDurum.SelectedValue;
            if (ddlEH.SelectedValue == "1")
            {
                if (ddlDurumFoto.SelectedValue == "1")
                {
                    kod.komut("UPDATE proje set altKategoriId='" + projeYeniAltKat + "', altKategorininAltKategori_Id='" + ProjeEnAlt + "' WHERE projeId=" + Request.QueryString["id"].ToString());
                    Response.Redirect("urunFoto.aspx?uId=" + Request.QueryString["id"].ToString());
                    lblDurum.Visible = true;
                }
                else
                {
                    kod.komut("UPDATE proje set altKategoriId='" + projeYeniAltKat + "', altKategorininAltKategori_Id='" + ProjeEnAlt + "' WHERE projeId=" + Request.QueryString["id"].ToString());
                    lblDurum.Visible = true;
                }
            }
            else if (ddlEH.SelectedValue == "0")
            {
                if (ddlDurumFoto.SelectedValue == "1")
                {
                    Response.Redirect("urunFoto.aspx?uId=" + Request.QueryString["id"].ToString());
                }
                else
                {

                    kod.komut("UPDATE proje set projeAd='" + txtProjeAd.Text.Replace("'", "''") + "', projeFiyat='" + txtProjeFiyat.Text.Replace("'", "''") + "', projeBilgi='" + txtProjeBilgi.Text.Replace("'", "''") + "', projeDurum='" + durum + "' WHERE projeId=" + Request.QueryString["id"].ToString());
                    lblDurum.Visible = true;
                }
            }
        }
        catch (Exception)
        {

            LblHata.Visible = true;
        }
    }




}
