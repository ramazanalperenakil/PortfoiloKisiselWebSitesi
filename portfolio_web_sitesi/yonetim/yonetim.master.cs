using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class yonetim_yonetim : System.Web.UI.MasterPage
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        Image1.Visible = false;

        RepeaterAvatar.DataBind();
        if (Session["kullanici"] == null)
        {
            Response.Redirect("giris.aspx");
        }
        else
        {

            lblKullanici.Text = Session["kullanici"].ToString();
            
            if (Session["kullanici"].ToString()== "admin")
            {
                
                RepeaterAvatar.DataSource = kod.GetDataTable("SELECT *  FROM kullanici where  uyeId=1");
                RepeaterAvatar.DataBind();
                
            }
            else
            {
                Image1.Visible = true;
            }


            



        }

    }



}





