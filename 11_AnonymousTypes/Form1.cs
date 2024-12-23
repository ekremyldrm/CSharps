namespace _11_AnonymousTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Anonymous Type (Anonim Tipler) 

            //ANLIK RUNTİME'DA TİP OLUŞTURMAK İÇİN KULLANILAN TİPLERDİR...(geçeci bir class oluşturmak gibi düşünebilirsiniz) genelde verinin gösteriminde verinin paylaşımında tercih edilr...

            // new { uyeler }

            var o = new
            {
                Adi = "ekrem",
                Cinsiyet = 'E',
                Yas = 36,
                Durum = false
            };

            // anonim tip new {} ifadesidir...
            // o tipli var değişkeninimiz yukarıdaki gibi anonim tip tuttuğu için aşağıdaki bir atama yapılamaz...
            //o = new
            //{
            //    Adi = "ekrem",
            //    Cinsiyet = 'E',
            //    Yas = 36
            //};

            // anonim tipli üyelerin değerleri ready only'dir sadece okunabilir. değer sadece oluşturulduğunda atanabilir..
            //  o.Adi = "eren";

            MessageBox.Show(o.GetType().ToString());
            MessageBox.Show($"{o.Adi} {o.Cinsiyet} {o.Yas} {o.Durum}");


            var anonimList = new[]
            {
                new { Adi = "Gökberk", Yas = 29 },
                new { Adi="Şimal",Yas=18 },
                new { Adi = "Veli",Yas=35},
                new { Adi="MAHMUT",Yas=43}
            };

            foreach (var item in anonimList)
            {
                MessageBox.Show($"{item.Adi} - {item.Yas}");
            }

            var i = 1;

            var p = new Product(); //'p'nin tipi producttır
            p.Name = "Tampon";
            p.Price = 5000;
            p.Color = "Beyaz";

            // instance alma 2. yol
            // object intializer
            Product p1 = new Product { Name = "Çamurluk", Price = 10000, Color = "Bayaz" };

            Product p2 = new Product { Name = "Çamurluk", Price = 10000, Color = "Bayaz" };

            var p3 = new Product { Name = "Çamurluk", Price = 10000, Color = "Bayaz" };

            // product nesnesinin bazı üyelerini p4 anonimine atadık...
            var p4 = new { Adi = p1.Color, Renk = p1.Color };

        }
    }
}
