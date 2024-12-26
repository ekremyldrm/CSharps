using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ExtensionMetot_Enum
{

    // extension metots => (uzantı) metot...
    // this komutu Ogrenci instance üzreinden bu metota erişleceğini belirtir...

    public static class myMetot
    {
        public static void BilgiGoster(this Ogrenci ogr)
        {
            MessageBox.Show($"{ogr.Adi} - {ogr.Cinsiyet}");
        }

        // List sınıfı IList interfacesinden türediği için parametre IListten türeyen bütün instanceler üzrinden count çağrılabilir..
        public static int Sayi(this IList list)
        {
            return list.Count;
        }

        public static string stringeDonustur<TSource>(this IEnumerable<TSource> list)
        {
            return  string.Join(",", list);
        }
    }

    // static üye => sınıf üyesinin instance alınmadan erişlebildiği üyeleridir...

    public class Ogrenci
    {
        public string Adi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        public void ShowInfo()
        {
            MessageBox.Show($"{this.Adi} - {this.Cinsiyet}");
        }
    }
}
