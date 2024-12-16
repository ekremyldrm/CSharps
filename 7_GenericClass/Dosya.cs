using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_GenericClass
{
    // where T : class yazarak tipin Class olduğunu söylüuoruz. Class tipinde bir tip verilebilir...
    public class Islem<T> where T : class
    {
        public void Kaydet(T deger)
        {
        }
    }

    public class Ogretmen
    {
        // üyeleri tanımladık...
    }

    public class Ogrenci
    {
        // üyeleri tanımadık..
    }
}
