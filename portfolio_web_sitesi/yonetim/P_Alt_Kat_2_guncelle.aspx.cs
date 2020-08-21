using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class yonetim_P_Alt_Kat_2_guncelle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("P_Alt_Kat_2_guncelle.aspx");
        }


        if (!Page.IsPostBack)
        {
            Panel3.Visible = false;
            DataRow dr = kod.GetDataRow("Select * from altKategorininAltKategorisi where altKategorininAltKategori_Id=" + Request.QueryString["id"].ToString());
            txtKategori.Text = dr[1].ToString();
            txtUst.Text = dr[2].ToString();
            DataRow drAna = kod.GetDataRow("Select * from altkategori where altKategoriId=" + dr[2].ToString());
            txtUst.Text = drAna[1].ToString();
            DataRow drust = kod.GetDataRow("Select * from kategoriler where kategoriId=" + drAna[3].ToString());
            txtAna.Text = drust[1].ToString();

        }
        

    }

    protected void ddlEH_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlEH.SelectedValue=="1")
        {
            Panel3.Visible = true;
     

            ddlAna.DataSource = kod.GetDataTable("Select * from kategoriler");
            ddlAna.DataValueField = "kategoriId";
            ddlAna.DataTextField = "kategoriAd";
            ddlAna.DataBind();
           
            

        }
        else
        {
          Panel3.Visible = false;

        }
       

    }

    protected void ddlAna_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlAltKategori.DataSource = kod.GetDataTable("Select * from altkategori  WHERE kategoriId=" + ddlAna.SelectedItem.Value);
        ddlAltKategori.DataValueField = "altKategoriId";
        ddlAltKategori.DataTextField = "altKategoriAd";
        ddlAltKategori.DataBind();
    }



    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            if (ddlEH.SelectedValue == "1")
            {


                kod.komut("UPDATE altKategorininAltKategorisi set altKategorininAltKategoriAdi='" + txtKategori.Text + "',altKategoriId= '" + ddlAltKategori.SelectedValue.ToString() + "' where altKategorininAltKategori_Id=" + Request.QueryString["id"].ToString());
                lblDurum.Visible = true;
            }
            else
            {
                kod.komut("UPDATE altKategorininAltKategorisi set altKategorininAltKategoriAdi='" + txtKategori.Text + "' where altKategorininAltKategori_Id=" + Request.QueryString["id"].ToString());
                lblDurum.Visible = true;
            }
        }
        catch 
        {

            LblHata.Visible = true;
        }

    }
}