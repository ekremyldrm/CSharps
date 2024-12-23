namespace _12_Linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            ogrencis.Add("gökberk");
            ogrencis.Add("ekrem");
            ogrencis.Add("şimal");
            ogrencis.Add("mahmut");
            ogrencis.Add("veli");
            ogrencis.Add("yiğit");
            ogrencis.Add("emine");
        }

        List<int> nums = new List<int> { 3, 5, 7, 8, 10, 12, 13, 14, 16, 18, 19, 20 };
        List<string> ogrencis = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> ondanKucukler = new List<int>();
            foreach (int i in nums)
            {
                if (i < 10)
                {
                    ondanKucukler.Add(i);
                }
            }

            List<int> ciftler = new List<int>();
            foreach (var i in nums)
            {
                if (i % 2 == 0)
                {
                    ciftler.Add(i);
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            // QUERY => SELECT FROM A => D'DAN SEÇ

            // LINQ => languafe Intgrated Query => dile entegre sorgulama dili
            List<int> temp = nums; // nums'i int'e ata...

            // numsları i'ye ata i'den seç
            List<int> temp1 = (from num in nums
                               select num).ToList();

            // bütün değerler a'ya atanır. a üzerine filtre (kriter) uygulanır ve uygun alar seçilerek değişkene atanır...

            List<int> ondanKucukler = (from a in nums // nums'in içerisindeki veriler a'ya atanır. for
                                       where a < 10 // kriter.. if koşulu gibi kullanıllır. şartlı ifade yazılır
                                       select a // seç 
                                       ).ToList();

            List<int> ciftSayilar = (from b in nums
                                     where b % 2 == 0
                                     select b).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ondan büyük çift sayıları alalım..
            var lst = (from a in nums
                       where a > 10 && a % 2 == 0
                       select a).ToList();




            // bütün elemanlar
            List<string> ogrencis1 = (from a in ogrencis
                                      select a).ToList();
            // e geçenler
            List<string> ogrencis2 = (from a in ogrencis
                                      where a.Contains("e")
                                      select a).ToList();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in ogrencis)
            {
                lboxOgrenciler.Items.Add(item);
            }
        }

        private void txtOgrenci_TextChanged(object sender, EventArgs e)
        {
            lboxOgrenciler.Items.Clear(); // elemanları sil
            //foreach (var item in ogrencis)
            //{
            //    if (item.Contains(txtOgrenci.Text))
            //    {
            //        lboxOgrenciler.Items.Add(item);
            //    }
            //}

            var filterList = (from a in ogrencis
                              where a.Contains(txtOgrenci.Text)
                              select a
                              ).ToArray(); // arraya dönüştür

            lboxOgrenciler.Items.AddRange(filterList);
        }
    }
}