using System.Collections.Generic;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace _16_XmlveJson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("../../../data/urunler.xml");


            //FileInfo fi = new FileInfo("../../../data/
            //urunler.xml");
            //StreamReader sRead = new StreamReader(fi.OpenRead());
            XmlNodeList xNodelist = xmlDocument.SelectNodes("Urunler/Urun");
            List<Urun> uruns = new List<Urun>();
            foreach (XmlNode item in xNodelist)
            {
                Urun urn = new Urun();
                urn.Adi = item["Adi"].InnerText;
                urn.Stok = int.Parse(item["Stok"].InnerText);
                urn.Kategori = item["Kategori"].InnerText;
                urn.Indirim = bool.Parse(item["Indirim"].InnerText);

                uruns.Add(urn);
            }

            dgwData.DataSource = uruns;
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("../../../data///urunler.json");
            StreamReader sRead = new StreamReader(fi.OpenRead());
            string data = sRead.ReadToEnd();


            // veriyi desirilze ediyoruz...
            List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(data);

            dgwData.DataSource = urunler;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Urun u = new Urun();
            u.Adi = "C UrUnU";
            u.Stok = 20;
            u.Indirim = false;
            u.Kategori = "Mobilya";

            Urun u1 = new Urun();
            u1.Adi = "C UrUnU";
            u1.Stok = 20;
            u1.Indirim = false;
            u1.Kategori = "Mobilya";


            Urun u2 = new Urun();
            u2.Adi = "C UrUnU";
            u2.Stok = 20;
            u2.Indirim = false;
            u2.Kategori = "Mobilya";

            List<Urun> urns = new List<Urun>();
            urns.Add(u);
            urns.Add(u1);
            urns.Add(u2);

            string dat = JsonSerializer.Serialize(urns);

           
            using (TextWriter writer = new StreamWriter("../../../yenidata.json"))
            {
                writer.WriteLine(dat);
            }
        }
    }
}