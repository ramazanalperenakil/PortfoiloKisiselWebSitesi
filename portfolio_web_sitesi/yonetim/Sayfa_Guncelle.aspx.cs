using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Sayfa_Guncelle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == "2")
        {
            Panel1.Visible = false;
           
        }

        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("Sayfalar_Duzenle.aspx");
        }
        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from sayfalar where sayfaId=" + Request.QueryString["id"].ToString());
            txtSayfaAdi.Text = dr[1].ToString();
            txtSayfaMetin.Text = dr[2].ToString();

            Repeater1.DataSource = kod.GetDataTable("select sayfaResim from sayfalar WHERE sayfaId=" + Request.QueryString["id"].ToString());
            Repeater1.DataBind();
            fuDosya.Visible = false;
        }
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            string sayfaAd = txtSayfaAdi.Text, sayfaMetin = txtSayfaMetin.Text, url = "";
            string yeniveri = sayfaMetin.Replace("'", "-");
            if (ddlFotoSecim.SelectedValue == "1")
            {
                if (fuDosya.HasFile)
                {

                    url = kod.fotoKaydet(fuDosya, 690, "/img/sayfaResim/");

                    kod.komut("UPDATE sayfalar set sayfaAd='" + sayfaAd + "', sayfaMetin='" + yeniveri + "', sayfaResim='" + url + "' WHERE sayfaId=" + Request.QueryString["id"].ToString());
                    lblDurum.Visible = true;
                }
            }
            else
            {
                if (!fuDosya.HasFile)
                {
                    kod.komut("UPDATE sayfalar set sayfaAd='" + sayfaAd + "', sayfaMetin='" + sayfaMetin + "' WHERE sayfaId=" + Request.QueryString["id"].ToString());
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
        if (ddlFotoSecim.SelectedValue=="1")
        {
            fuDosya.Visible = true;
        }
        else
        {
            fuDosya.Visible = false;
        }
    }
}