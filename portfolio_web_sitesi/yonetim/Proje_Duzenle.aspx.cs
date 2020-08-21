using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Proje_Duzenle : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = kod.GetDataTable("select * from proje");
        listeleRepeater.DataSource = dt;
        listeleRepeater.DataBind();
        if (!Page.IsPostBack)
        {
        

        }
      

        if (Request.QueryString["id"] != null && Request.QueryString["islem"] == "sil")
        {
            kod.komut("delete from proje where projeId=" + Request.QueryString["id"].ToString());
            Response.Redirect("Proje_Duzenle.aspx");

        }

    }

    



    
}