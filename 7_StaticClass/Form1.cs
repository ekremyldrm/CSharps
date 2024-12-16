namespace _6_StaticClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass myc = new MyClass();
            myc.Text = "gökberk";  // bu non-static üyedir....

            MyClass my1 = new MyClass();
            my1.Text = "Ekrem";


            MyClass.MesajGoster(); // static üyeler.


            // Static üyeler instance alınmadan çağrıulabilen üyelerdir. 
            // static üyeler sınıf derlenmesi ile oluşur..


            //Test stk = new Test(); // static sınıflardan instance alınamaz...

            Test.adi();
        }
    }
}
