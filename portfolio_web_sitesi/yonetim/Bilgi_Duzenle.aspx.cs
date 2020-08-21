using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Bilgi_Duzenle : System.Web.UI.Page
{
    rehber kod = new rehber();
    string mevcutKayitli = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from bilgi");
            txtIsimSoyisim.Text = dr[1].ToString();
            txtMeslek.Text = dr[2].ToString();
            txtuni.Text = dr[3].ToString();
            txtFakulte.Text = dr[4].ToString();
            txtTel.Text = dr[5].ToString();
            txtEPosta1.Text = dr[6].ToString();
            txtEPosta2.Text = dr[7].ToString();
            
            txtHitap.Text = dr[9].ToString();

            Repeater1.DataSource = kod.GetDataTable("select foto from bilgi");
            Repeater1.DataBind();

            fuDosya.Visible = false;
        }
    }
   
    
    protected void btnEkle_Click(object sender, EventArgs e)
    {
        string adSoyad = txtIsimSoyisim.Text, meslek = txtMeslek.Text, uni = txtuni.Text, fakulte = txtFakulte.Text, tel = txtTel.Text, eposta1 = txtEPosta1.Text, eposta2 = txtEPosta2.Text, foto = "", hitap = txtHitap.Text;


        try
        {
            if (ddlFotoSecim.SelectedValue == "1")
            {
                if (fuDosya.HasFile)
                {

                    foto = kod.fotoKaydet(fuDosya, 360, "/img/user/");
                    kod.komut("UPDATE bilgi set isimSoyisim='" + adSoyad + "', meslek='" + meslek + "', universite='" + uni + "', fakulte='" + fakulte + "', tel='" + tel + "', emai1='" + eposta1 + "', email2='" + eposta2 + "', foto='" + foto + "', hitap='" + hitap + "'");
                    lblDurum.Visible = true;
                }
            }
            else
            {
                if (!fuDosya.HasFile)
                {

                    kod.komut("UPDATE bilgi set isimSoyisim='" + adSoyad + "', meslek='" + meslek + "', universite='" + uni + "', fakulte='" + fakulte + "', tel='" + tel + "', emai1='" + eposta1 + "', email2='" + eposta2 + "', hitap='" + hitap + "'");
                    lblDurum.Visible = true;
                }

            }
        }
        catch 
        {

            LblHata.Visible = true;
        }

        

    }

    protected void ddlFotoSecim_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlFotoSecim.SelectedValue == "1")
        {
            fuDosya.Visible = true;
        }
        else
        {
            fuDosya.Visible = false;

        }
    }
}