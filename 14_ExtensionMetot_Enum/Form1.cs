namespace _14_ExtensionMetot_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Şimal";
            ogr.Cinsiyet = Cinsiyet.Kadin;

            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "Mahmut";
            ogr1.Cinsiyet = Cinsiyet.Erkek;


            // üyelerimiz static oldujkları için myMetot instancelerindan erişelemez..
            //myMetot my = new myMetot();
            //my.BilgiGoster(ogr); 
            //my.BilgiGoster(ogr1);

            myMetot.BilgiGoster(ogr);
            myMetot.BilgiGoster(ogr1);


            // BilgiGoster metodu...
            // BilgiGoster metodu this Ogrenci parametresi sayesinde ogrenci (instance) üzerinden erişiblir olduğu aşağıdaki gibi çağırabildik...

            //BilgiGoster => MyMetot sınıfın sınıf üyesi...
            ogr.BilgiGoster();
            ogr1.BilgiGoster();

            //ShowInfo => Ogrenci Sınıfının üyesi
            ogr.ShowInfo();
            ogr1.ShowInfo();

            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis.Add(ogr);
            ogrencis.Add(ogr1);


            List<string> strings = new List<string>() { "gökberk", "yiğit", "ekrem" };

            // strings nesnesi parametre olarak gönderilir
            int c = myMetot.Sayi(strings);
            // strings instance üzrinden çağrılabilir... paremtre gönderiliz..
            int j = strings.Sayi();

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6 };

            int k = nums.Sayi();

            int l = ogrencis.Sayi();

            string isimler = strings.stringeDonustur();

            MessageBox.Show(isimler);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Şimal";
            ogr.Cinsiyet = Cinsiyet.Kadin;

            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "Mahmut";
            ogr1.Cinsiyet = Cinsiyet.Erkek;


            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis.Add(ogr);
            ogrencis.Add(ogr1);

            var list1 = ogrencis.Where(c => c.Cinsiyet == Cinsiyet.Kadin).ToList();


            int a = (int)Renk.Yesil;


            if (ogr.Cinsiyet == Cinsiyet.Kadin)
            {

            }


            if ((int)ogr.Cinsiyet == 0)
            {

            }

            string[] strings1 = Enum.GetNames(typeof(Cinsiyet));
            string[] colors = Enum.GetNames(typeof(Renk));

            //int[] cinsiyetss = (int[])Enum.GetValues(typeof(Cinsiyet));
            foreach (var item in Enum.GetValues(typeof(Renk)))
            {
                int i = (int)item;
                MessageBox.Show(i.ToString());
            }
        }
    }
}
