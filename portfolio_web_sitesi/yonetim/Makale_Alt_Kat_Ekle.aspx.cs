using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Makale_Alt_Kat_Ekle : System.Web.UI.Page
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

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            string katAd = txtKategori.Text, UstKategori = ddlAltKategori.SelectedValue;
            kod.komut("Insert Into makaleAltKategori (makaleAltKategoriAd, makaleKategoriId) Values('" + katAd + "', '" + UstKategori + "')");
            lblDurum.Visible = true;
        }
        catch 
        {

            LblHata.Visible = true;
        }
    }
}