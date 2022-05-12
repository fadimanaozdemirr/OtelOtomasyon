using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeritabaniProje
{
    public class Rezervasyon
    {
        public int rezervasyon_id { get; set; }
        public DateTime baskangic_tarih { get; set; }
        public DateTime cikis_tarih { get; set; }
        public float toplam_fiyat { get; set; }
        public int gun_sayisi { get; set; }

    }
}
