using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPratik
{
    public class DikUcgen : GemotrikSekil
    {
        // Dik üçgenin alanı (genişlik * yükseklik) / 2 olarak hesaplanır
        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;
        }
    }
}
