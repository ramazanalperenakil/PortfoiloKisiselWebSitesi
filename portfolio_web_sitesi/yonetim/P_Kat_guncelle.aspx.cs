using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_P_Kat_guncelle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("P_Kat_guncelle.aspx");
        }
        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from kategoriler where kategoriId=" + Request.QueryString["id"].ToString());
            txtKategori.Text = dr[1].ToString();


        }
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {

            kod.komut("UPDATE kategoriler set kategoriAd='" + txtKategori.Text + "'where kategoriId=" + Request.QueryString["id"].ToString());
            lblDurum.Visible = true;
        }
        catch 
        {

            LblHata.Visible = true;
        }
    }
}