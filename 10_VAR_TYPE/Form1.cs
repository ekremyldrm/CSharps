namespace _10_VAR_TYPE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // var type
            // değişken oluşturuken veritipi belirlenir sonrasında uygun veri atanır.
            // önce tip belirlenir sonra değer atanır...
            int a = 1;
            int b;
            b = 1;

            // var anahtar sözcüğü oluşturulan değişkenlerde değişken oluşturulup değer atandığında tip belirlenir..
            var c = "şimal"; // tip string
            var d = 30; // tip int
            var f = false; // tip bool
            var k = new Button();// tipi button
            var l = 3.1; // tipi double

            //var'da tip değer atandığında belirlenir, daha sonra bu değer değiştirilemez...
            var m = "gökberk";
            m = "GÖKBERK";

            // m = 1; ilk değer ne atandıysa 

            // varda tip ilk değer atandığında oluştuğu için değişken oluşturulduğunda değer atanmalıdır...
            //var n; // n değişkenine değer atanmadığı için tipi belirlenemedi bu şekilde program derlenmez
            // eğer değer başlangıçta atanamıyorsa default keywırdü ile tip belirlenir..

            var n = default(string); // var'in değeri string olarak belirlenir...

            n = "Veli";

        }

    }

}

