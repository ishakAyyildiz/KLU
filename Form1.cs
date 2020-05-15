using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using System.IO.Ports;
//using CefSharp.WinForms;

namespace KLU
{
    public partial class GUI : Form
    {
        private string url = "";
        //SqlConnection con;
        //SqlDataAdapter da;
        //DataSet ds;

        public GUI()
        {
            InitializeComponent();
            yemekduyuruhaberGoster();
            htmlViewer.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(htmlViewer_DocumentCompleted);
            htmlViewer.NewWindow += new CancelEventHandler(htmlViewer_NewWindow);
        }

        void htmlViewer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection links = htmlViewer.Document.Links;
            foreach (HtmlElement var in links)
            {
                var.AttachEventHandler("onclick", LinkClicked);
            }
        }
        private void LinkClicked(object sender, EventArgs e)
        {
            HtmlElement link = htmlViewer.Document.ActiveElement;
            url = link.GetAttribute("href");
        }
        void htmlViewer_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            htmlViewer.Navigate(url);
        }

        private void kluWeb_Click(object sender, EventArgs e)
        {
            this.htmlViewer.Navigate("https://www.klu.edu.tr/");
            this.dataGridView1.Hide();
            // this.baslik.Text="Kırklareli Üniversitesi";
        }

        private void kluBS_Click(object sender, EventArgs e)
        {
            this.htmlViewer.Navigate("https://obs.kirklareli.edu.tr/login");
            this.dataGridView1.Hide();
            //this.baslik.Text="Kırklareli Üniversitesi Bilgi Sistemi";
        }

        private void Haritalar_Click(object sender, EventArgs e)
        {
            this.htmlViewer.Navigate("https://www.google.com.tr/maps/");
            this.dataGridView1.Hide();
            //this.baslik.Text="üni haritası";
        }

        private void bakiye_Click(object sender, EventArgs e)
        {
            //yemekduyuruhaberGoster();
        }
        private void yemekduyuruhaberGoster()
        {
            this.htmlViewer.Navigate("http://www.klu.edu.tr/");
            this.dataGridView1.Hide();
            //this.htmlViewer.DocumentText = "<html><head><meta http-equiv = 'Content-Type' content = 'text/html; charset=utf-8'><link href = 'http://www.klu.edu.tr/anadizin/icerikler/css/style.css' rel = 'stylesheet' type = 'text/css'>" + "<style type = 'text/css'>body{font-family: 'Trebuchet MS';color=white;background-color:rgb(0,80,143);}iframe{background-color:blue;}tr{padding-top: 15px;}.panel_cerceve{margin: 3px;box-shadow: 0px 1px 2px #555;}.panel_baslik{padding: 10px 15px;background: #003a6a;font-size: 16px;color:#fff;}" + ".panel - title {font-size: 16px;}.panel-body {font-size: 16px!important;}</style></head>" + "<body><div class='col-xs-12 col-sm-12 col-md-12 col-lg-12'><div class='panel panel_cerceve' style='border:none;'><div class='panel_baslik' style='background: #003a6a!important;color: #ffffff;'><h3 class='panel-title'>Duyurular" + "<a style='float:right;' href='http://www.klu.edu.tr/Sayfa_Gruplari/74-duyurular.klu/detay/'><span class='glyphicon glyphicon-list-alt'></span></a></h3></div><div class=^'panel-body' style='padding:10px; background-color: rgb(0,80,143);'><table>" + ParseRssFile("http://www.klu.edu.tr/rss/Sayfa_Gruplari/74-duyurular/detay/") + "</table>"+ParseRssFile("http://www.klu.edu.tr/rss/Sayfa_Gruplari/84-haberler-ve-etkinlikler/detay/")+"<iframe src = 'http://www.klu.edu.tr/araclar/gunun_yemegi/' style = 'margin-bottom:-5px;border:none;width:100%;height:118px;'></iframe></body></html>";
        }

        private void kapatma_Click(object sender, EventArgs e)
        {
            yemekduyuruhaberGoster();
            this.dataGridView1.Hide();
        }

        private string ParseRssFile(String url)
        {
            XmlDocument rssXmlDoc = new XmlDocument();
            rssXmlDoc.Load(url);
            XmlNodeList rssNodes = rssXmlDoc.SelectNodes("rss/channel/item");
            StringBuilder rssContent = new StringBuilder();
            foreach (XmlNode rssNode in rssNodes)
            {
                XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                string title = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("link");
                string link = rssSubNode != null ? rssSubNode.InnerText : "";

                rssContent.Append("<tr role='row'><td><h3><a style='color:white;' href ='" + link + "'>" + title + "</a></h3></td></tr>");
            }
            return rssContent.ToString();
        }

        private void ekButton_Click(object sender, EventArgs e)
        {
            yemekduyuruhaberGoster();
        }

        private void yemekveOylama_Click(object sender, EventArgs e)
        {
            this.htmlViewer.DocumentText= "<html><head><meta charset = 'UTF-8'><link rel = 'stylesheet' href = 'https://use.fontawesome.com/releases/v5.0.8/css/solid.css' integrity = 'sha384-v2Tw72dyUXeU3y4aM2Y0tBJQkGfplr39mxZqlTBDUZAb9BGoC40+rdFCG0m10lXk' crossorigin = 'anonymous'><link rel = 'stylesheet' href = 'https://use.fontawesome.com/releases/v5.0.8/css/fontawesome.css' integrity = 'sha384-q3jl8XQu1OpdLgGFvNRnPdj5VIlCvgsDQTQB6owSOHWlAurxul7f+JpUOVdAiJ5P' crossorigin = 'anonymous'><script src = 'https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js'></script>"/*<script type='text/javascript'> $(function(){ var kontrol = 0; $('#yildiz i').mouseover(function(){  var index =$(this).index(); $('#yildiz i').css('color', '#FFF') for (i = index; i >= 0; i--) { $('#yildiz i:eq(' + i + ')').css('color', '#999'); } }) $('#yildiz i').mouseout(function(){ if (kontrol == 0)  {  $('#yildiz i').css('color', '#FFF'); } }) $('#yildiz i').click(function(){ var index =$(this).index() + 1;  kontrol = 1; $('#yildiz i').css('color', '#FFF') alert(index + ' yıldız verdiniz.'); }) })</script>*/+"<style type='text/css'>#yildiz{font-size:60px;}</style></head><body style='background-color:rgb(0,80,143);'>"+/*<div id='yildiz'><i class='fa fa-star'></i><i class='fa fa-star'></i><i class='fa fa-star'></i><i class='fa fa-star'></i><i class='fa fa-star'></i></div>*/"<iframe src = 'http://www.klu.edu.tr/araclar/gunun_yemegi/' style = 'margin-bottom:-5px;border:none;width:100%;height:118px;'></iframe></body></html>";
            this.dataGridView1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.htmlViewer.Navigate(@"file:///C:/Users/ishak/Desktop/duyurlar/duyurlar.html");
            this.dataGridView1.Hide();
            //this.dataGridView1.Show();
            ////griddoldur();
        }

        //void griddoldur()
        //{
        //    con = new SqlConnection("server=.; Initial Catalog=okul;Integrated Security=SSPI");
        //    da = new SqlDataAdapter("Select OGRENCINO, AD+' '+SOYAD AS ADSOYAD, BOLUM From ogrenci WHERE OGRENCINO=1160505048", con);
        //    ds = new DataSet();
        //    con.Open();
        //    da.Fill(ds, "ogrenci");
        //    dataGridView1.DataSource = ds.Tables["ogrenci"];
        //    con.Close();
        //}
    }
}
