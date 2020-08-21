using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class yonetim_Makale_Alt_Kat_Duzenle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
       
        DataTable dt = kod.GetDataTable("select * from makaleALtKategori");
        listeleRepeater.DataSource = dt;
        listeleRepeater.DataBind();

        

        if (Request.QueryString["id"] != null && Request.QueryString["islem"] == "sil")
        {
            kod.komut("delete from makaleALtKategori where makaleAltKategori=" + Request.QueryString["id"].ToString());
            Response.Redirect("Makale_Alt_Kat_Duzenle.aspx");

        }



    }
}