using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class yonetim_Default : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {

        string TP = kod.getDataCell("SELECT  COUNT(projeId) FROM proje ");
        Tp.InnerText = TP.ToString();

        string MT = kod.getDataCell("SELECT COUNT(makaleAd) FROM makaleler");
        Mt.InnerText = MT.ToString();

        RepeaterProjeler.DataSource = kod.GetDataTable("SELECT Top 20 *  FROM [proje]  ORDER BY projeId DESC");
        RepeaterProjeler.DataBind();

        RepeaterMakaleler.DataSource = kod.GetDataTable("SELECT Top 20 *  FROM [makaleler] ORDER BY makaleId DESC");
        RepeaterMakaleler.DataBind();
    }
    
}