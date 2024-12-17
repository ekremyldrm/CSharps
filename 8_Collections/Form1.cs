using System.Collections; // ArrayList, HasshTable vb. sınıfllar
using System.Collections.Generic; // List, Dictonry vb. sınıflar 
using System.ComponentModel;
using System.Configuration;
using System.Reflection;

namespace _8_Collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKonu_Click(object sender, EventArgs e)
        {
            // Aynı türden verileri Dizilerde (Array) ile birarada tutarız
            // Dizilerde verilerin türü aynı tipte olduğu için hızlıdır tip güvenliği vardır ancak uzunluk sabit olduğu için diziler bu noktada yetersizdir...
            // farklı türden verileri object türünden bir dizide tutabilir miyiz?

            string[] names = new string[1];
            names[0] = "Şimal";
            names[0] = "Eren"; // bir önceki değer ezdik..

            string[] arr = new string[3];
            arr[0] = "Veli";
            arr[1] = "Ekrem";
            arr[2] = "Yiğit";
            //   arr[2] = 100; // arraylar tip belirtildiği için farklı türde bir atama işlemi yapıldığında uygulama derlenemz

            object a = false; // boxing
            object b = 100;

            object[] objDizi = new object[3];
            objDizi[0] = "Gökberk"; // boxing
            objDizi[1] = "Eren"; // boxing
            objDizi[2] = 100; // boxing

            for (int i = 0; i < objDizi.Length; i++)
            {
                if (objDizi[i] is string) // n. eleman string mi?
                {
                    string str = (string)objDizi[i]; //unboxing
                }
                else if (objDizi[i] is int)
                {
                    int x = (int)objDizi[i];
                }
            }

            // c#^ta bütün tipler objectten türetilmiştir. object sınıfı bütün tiplerin atasıdır... 

            // Collections (kullanılmaz)m bunun yerine generic collection kullanılırızx
            // Collections ınıflarından arraylist ve hashtable sınıflarını inceliyoruz


            // dizinlerin uzunlukları sabit olduğu için kullanılmazlar.. 
            // koleksiyonlarda diziler gibi birden fazla veriyi bir arada tutmak için kullanılır. tek fark koleksiyonun uzunluğu dizi gibi sabit değildir...
            // koleksiyonlar ilk oluşturulduklarında uzunlukları 0'dır. koleksiyona eleman eklemek için Add metodu kullanılır. Add metodu ile dizide alan açılır ve eleman eklenir..

            ArrayList z = new ArrayList();
            MessageBox.Show(z.Count.ToString()); // KOLEKSİYONUN UZUNLUĞU 0'DIR

            z.Add("EKREM"); //UZUNLUK ARTTIRILIR VE SIRADAKİ İNDEXE ELEMAN EKLENİR. 

            MessageBox.Show(z.Count.ToString()); // UZUNLUK 1.DİR ÇÜNKÜ 1 ELEMANI VARDIR
            z.Add("yiğit"); // yeni bir eleman eklenir..

            // eleman eklemek için Add metodu kullanılır..
            // değer değiştirmek için [indexNo] kullanıır
            z[1] = "YİĞİT";
            //z[0] = "YİĞİT";
            z.Add("MAHMUT");

            ArrayList nums = new ArrayList();
            nums.Add(7);
            nums.Add(3);
            nums.Add(23);
            nums.Add(22);

            nums.Sort(); // koleksiyonu sıralar...

            for (int i = 0; i < nums.Count; i++)
            {
                MessageBox.Show(nums[i].ToString());
            }


            // tip güvenliği yoktur.. dikkayli kullanmak gerekir atanan tipten emin olmalısınız..

            // array listeler object türünden veri saklarlar... 
            // boxing unboxing işlemi yapıldığı için performanslı değildir....

            ArrayList yazilim = new ArrayList();
            yazilim.Add(12);
            yazilim.Add("oniki");
            yazilim.Remove("oniki"); // koleksiyondan eleman siler
            yazilim.Clear(); // elemanları siler


            // dizilierde ve arraylist sınıflarında indexler 0'dan başlar ve indexler numerictir...hastatable sınıfında eleman eklerken dizinin indexi'de bizim tarafımızdan belirlenir..

            // hastable'DA key (index) unique olmalıdır...
            Hashtable hst = new Hashtable();
            hst.Add("a", "EKREM");
            hst.Add("b", "EREN");
            hst.Add("c", "Şimal");
            hst.Add(4, "Gökberk");
            // hst.Add("a", "Yiğit"); // a indexi daha önce oluşturuldu için bir daha oluşturulamaz.
            hst["a"] = "Yiğit"; // a. indexi Yipit olarak değiştir

            string deneme = (string)hst["b"];

            // koleksiyonlar object türündn verisakladığı için eklenen her eleman boxing ve unboxin işlemine tabi tutatlacağı için performans problemi (büyük verilerde) oluşturacaktır...

            // Generic Collections (kullanılınır)
            // list sınıfı en sık kullanılan generic koleksiyondur. koleksiyonlarda uzun belirtmeden istediğimiz kadar aynı türden elemanı bir arada tutmak için kullanılır

            List<string> list = new List<string>();
            list.Add("Ekrem"); // Add metodu eleman ekler. 
            list.Add("Şimal");
            list.Add("Emine");
            list.Add("Eren");

            List<int> ints = new List<int>();
            ints.Add(10);
            ints.Add(5);
            ints.Add(20);
            ints.Add(15);

            // index bazlı erişim
            for (int i = 0; i < ints.Count; i++)
            {
                MessageBox.Show(ints[i].ToString());
            }
            // foreach ile
            foreach (int i in ints)
            {
                MessageBox.Show(i.ToString());
            }

            // list sınıfı extra bir sınıf gerektirmeden dizi üzerinde işlemleri metot yardımıyla yapılabilir
            ints.Sort();
            int max = ints.Max();
            int min = ints.Min();
            int sum = ints.Sum();
            double ort = ints.Average();
            int sonuc = ints.IndexOf(15); // 2
            int sonuc2 = ints.IndexOf(25); // -1

            // elemanlar sabitse eğer bu şekilde verilebilir
            List<char> chars = new List<char>() { 'a', 'b', 'c' };
            foreach (char c in chars)
            {
                MessageBox.Show(c.ToString());
            }


            Dictionary<string, string> dicts = new Dictionary<string, string>();
            dicts.Add("a", "EKREM");
            dicts.Add("b", "Şimal");
            dicts.Add("c", "Emine");

            dicts.Add("a", "YİĞİT"); // KEY (İNDEX) İSİMLERİ UNİQUE (BENZERSİZ) OLMALIDIR

            string dic = dicts["b"]; // sadece value verir...
            KeyValuePair<string, string> keyValue = dicts.ElementAt(0); // 0. indexteki dictnory'i verir.. key ve valuese ile 

            foreach (KeyValuePair<string, string> pair in dicts) {
                MessageBox.Show(pair.Value);
            }
            
            for (int i = 0; i < dic.Length; i++)
            {
                string key = dicts.Keys.ElementAt(i);
                string value = dicts.Values.ElementAt(i);
            }

            Dictionary<int, string> dicts2 = new Dictionary<int, string>();
            dicts2.Add(4, "Gökberk");


            Dictionary<string, string> kisiBilgisi = new Dictionary<string, string>();
            kisiBilgisi.Add("Adi", "EKREM");
            kisiBilgisi.Add("SoyAdi", "YILDIRIM");

        }
    }
    public class Test
    {
        string A;
        int B;
    }
}
