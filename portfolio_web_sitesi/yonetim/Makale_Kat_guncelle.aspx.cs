using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class yonetim_Makale_Kat_guncelle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("Makale_Kat_Duzenle.aspx");
        }
        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from MakaleKategori where makaleKategoriId=" + Request.QueryString["id"].ToString());
            txtKategori.Text = dr[1].ToString();

            
        }
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {

            kod.komut("UPDATE MakaleKategori set makalekategoriAd='" + txtKategori.Text + "'where makaleKategoriId=" + Request.QueryString["id"].ToString());
            lblDurum.Visible = true;
        }
        catch 
        {

            LblHata.Visible = true;
        }
    }
}