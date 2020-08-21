using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_P_Alt_Kat_2_Ekle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ddlAna.DataSource = kod.GetDataTable("Select * from kategoriler ");
            ddlAna.DataValueField = "kategoriId";
            ddlAna.DataTextField = "kategoriAd";
            ddlAna.DataBind();

        }
        
    }



    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            string katAd = txtKategori.Text, ana = ddlAna.SelectedValue, UstKategori = ddlAltKategori.SelectedValue;
            kod.komut("Insert Into altKategorininAltKategorisi (altKategorininAltKategoriAdi, altKategoriId) Values('" + katAd + "', '" + UstKategori + "')");
            lblDurum.Visible = true;
        }
        catch 
        {

            LblHata.Visible = true;
        }
       

    }

    //protected void ddlAna_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    ddlAltKategori.DataSource = kod.GetDataTable("Select * from altkategori  WHERE kategoriId=" + ddlAna.SelectedItem.Value);
    //    ddlAltKategori.DataValueField = "altKategoriId";
    //    ddlAltKategori.DataTextField = "altKategoriAd";
    //    ddlAltKategori.DataBind();
    //}

   


    

    protected void ddlAna_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlAltKategori.DataSource = kod.GetDataTable("Select * from altkategori  WHERE kategoriId=" + ddlAna.SelectedItem.Value);
        ddlAltKategori.DataValueField = "altKategoriId";
        ddlAltKategori.DataTextField = "altKategoriAd";
        ddlAltKategori.DataBind();

    }

    
}