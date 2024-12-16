


namespace _3_ClassTipleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // NamespaceAdi.SinifAdı şekilinde bir kullanımda söz konusudur.  örnek;
            _2_SinifKutuphanesi.Mahmut m = new _2_SinifKutuphanesi.Mahmut();

            // yukarıdaki gibi bir kullanımda farklı namespacelerde aynı isimde bir sınıf söz konusu ise bu şekilde kullanım olabilir onun dışında kullanıma gerek yoktur. örnek;
            a_nmp.Simal s1 = new a_nmp.Simal();

            b_npm.Simal s2 = new b_npm.Simal();


        }
    }
}


// farklı bir namespace (farklı proje)
namespace a_nmp
{
    public class Simal
    {

    }
}

// farklı  namespace (farklı proje)
namespace b_npm
{
    public class Simal
    {

    }
}

