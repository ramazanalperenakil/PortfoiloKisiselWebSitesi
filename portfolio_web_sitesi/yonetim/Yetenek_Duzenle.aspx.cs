using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Yetenek_Duzenle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = kod.GetDataTable("select * from yetenek");
        listeleRepeater.DataSource = dt;
        listeleRepeater.DataBind();

        if (Request.QueryString["id"] != null && Request.QueryString["islem"] == "sil")
        {
            kod.komut("delete from yetenek where yetenekId=" + Request.QueryString["id"].ToString());
            Response.Redirect("Yetenek_Duzenle.aspx");

        }
    }
}