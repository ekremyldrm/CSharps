namespace _13_LinqExtenstionMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nums = new List<int>() { 1, 3, 5, 8, 10, 11, 12, 13, 14, 18, 20, 23, 25 };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // ondan küçük sayıları başka bir listeye atalım..
            List<int> tem = nums;
            List<int> nums1 = (from a in nums
                               where a < 10
                               select a).ToList();
        }
        List<int> nums;
        private void button2_Click(object sender, EventArgs e)
        {
            // lambda ifadeleri =  a => koleksiyon
            // Where => bir extension (uzantı) metottur. lambda paraemtreleri alarak elimizdeki koleksiyon üzerine kriter belirlemek için kullanılır...
            List<int> temp = nums.OrderBy(c => c).ToList(); // elemanları sırada => a-z'ye veya küçükten büyüğüe

            List<int> temp1 = nums.OrderByDescending(c => c).ToList(); // z-a'ya veya büyükten küçüğe

            // foreach ve if ile yukarıdaki ifadeleri yazınız (klasik yöntem ile)
            List<int> nums1 = nums.Where(n => n < 10).ToList();
            // 10'dan büyükleri büyükten küçüğe sırala
            List<int> nums2 = nums.Where(k => k > 10).OrderByDescending(c => c).ToList();

            int _count = nums.Count(c => c > 10); // ondan büyüklerin sayısı
            int _cnt = nums.Where(c => c > 10).Count();
            int _sum = nums.Where(c => c < 10 && c % 2 == 0).Sum();

            int[] arr = nums.Where(c => c > _sum).ToArray();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis.Add(new Ogrenci { Adi = "Emine", Cinsiyet = 'K', Ortalama = 80 });
            ogrencis.Add(new Ogrenci { Adi = "Şimal", Cinsiyet = 'K', Ortalama = 85 });
            ogrencis.Add(new Ogrenci { Adi = "Yiğit", Cinsiyet = 'E', Ortalama = 80 });
            ogrencis.Add(new Ogrenci { Adi = "Mahmut", Cinsiyet = 'E', Ortalama = 45 });
            ogrencis.Add(new Ogrenci { Adi = "Gökberk", Cinsiyet = 'E', Ortalama = 30 });
            ogrencis.Add(new Ogrenci { Adi = "Eren", Cinsiyet = 'E', Ortalama = 60 });

            List<Ogrenci> ogrencis1 = (from a in ogrencis
                                       where a.Ortalama > 50
                                       select a).ToList();

            List<Ogrenci> ogrencis2 = ogrencis.Where(c => c.Ortalama > 50).ToList();

            float ort = ogrencis.Average(c => c.Ortalama);

            List<Ogrenci> ogrencis3 = ogrencis.Where(c => c.Ortalama >= ort).ToList();

            List<Ogrenci> ogrencis4 = ogrencis.Where(c => c.Cinsiyet == 'K').ToList();

            List<Ogrenci> ogrencis5 = ogrencis.Where(c => c.Cinsiyet == 'K' && c.Ortalama >= ort).ToList();

            List<Ogrenci> ogrenci6 = (from a in ogrencis
                                      where a.Ortalama >= ort && a.Cinsiyet == 'E'
                                      select a).ToList();

            //float _sinifOrtalama1 = (from a in ogrencis
            //                       select a).Average(c => c.Ortalama);

            // öğrencilerin adları


            // select 
            // linq sorgusundan çıkan sonucun tipini select ifadesi belirler...

            // select a = geriye ogrenci döner
            // select a.Adi = geriye string döner
            List<string> o = (from a in ogrencis
                              select a.Adi).ToList();

            List<string> o1 = ogrencis.Select(c => c.Adi).ToList();

            List<char> c = (from a in ogrencis
                            select a.Cinsiyet).ToList();

            List<char> c1 = ogrencis.Select(c => c.Cinsiyet).ToList();

            List<string> c2 = ogrencis.Where(c => c.Cinsiyet == 'K').Select(c => c.Adi).ToList();

            // KADIN ÖĞRENCİLERİN  ORTALAMALARI
            List<float> ortalama = (from a in ogrencis
                                    where a.Cinsiyet == 'K'
                                    select a.Ortalama).ToList();

            // KADIN ÖĞRENCİLERİN ADLARI VE ORTALAMALARI

            var anonim1 = (from a in ogrencis
                           where a.Cinsiyet == 'K'
                           select new
                           {
                               a.Adi,
                               a.Ortalama
                           });

            var anonim2 = ogrencis.Where(c => c.Cinsiyet == 'K').Select(c => new
            {
                c.Adi,
                c.Ortalama
            }).ToList();

            // SINIFI GEÇENLERİN ADLARI VE CİNSİYETLERİ
            var anonim3 = (from a in ogrencis
                           where a.Ortalama >= ort
                           select new
                           {
                               a.Adi,
                               a.Cinsiyet
                           }).ToList();

            var anonim4 = ogrencis.Where(k => k.Ortalama >= ort).Select(c => new
            {
                c.Adi,
                c.Cinsiyet
            }).ToList();

            dataGridView1.DataSource = anonim4;
        }
    }
}