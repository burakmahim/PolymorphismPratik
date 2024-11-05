using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPratik
{
    public class GemotrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        // Alan hesaplama metodu (override edilebilir)
        public virtual double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }
}
