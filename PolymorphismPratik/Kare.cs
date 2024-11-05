using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPratik
{
    public class Kare : GemotrikSekil
    {
        // Karenin alanı (genişlik * yükseklik) olduğundan Base metodu kullanılır
        public override double AlanHesapla()
        {
            return base.AlanHesapla();
        }
    }
}
