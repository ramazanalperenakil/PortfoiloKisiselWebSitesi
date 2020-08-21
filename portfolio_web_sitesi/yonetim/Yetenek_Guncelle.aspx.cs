using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Yetenek_Guncelle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["id"] == null)
        {
            Response.Redirect("Yetenek_Duzenle.aspx");
        }
        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from yetenek where yetenekId=" + Request.QueryString["id"].ToString());
            txtYetenekAdi.Text= dr[1].ToString();
            txtYetenekOrani.Text= dr[2].ToString();
           

        }
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            kod.komut("UPDATE yetenek set yetenekAdi='" + txtYetenekAdi.Text + "', yetenekYuzdesi='" + txtYetenekOrani.Text + "' WHERE yetenekId=" + Request.QueryString["id"].ToString());
            lblDurum.Text = "Güncelleme Başarılı";
            lblDurum.ForeColor = System.Drawing.Color.Green;
            lblDurum.Visible = true;
        }
        catch 
        {
            LblHata.Visible = true;
        }
    }
}