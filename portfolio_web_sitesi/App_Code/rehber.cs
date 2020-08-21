using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using System.Text;
/// <summary>
/// rehber için özet açıklama
/// </summary>
public class rehber
{
    public rehber()
    {
        //
        //TODO: Buraya oluşturucu mantığı ekleyin
        //
    }

    public OleDbConnection baglan()
    {
        OleDbConnection baglanti = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString2A"].ConnectionString);
        baglanti.Open();
        return baglanti;

    }

    public int komut(string sqlCumle)
    {
        OleDbConnection baglanti = this.baglan();
        OleDbCommand sorgu = new OleDbCommand(sqlCumle, baglanti);
        int sonuc = 0;
        sonuc = sorgu.ExecuteNonQuery();
        sorgu.Dispose();
        baglanti.Close();
        baglanti.Dispose();
        return sonuc;
    }

    public object GetDataTable(object p, string v)
    {
        throw new NotImplementedException();
    }

    public DataTable GetDataTable(string sqlCumle)
    {
        OleDbConnection baglanti = this.baglan();
        OleDbDataAdapter adaptor = new OleDbDataAdapter(sqlCumle, baglanti);
        DataTable dt = new DataTable();
        adaptor.Fill(dt);
        adaptor.Dispose();
        baglanti.Close();
        baglanti.Dispose();
        return dt;
    }

    public object GetDataTable(object p)
    {
        throw new NotImplementedException();
    }

    public DataRow GetDataRow(string sqlCumle)
    {
        DataTable dt = this.GetDataTable(sqlCumle);
        if (dt.Rows.Count != 1)
        {
            return null;
        }
        else
        {
            return dt.Rows[0];
        }
    }

    public string getDataCell(string sqlCumle)
    {
        try
        {
            DataRow dr = this.GetDataRow(sqlCumle);
            string hucre = dr[0].ToString();
            return hucre;
        }
        catch (Exception)
        {
            return null;
            throw;
        }

    }

    public string fotoKaydet(FileUpload fu, int sonGenislik, string gercekYol)
    {
        string yoluKaydet;
        string geciciYol = "../img/temp/";
        string fotoAd = DateTime.Now.Ticks.ToString();
        string fotoUzanti = Path.GetExtension(fu.PostedFile.FileName);
        fu.SaveAs(HttpContext.Current.Server.MapPath(geciciYol + fotoAd + fotoUzanti));
        Bitmap bmp = new Bitmap(HttpContext.Current.Server.MapPath(geciciYol + fotoAd + fotoUzanti));
        using (Bitmap orjinalFoto = bmp)
        {
            double fotoYukseklik = orjinalFoto.Height;
            double fotoGenislik = orjinalFoto.Width;
            double oron = fotoGenislik / fotoYukseklik;
            fotoGenislik = sonGenislik;
            fotoYukseklik = fotoGenislik / oron;
            Size yeniDegerler = new Size(Convert.ToInt32(fotoGenislik), Convert.ToInt32(fotoYukseklik));
            Bitmap yeniFoto = new Bitmap(orjinalFoto, yeniDegerler);
            yeniFoto.Save(HttpContext.Current.Server.MapPath(gercekYol + fotoAd + fotoUzanti));
            yoluKaydet = gercekYol + fotoAd + fotoUzanti;
            orjinalFoto.Dispose();
            bmp.Dispose();
            yeniFoto.Dispose();
        }
        FileInfo silinecek = new FileInfo(HttpContext.Current.Server.MapPath(geciciYol + fotoAd + fotoUzanti));
        silinecek.Delete();
        return yoluKaydet;
    }

    public string FotoKaydetOptimize(FileUpload fu, int sonGenislik, string gercekYol, string onAd)
    {
        Stream kaynak = fu.PostedFile.InputStream;
        string fotoAd = onAd + "_" + DateTime.Now.Ticks.ToString();
        string fotoUzanti = Path.GetExtension(fu.PostedFile.FileName);
        string url = gercekYol + fotoAd + fotoUzanti;
        string tamYol = HttpContext.Current.Server.MapPath(url);
        using (var imgage = System.Drawing.Image.FromStream(kaynak))
        {
            double kucultmeOrani = (double)sonGenislik / imgage.Width;

            var yeniGenislik = (int)(imgage.Width * kucultmeOrani);
            var yeniYukseklik = (int)(imgage.Height * kucultmeOrani);
            var yeniFoto = new Bitmap(yeniGenislik, yeniYukseklik);
            var fotoIsle = Graphics.FromImage(yeniFoto);
            fotoIsle.CompositingQuality = CompositingQuality.HighQuality;
            fotoIsle.SmoothingMode = SmoothingMode.HighQuality;
            fotoIsle.InterpolationMode = InterpolationMode.HighQualityBicubic;
            var imagerectangle = new Rectangle(0, 0, yeniGenislik, yeniYukseklik);
            fotoIsle.DrawImage(imgage, imagerectangle);
            yeniFoto.Save(tamYol, imgage.RawFormat);
            return url;
        }
    }
    public string KodOlustur(string Text)
    {

        string strReturn = Text.Trim();
        strReturn = strReturn.Replace("ğ", "g");
        strReturn = strReturn.Replace("Ğ", "G");
        strReturn = strReturn.Replace("ü", "u");
        strReturn = strReturn.Replace("Ü", "U");
        strReturn = strReturn.Replace("ş", "s");
        strReturn = strReturn.Replace("Ş", "S");
        strReturn = strReturn.Replace("ı", "i");
        strReturn = strReturn.Replace("İ", "I");
        strReturn = strReturn.Replace("ö", "o");
        strReturn = strReturn.Replace("Ö", "O");
        strReturn = strReturn.Replace("ç", "c");
        strReturn = strReturn.Replace("Ç", "C");
        strReturn = strReturn.Replace("-", "+");
        strReturn = strReturn.Replace(" ", "_");
        strReturn = strReturn.Replace("/", "//");
        strReturn = strReturn.Replace("'", "''");


        strReturn = strReturn.Trim();
        strReturn = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9+]").Replace(strReturn, "");
        strReturn = strReturn.Trim();
        strReturn = strReturn.Replace("+", "_");
        return strReturn;
    }

    public string SliderKaydet(FileUpload fu, int sonGenislik, int sonYukseklik, string gercekYol, string onAd)
    {
        Stream kaynak = fu.PostedFile.InputStream;
        string fotoAd = onAd + "_" + DateTime.Now.Ticks.ToString();
        string fotoUzanti = Path.GetExtension(fu.PostedFile.FileName);
        string url = gercekYol + fotoAd + fotoUzanti;
        string tamYol = HttpContext.Current.Server.MapPath(url);
        using (var imgage = System.Drawing.Image.FromStream(kaynak))
        {
            double kucultmeOraniw = (double)sonGenislik / imgage.Width;
            double kucultmeOranih = (double)sonYukseklik / imgage.Height;

            var yeniGenislik = (int)(imgage.Width * kucultmeOraniw);
            var yeniYukseklik = (int)(imgage.Height * kucultmeOranih);
            var yeniFoto = new Bitmap(yeniGenislik, yeniYukseklik);
            var fotoIsle = Graphics.FromImage(yeniFoto);
            fotoIsle.CompositingQuality = CompositingQuality.HighQuality;
            fotoIsle.SmoothingMode = SmoothingMode.HighQuality;
            fotoIsle.InterpolationMode = InterpolationMode.HighQualityBicubic;
            var imagerectangle = new Rectangle(0, 0, yeniGenislik, yeniYukseklik);
            fotoIsle.DrawImage(imgage, imagerectangle);
            yeniFoto.Save(tamYol, imgage.RawFormat);
            return url;
        }
    }

    public string MakaleKaydet(FileUpload fu, int sonGenislik, int sonYukseklik, string gercekYol, string onAd)
    {
        Stream kaynak = fu.PostedFile.InputStream;
        string fotoAd = onAd + "_" + DateTime.Now.Ticks.ToString();
        string fotoUzanti = Path.GetExtension(fu.PostedFile.FileName);
        string url = gercekYol + fotoAd + fotoUzanti;
        string tamYol = HttpContext.Current.Server.MapPath(url);
        using (var imgage = System.Drawing.Image.FromStream(kaynak))
        {
            double kucultmeOraniw = (double)sonGenislik / imgage.Width;
            double kucultmeOranih = (double)sonYukseklik / imgage.Height;

            var yeniGenislik = (int)(imgage.Width * kucultmeOraniw);
            var yeniYukseklik = (int)(imgage.Height * kucultmeOranih);
            var yeniFoto = new Bitmap(yeniGenislik, yeniYukseklik);
            var fotoIsle = Graphics.FromImage(yeniFoto);
            fotoIsle.CompositingQuality = CompositingQuality.HighQuality;
            fotoIsle.SmoothingMode = SmoothingMode.HighQuality;
            fotoIsle.InterpolationMode = InterpolationMode.HighQualityBicubic;
            var imagerectangle = new Rectangle(0, 0, yeniGenislik, yeniYukseklik);
            fotoIsle.DrawImage(imgage, imagerectangle);
            yeniFoto.Save(tamYol, imgage.RawFormat);
            return url;
        }
    }
 
}
