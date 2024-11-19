using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bgt_ntp2_19Kas_1
{
    internal class Kitap
    {
        public string kitapAdi;
        public string yazarAdi;
        public string yayinEvi;
        public int basimYili;
        public Kitap(string kAd,string yAd, string yEvi,int yil)
        {
            this.kitapAdi = kAd;
            this.yazarAdi = yAd;
            this.yayinEvi = yEvi;
            this.basimYili = yil;
        }
    }
}
