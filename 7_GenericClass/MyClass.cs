using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_GenericClass
{
    // GenericType => C# içerisinde tip güvenliği sağlamak için kullanılan yapıdır.. Genel amaçlı bir sınıf, interface oluşturulduğunda bu varlığın gereksiz yere boxing,unboxing işlemlerine tabi tutulmasını engellemek için kullanılır. (koleksiyonlarda detaylı konuşulacaktır)

    // GenericTypler instance aşamasında tip belirlemek için kullanılır
    // <> generic operatörüdür.. eğer bu operatörü görüyorsanız bu tip generic tiptir..

    // <T> burada T keywördü tipi ifade eder.. hangi tipten instance alınacağını belirtir...

    // burada tanımlanan <t> içeride ğyelerin tipi belirlemek için kullanılır. ve tipler instance alındğında belirlenir...
    public class MyClass<t>
    {

    }

    public class Hesap<T>
    {
        public T Sayi1 { get; set; }
        public T Sayi2 { get; set; }
    }

    public class Calc
    {
        public object Sayi1 { get; set; }
        public object Sayi2 { get; set; }
        // Hesap sınıfı uygulama içerisinde iki numeric sayının aritmatic işlemini yapmak için tanımlanmış genel bir sınıftır...

        // Hesap<T> şfadesindeki <T>'nin bir tip olduğunu ve bunun instance aşamasında belirli olacağını belirtiyoruz ve bu tanıma generic type diyoruz...<t>'li ifade sınıfın üyelerini belirlemek için tanımlanır...
    }
}