using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class projeler : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        RepeaterSolMenu.DataSource = kod.GetDataTable("select kategoriId, kategoriAd from kategoriler");
        RepeaterSolMenu.DataBind();

        string urunlerSorgu = "";

        if (Request.QueryString["kId"] !=null)
        {
            urunlerSorgu = "SELECT proje.*, altkategori.altKategoriId , altkategori.kategoriId FROM(altkategori INNER JOIN proje ON altkategori.altKategoriId = proje.altKategoriId) where (projeDurum ='1' AND  kategoriId="+ Request.QueryString["kId"]+ ") Order BY ProjeId DESC";
        }
        else if (Request.QueryString["akId"] != null)
        {
            urunlerSorgu = "Select Top 20 * from proje where (projeDurum='1' AND altKategoriId ="+ Request.QueryString["akId"]+ ") Order BY ProjeId DESC ";
        }
        else if (Request.QueryString["uId"] != null)
        {
            urunlerSorgu = "Select  Top 20 * from proje where projeDurum = '1' Order BY ProjeId DESC";
            PanelUrunler.Visible = false;
            PanelTekUrun.Visible = true;
            tekUrunGoster(Request.QueryString["uId"]);


        }
        else if (Request.QueryString["ak_ak_Id"] != null)
        {
            urunlerSorgu = "Select Top 20 * from proje where (projeDurum='1' AND altKategorininAltKategori_Id =" + Request.QueryString["ak_ak_Id"] + ") Order BY ProjeId DESC";

        }
        else
        {
            urunlerSorgu = "Select  Top 20 * from proje where projeDurum = '1' Order BY projeId DESC";

        }


        

        RepeaterUrunler.DataSource = kod.GetDataTable(urunlerSorgu);
        RepeaterUrunler.DataBind();

    }
    public string altKategoriGetir(int altkategoriId)
    {
        string sonuc = "";
        string sqlCumle = "Select altKategoriId, altKategoriAd from altkategori where kategoriId=" + altkategoriId;
        DataTable dt = kod.GetDataTable(sqlCumle);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string id = dt.Rows[i][0].ToString();
            string ad = dt.Rows[i][1].ToString();
            sonuc += " <li class='list-group-item'><a href='projeler.aspx?akId=" + id + "' class='text-decoration-none text-dark'>" + ad + "</a></li>";

        }
        return sonuc;
    }

    public string urunGorselGetir(int projeId)
    {
        string resimYol = kod.getDataCell("Select Top 1 projeGorselUrlKucuk from projegorsel where projeId=" + projeId);
        if (resimYol == null)
        {
            resimYol = "/img/resim_yok.png";
        }
        return resimYol;
    }

    public void tekUrunGoster(string urunId)
    {
        DataTable dtUrunGorseller = kod.GetDataTable("Select * from projegorsel where projeId=" + urunId);
        int ogeSayisi = dtUrunGorseller.Rows.Count;
        string ekle = "";
        for (int i = 0; i < ogeSayisi; i++)
        {
            if (i == 0)
            {
                ekle += "<li style='background-image:url(" + dtUrunGorseller.Rows[i][2].ToString()+ ")   ' data-target='#caruserTekUrun' data-slide-to='" + i + "' class='active'></li>";
            }
            else
            {
                ekle += "<li style=' background-image:url(" + dtUrunGorseller.Rows[i][2].ToString() + ")' data-target='#caruserTekUrun' data-slide-to='" + i + "'></li>";
            }
        }
        RepeaterUrunGorseller.DataSource = dtUrunGorseller;
        sliderGosterge.InnerHtml = ekle;
        RepeaterUrunGorseller.DataBind();

        DataTable dtTekUrun = kod.GetDataTable("select * from proje where projeId=" + urunId);
        RepeaterTekUrun.DataSource = dtTekUrun;
        RepeaterTekUrun.DataBind();
    }
}