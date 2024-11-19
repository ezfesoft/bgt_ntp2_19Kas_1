using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bgt_ntp2_19Kas_1
{
    internal class Uye
    {
        public string uyeAdi;
        public string uyeSoyadi;
        public string uyeTel;
        public int uyeYas;

        public Uye(string uAd, string uSoyad, string uTel, int uYas)
        {
            this.uyeAdi = uAd;
            this.uyeSoyadi = uSoyad;
            this.uyeTel = uTel;
            this.uyeYas = uYas;
        }
    }
}
