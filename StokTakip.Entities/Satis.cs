using StokTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    public class Satis : BaseEntity
    {
        public string BarkodNo { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Miktar { get; set; }
        public decimal ToplamFiyat { get; set; }
        public int Kdv { get; set; }
        public DateTime Tarih { get; set; }
        public int BirimId { get; set; }
        public Birim Birim { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public Sepet SepetId { get; set; }
        public Sepet Sepet { get; set; }
    }
}
