using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Makale_Kat_Ekle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        try
        {
            string katAd = txtKategori.Text;
            kod.komut("Insert Into makaleKategori (makalekategoriAd) Values('" + katAd + "')");
            lblDurum.Visible = true;
        }
        catch 
        {

            LblHata.Visible = true;
        }
    }
}