using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_StaticClass
{
    // static classs
    public class MyClass
    {
        // static üyeler genelde sabit ve ortak değer için kullanılır....

        // Static Member (Static Üyeler)
        public int a;
        public static int b;
        public static void MesajGoster()
        {
            b = 44;
            //    a = 45; a üyesi non static oldığu için static üye içerisinden erişilemez...
        }

        public string Text { get; set; }

        // static üyeye sinifAdi.Uye ile erişilir. static üyeler normal üyeler (non-static) gibi nesne üzerinden çağrılamaz. ve farklı instancelarda kullanılamaz...
        //static üyeler    => classAdi.UyeAdi
        //nonstatic üyeler => nesneadi.UyeAdi


    }


    public class Dosya
    {
        public static string KlasorPath { get; set; } = "C\\ProgramFiles";
        public string DosyaAdi { get; set; }
        public decimal Boyut { get; set; }
        public string Uzanti { get; set; }
    }


    // Static class instance alınawmayan classlardır.. 
    // eüer üyeler static olacaksa (ortak bir değer atanacaksa veya ortak işlem yapılacaksa, örneği n tablobu bir veritabanın adı, veya n adet dosyanın bulunduğu path gibi) üye static olabilir. Bu durumda üyerlin static olduğu bir durumda sınıfınında static olması iyi olur


    // static sınıfnın static olmayan (non-static) sınıftan tek farkı instance alınamamasıdır..

    public static class Test
    {

        public static void adi()
        {

        }

    }
}
