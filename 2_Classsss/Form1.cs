
using CANAKKALE; // CANAKKALE NAMESPACE'Sİ DAHİL EDİLİR...

using _2_Classsss.Namespacessssss; // ALT NAMEPACES
using _2_SinifKutuphanesi;

namespace _2_Classsss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // farklı bir namespace içerisinde koda direkt erişilemez.

            // 2 seçenek mevcut;

            // namespaceAdi.Sinif adı ile (önerilen bir yöntem değildir). sadece varlık isimleri aynı olan farklı namespaceler kullanılabilir....

            // using namespace ile


            EREN ern = new EREN();
            EKREM ekrm = new EKREM();
            YIGIT ygt = new YIGIT();
            CANAKKALE.YIGIT y1 = new CANAKKALE.YIGIT();


            Gokberk g = new Gokberk();
            Mahmut m = new Mahmut();

            // proje içerisinde sınıflar oluşturabildiğimiz gibi proje dışındada sınıflar oluşturabiliriz.. genelde bu tür projeler class library (sınıf kütüphaneleri) olarak adlandırılır

            //bir class library projenizi eklemek için projenize sağ tık yapıp add > project reference seçeneği solutionda bulunan projeyi seçebilirsiniz...

        }
    }
}


// namespace

// bir proje oluşturulurken projeye verilen isim aslına namespace verilen isimdir. 

// proje içerisindeki kodların gruplandığı yerdir.

// kodlar namesspaceler içerisinde yazılır...

