using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ClassType_Partial
{

    // PARTİAL CLASSSS

    // partial keywordü aynı isimide birden fazla class oluştur için kullanılır..
    public partial class Ogrenci
    {
        public Ogrenci()
        {
            Kurs = "BT AKADEMİ";
        }

        public string Adi { get; set; }

        public string Kurs;


    }

    public partial class Ogrenci
    {
        public string SoyAdi { get; set; }

        public void BilgiGoster()
        {
            MessageBox.Show(Kurs);
        }
    }
}
