using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ana : System.Web.UI.MasterPage
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        RepeaterKat.DataSource = kod.GetDataTable("SELECT [kategoriAd] ,[kategoriId] FROM [kategoriler]");
        RepeaterKat.DataBind();

        RepeaterFooter.DataSource = kod.GetDataTable("SELECT * FROM [footer]");
        RepeaterFooter.DataBind();
       




    }

    protected void RepeaterKat_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        Repeater altKategori = (Repeater)e.Item.FindControl("RepeaterAltKat");

        altKategori.DataSource = kod.GetDataTable("SELECT * FROM [altKategori] WHERE [kategoriId]=" + DataBinder.Eval(e.Item.DataItem, "[kategoriId]"));
        altKategori.DataBind();

    }

    


    public string altKategoriGetir(int altkategoriId)
    {
        string sonuc = "";
        string sqlCumle = "Select altKategorininAltKategori_Id, altKategorininAltKategoriAdi from altKategorininAltKategorisi where altKategoriId=" + altkategoriId;
        DataTable dt = kod.GetDataTable(sqlCumle);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string id = dt.Rows[i][0].ToString();
            string ad = dt.Rows[i][1].ToString();
            sonuc += " <li ><a class='dropdown-item drop-right' href='projeler.aspx?ak_ak_Id=" + id + "'>" + ad + "</a></li>";
           

        }
        return sonuc;
    }
}
