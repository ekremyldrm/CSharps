namespace _7_GenericClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // GenericType'dan miras alma...
            // hesap sınıfın üyeleri topla instance'sinde int
            Hesap<int> topla = new Hesap<int>();
            topla.Sayi1 = 3;
            topla.Sayi2 = 2;
            int toplamsonuc = topla.Sayi1 + topla.Sayi2;
            MessageBox.Show(toplamsonuc.ToString());

            // hesap sınıfın üyeleri bol instance'sinde double
            Hesap<double> bol = new Hesap<double>();
            bol.Sayi1 = 3;
            bol.Sayi2 = 2;
            double bolumsonuc = bol.Sayi1 / bol.Sayi2;
            MessageBox.Show(bolumsonuc.ToString());



            // yukarıdaki kullanımta T tipli üyelein tipi instance aşamasında verildiği için Tip güvenliğini belirlemiş olduk. Tip güvenliği tam olarak budur

            // eğer generic olmasaydı aşağıdaki örneklerde olduğu gibi tip güvenliği olmayacaktı..,sayi1 üyesi object türünde olduğu her değeri alabilir tip güvenliğinden kastımız budur. değerin bu örnkte int olduğunu kontrol etmek gerekir.
            Calc c = new Calc();
            c.Sayi1 = "ekrem";
            c.Sayi2 = 2;

            int x = (int)c.Sayi1 + (int)c.Sayi2;

            // tip güvenliği olan generic'e bakalım
            Hesap<int> c2 = new Hesap<int>();
            //c2.Sayi1 = "ekrem"; tip int olduğu için string atanamaz..
            c2.Sayi2 = 2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Islem<Ogrenci> islemler = new Islem<Ogrenci>();
            Ogrenci ogr = new Ogrenci();

            islemler.Kaydet(ogr);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Islem<Ogretmen> islemler = new Islem<Ogretmen>();
            Ogretmen ogrt = new Ogretmen();

            islemler.Kaydet(ogrt);


            //Islem<int> xyz = new Islem<int>(); int tipinde instance alınamaz çünkü t'nin class tipinde olduuğunu söyledik...



         }
    }
}
