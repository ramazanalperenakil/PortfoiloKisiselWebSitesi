using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Footer_Duzenle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from footer");
            txtFooterHakkimda.Text = dr[1].ToString();
            txtTwitterUrl.Text = dr[2].ToString();
            txtFacebook.Text = dr[3].ToString();
            txtInstagram.Text = dr[4].ToString();
            txtLinkedin.Text = dr[5].ToString();
            txtAdres.Text = dr[6].ToString();
            txtEPosta1.Text = dr[7].ToString();
            txtEPosta2.Text = dr[8].ToString();
            txtTel.Text = dr[9].ToString();
            txtYazi.Text = dr[10].ToString();
            txtCop.Text = dr[11].ToString();
        }

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {


            kod.komut("UPDATE footer set footerHakkimda='" + txtFooterHakkimda.Text.Replace("'", "''") + "', footerTwitter='" + txtTwitterUrl.Text + "', footerFacebook='" + txtFacebook.Text + "', footerInstagram='" + txtInstagram.Text + "', footerLinkedin='" + txtLinkedin.Text + "', footerAdres='" + txtAdres.Text + "', footerEmail1='" + txtEPosta1.Text + "', footerEmail2='" + txtEPosta2.Text + "', footertel='" + txtTel.Text + "', footerYazi='" + txtYazi.Text + "', copyright='" + txtCop.Text + "' WHERE footerId= 1");




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