using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Hizmetler_Guncelle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("Hizmetler_Duzenle.aspx");
        }
        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from hizmetler where id=" + Request.QueryString["id"].ToString());
            txtHizmetAdi.Text = dr[1].ToString();
           
            txtHizmetBilgi.Text = dr[3].ToString();
            ddlSayfa.SelectedValue = dr[4].ToString();

            Repeater1.DataSource = kod.GetDataTable("select hizmetResimUrlsi from hizmetler WHERE id="+ Request.QueryString["id"].ToString());
            Repeater1.DataBind();

            fuDosya.Visible = false;
        }
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            string hizmetAdi = txtHizmetAdi.Text, url = "", hizmetOzellik = txtHizmetBilgi.Text, sayfa = ddlSayfa.SelectedValue;
            if (ddlFotoSecim.SelectedValue == "1")
            {
                if (fuDosya.HasFile)
                {

                    url = kod.fotoKaydet(fuDosya, 640, "/img/hizmetlerimiz/anasayfaHizmet/");
                    kod.komut("UPDATE hizmetler set hizmetAdi='" + txtHizmetAdi.Text.Replace("'", "''") + "', hizmetResimUrlsi='" + url + "', hizmetOzellik='" + txtHizmetBilgi.Text.Replace("'", "''") + "', hizmetDetayUrl='" + sayfa + "' WHERE id=" + Request.QueryString["id"].ToString());
                    lblDurum.Visible = true;
                }
            }
            else
            {
                if (!fuDosya.HasFile)
                {

                    kod.komut("UPDATE hizmetler set hizmetAdi='" + txtHizmetAdi.Text.Replace("'", "''") + "',hizmetOzellik='" + txtHizmetBilgi.Text.Replace("'", "''") + "', hizmetDetayUrl='" + sayfa + "' WHERE id=" + Request.QueryString["id"].ToString());
                    lblDurum.Visible = true;
                }

            }
        }
        catch 
        {
            LblHata.Visible = true;
        }
    }

    protected void ddlFotoSecim_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlFotoSecim.SelectedValue =="1")
        {
            fuDosya.Visible = true;

        }
        else
        {
            fuDosya.Visible = false;
        }
    }
}