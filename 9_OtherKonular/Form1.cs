namespace _9_OtherKonular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  reference type =>  class tipindeki bütün varlıklar

            //  value type   => struct tipindeki bütün varlıklar

            // null sadece referans tiplerde kullanıldığı için value type'lara atanamaz...

            int stok = 0; // stok 0
            // bir value type'in null olması isteniyorsa nullable olarak işaretlenmesi gerekir..

            // nullable 1. yol (**)
            int? stock = null;
            stock = 10;

            int? a = stock;

            // nullable 2. yol
            Nullable<int> vize = null;


            // nullable tipli bir değişkeni not nullable bir değişkene atama...
            // eğer değer null ise atama yapmaz hata verir..

            //int b = (int)stock;

            // HasValue => nullable tipte verinin olup olmadığını belirtir...varsa true, yoksa false döner

            // Value   => nullable tipli deşkenin default değerini gösterir...

            // 1. yol
            if (stock.HasValue) // stok'un değeri varsa
            {
                int b = (int)stock; // cast ederek int'e dönüştür
            }

            // 2. yol 

            if (vize.HasValue)
            {
                int c = vize.Value;
            }


            // ternary if..
            // 3 yol
            int d = stock.HasValue ? stock.Value : 0;


            // 4 yol
            int f = stock ?? 0; // değer yoksa 0, varsa değer

            int? x = null;
            int y = 50;
            int z = 0;

            int k = (x ?? 0) + y + z;


            // değer tutan tipler null olamaz. çünkü null bir değer değildir.. eğer değer tipin null tutmasını istiyorsak nullable yapmamız gerekir. ? veya Nullable generic'ini kullanarak nullable yapaibliriz.. yaygın kullanım ? operatörüdür..

            bool? m = null;
            float? n = null;
            Nullable<double> b = null;
            //m.Value => bool
            //n.Value => float
            //b.Value  => double

            // değer tutmayan tipler (referans tipler) null olabilir
            string c = null;
            string l = "ekrem";
        }
    }
}
