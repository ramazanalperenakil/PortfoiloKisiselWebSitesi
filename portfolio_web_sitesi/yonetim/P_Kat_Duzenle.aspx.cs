using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_P_Kat_Duzenle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = kod.GetDataTable("select * from kategoriler");
        listeleRepeater.DataSource = dt;
        listeleRepeater.DataBind();

        if (Request.QueryString["id"] != null && Request.QueryString["islem"] == "sil")
        {
            kod.komut("delete from kategoriler where kategoriId=" + Request.QueryString["id"].ToString());
            Response.Redirect("P_Kat_Duzenle.aspx");

        }

    }
}