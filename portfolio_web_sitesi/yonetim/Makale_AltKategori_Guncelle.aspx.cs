using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Makale_AltKategori_Guncelle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            ddlAltKategori.DataSource = kod.GetDataTable("Select * from makaleKategori ");
            ddlAltKategori.DataValueField = "makaleKategoriId";
            ddlAltKategori.DataTextField = "makalekategoriAd";
            ddlAltKategori.DataBind();
        }

        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("Sayfalar_Duzenle.aspx");
        }
        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from makaleAltKategori where makaleAltKategori=" + Request.QueryString["id"].ToString());
            txtKategori.Text = dr[1].ToString();
            ddlAltKategori.SelectedValue = dr[2].ToString();

            
        }
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            string katAd = txtKategori.Text, UstKategori = ddlAltKategori.SelectedValue;
            kod.komut("UPDATE makaleAltKategori set makaleAltKategoriAd='" + katAd + "', makaleKategoriId='" + UstKategori + "' WHERE makaleAltKategori=" + Request.QueryString["id"] + "");
            lblDurum.Visible = true;
        }
        catch (Exception)
        {

            LblHata.Visible = true;
        }
    }
}