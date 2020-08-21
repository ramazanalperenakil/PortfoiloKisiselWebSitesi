using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class yonetim_P_Alt_Kat_guncelle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("P_Alt_Kat_guncelle.aspx");
        }
        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from altkategori where altKategoriId=" + Request.QueryString["id"].ToString());
            txtKategori.Text = dr[1].ToString();
            KayitliKategori.Text= dr[3].ToString();
            DataRow drAna = kod.GetDataRow("Select * from kategoriler where kategoriId=" + dr[3].ToString());
            KayitliKategori.Text = drAna[1].ToString();
            ddlAltKategori.DataSource = kod.GetDataTable("Select * from kategoriler");
            ddlAltKategori.DataValueField = "kategoriId";
            ddlAltKategori.DataTextField = "kategoriAd";
            ddlAltKategori.DataBind();
        }

    }

    protected void ddlEH_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlEH.SelectedValue == "1")
        {
            Panel1.Visible = true;
        }

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            if (ddlEH.SelectedValue == "1")
            {
                kod.komut("UPDATE altkategori set altKategoriAd='" + txtKategori.Text + "',kategoriId= '" + ddlAltKategori.SelectedItem.Value.ToString() + "' where altKategoriId=" + Request.QueryString["id"].ToString());
                lblDurum.Visible = true;
            }
            else
            {
                kod.komut("UPDATE altkategori set altKategoriAd='" + txtKategori.Text + "' where altKategoriId=" + Request.QueryString["id"].ToString());
                lblDurum.Visible = true;
            }
        }
        catch 
        {

            LblHata.Visible = true;
        }
        
    }
}