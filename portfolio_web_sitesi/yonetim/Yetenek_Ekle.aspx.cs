using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Yetenek_Ekle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            string yetenekAdi = txtYetenekAdi.Text, yuzde = txtYetenekOrani.Text;
            kod.komut("insert into yetenek (yetenekAdi, yetenekYuzdesi) values('" + yetenekAdi + "', '" + yuzde + "')");
            lblDurum.Visible = true;
            lblDurum.Text = "başarılı";
            lblDurum.ForeColor = System.Drawing.Color.Green;
        }
        catch 
        {

            LblHata.Visible = true;
        }
    }
}