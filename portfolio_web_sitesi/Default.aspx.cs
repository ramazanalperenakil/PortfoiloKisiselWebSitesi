using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
       // RepeaterSlider.DataSource = kod.GetDataTable("SELECT *  FROM [slider] WHERE sliderDurum = '1'");
        DataTable dtSlider = kod.GetDataTable("SELECT TOP 10 *  FROM [makaleler] WHERE makaleDurum = '1' Order BY MakaleId DESC");
        int ogeSayisi = dtSlider.Rows.Count;
        string ekle = "";
        for (int i = 0; i < ogeSayisi; i++)
        {
            if (i==0)
            {
                ekle += "<li data-target='#slider' data-slide-to='" + i + "' class='active'></li>";
            }
            else
            {
                ekle += "<li data-target='#slider' data-slide-to='" + i + "'></li>";
            }
        }
        RepeaterSlider.DataSource = dtSlider;
        sliderGosterge.InnerHtml = ekle;
        RepeaterSlider.DataBind();

        RepeaterBilgiler.DataSource = kod.GetDataTable("SELECT *  FROM [bilgi]");
        RepeaterBilgiler.DataBind();


        Repeater1.DataSource = kod.GetDataTable("SELECT *  FROM [yetenek] ORDER BY [yetenekYuzdesi] DESC");
        Repeater1.DataBind();

        //DataList1.DataSource = kod.GetDataTable("SELECT *  FROM [hizmetler]");
        //DataList1.DataBind();


        RepeaterHizmetler.DataSource = kod.GetDataTable("SELECT *  FROM [hizmetler] ");
        RepeaterHizmetler.DataBind();

    }

    
}





