using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hakkimda : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        RepeaterHakkimda.DataSource = kod.GetDataTable("SELECT *  FROM [sayfalar] WHERE [sayfaId] = 1 ");
        RepeaterHakkimda.DataBind();

        RepeaterProje.DataSource = kod.GetDataTable("SELECT TOP 10 *  FROM [proje] Order BY ProjeId DESC");
        RepeaterProje.DataBind();
    }
}