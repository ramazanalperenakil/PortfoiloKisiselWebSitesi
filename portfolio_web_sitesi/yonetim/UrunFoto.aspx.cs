using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class yonetim_UrunFoto : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["uId"] == null)
        {
            Response.Redirect("Proje_Ekle.aspx");
        }
        DataTable dt = kod.GetDataTable("select * from projegorsel WHERE projeId=" + Request.QueryString["uId"]);
        RepeaterUrunFoto.DataSource = dt;
        RepeaterUrunFoto.DataBind();

        if (Request.QueryString["id"] != null && Request.QueryString["islem"] == "sil")
        {
            kod.komut("delete from projegorsel where projeGorselId=" + Request.QueryString["id"].ToString());
            Response.Redirect("urunFoto.aspx?uId=" + Request.QueryString["uId"].ToString());

        }
    }

    protected void btnEkle_Click(object sender, EventArgs e)
    {
        //string projeId = Request.QueryString["uId"];
        try
        {
            DataRow dr = kod.GetDataRow("Select projeAd from proje WHERE projeId=" + Request.QueryString["uId"]);


            if (fuDosya.HasFile)
            {
                string url = kod.KodOlustur(dr[0].ToString());
                kod.komut("Insert Into projegorsel (projeGorselUrl, projeGorselUrlKucuk, projeId) VALUES ('" + kod.FotoKaydetOptimize(fuDosya, 1024, "/img/projeler/buyuk/", url) + "', '" + kod.FotoKaydetOptimize(fuDosya, 256, "/img/projeler/kucuk/", url) + "'," + Request.QueryString["uId"].ToString() + ")");
                Response.Redirect("urunFoto.aspx?uId=" + Request.QueryString["uId"].ToString());

            }
        }
        catch 
        {

            LblHata.Visible = true;
        }
    }
}