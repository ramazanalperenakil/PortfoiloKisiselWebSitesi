using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class makaledetay : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        string urunlerSorgu = "";
        if (Request.QueryString["uId"] != null)
        {
            urunlerSorgu = "Select Top 20 * from makaleler where (makaleDurum='1' AND makaleId=" + Request.QueryString["uId"] + ")";
        }
        else
        {
            Response.Redirect("makale.aspx");
        }

        RepeaterMakaleDetay.DataSource = kod.GetDataTable(urunlerSorgu);
        RepeaterMakaleDetay.DataBind();

        RepeaterProje.DataSource = kod.GetDataTable("SELECT TOP 10 *  FROM [proje] Order BY ProjeId DESC");
        RepeaterProje.DataBind();
    }
}