using System.Xml;
using System.Xml.Serialization;

namespace _15_XML_Markup_Language
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // XmlDocument sınıfı xml dosyalarını okuyabilmek için kulanılan sınıftır...

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("../../../ogrenciler.xml"); // load metodu ile fiziki bir xml dosyası alınıp okunabilir...

            XmlNodeList xnodeAdlar = xdoc.SelectNodes("Ogrenciler/Ogrenci/adi");

            XmlNodeList xnodedeCinsiyetler = xdoc.SelectNodes("Ogrenciler/Ogrenci/cinsiyet");


            //Ogrenciler/Ogrenci düğümü alalım...
            XmlNodeList xnode = xdoc.SelectNodes("Ogrenciler/Ogrenci");


            List<Ogrenci> ogrencis = new List<Ogrenci>();
            //ogrenci düğümdelerinde dönelim
            foreach(XmlNode item in xnode)
            {
                Ogrenci ogr = new Ogrenci();
                ogr.Adi = item["adi"].InnerText;// verileri ilgili nesnenin ilgili alanına atalım...
                ogr.Cinsiyet = item["cinsiyet"].InnerText;
                ogr.Yas = Convert.ToInt32(item["yas"].InnerText);

                ogrencis.Add(ogr);
            }

            dataGridView1.DataSource = ogrencis;
        }

    }
}
