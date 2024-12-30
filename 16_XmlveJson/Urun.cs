using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _16_XmlveJson
{

    public class StringWriterUTF8 : StreamWriter
    {
        public StringWriterUTF8(string path) : base(path)
        {
                
        }
        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }

    public class Urun
    {
        public string Adi { get; set; }

        public int Stok { get; set; }

        public string Kategori { get; set; }

        public bool Indirim { get; set; }

        public string stokdurum
        {
            get
            {
                if (Stok < 50)
                {
                    return "stok az";
                }
                else
                {
                    return "stok yeterli";
                }
            }
        }
    }
}
