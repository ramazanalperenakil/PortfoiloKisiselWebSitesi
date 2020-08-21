using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class makale : System.Web.UI.Page
{
    rehber kod = new rehber();

    public string PostBackUrl { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        
        RepeaterSolMenu.DataSource = kod.GetDataTable("select * from makaleKategori");
        RepeaterSolMenu.DataBind();

        Repeatermakaleler.DataSource = kod.GetDataTable("select * from makaleler");
        Repeatermakaleler.DataBind();

        string urunlerSorgu = "";

        if (Request.QueryString["kId"] != null)
        {
            urunlerSorgu = "SELECT  makaleAltKategori.makaleAltKategori , makaleAltKategori.makaleKategoriId, makaleler.* FROM(makaleAltKategori INNER JOIN makaleler ON makaleAltKategori.makaleAltKategori = makaleler.makaleAltKategori)where (makaleDurum ='1' AND  makaleKategoriId=" + Request.QueryString["kId"] + ") ORDER BY makaleId DESC";
         
        }
        else if (Request.QueryString["akId"] != null)
        {
            urunlerSorgu = "Select Top 20 * from makaleler where (makaleDurum='1' AND makaleAltKategori =" + Request.QueryString["akId"] + ") ORDER BY makaleId DESC";
        }
        else if (Request.QueryString["uId"] != null)
        {
           
            Response.Redirect("makaledetay.aspx?uId= "+ Request.QueryString["uId"]);

        }
        else
        {
           urunlerSorgu = "Select  Top 20 * from makaleler where makaleDurum = '1' ORDER BY makaleId DESC";

        }

        Repeatermakaleler.DataSource = kod.GetDataTable(urunlerSorgu);
        Repeatermakaleler.DataBind();

      

    }
    public string altKategoriGetir(int altkategoriId)
    {
        string sonuc = "";
        string sqlCumle = "Select * from makaleAltkategori where makaleKategoriId=" + altkategoriId;
        DataTable dt = kod.GetDataTable(sqlCumle);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string id = dt.Rows[i][0].ToString();
            string ad = dt.Rows[i][1].ToString();
            sonuc += " <li class='list-group-item'><a href='makale.aspx?akId=" + id + "' class='text-decoration-none text-dark'>" + ad + "</a></li>";

        }
        return sonuc;
        
    }
}