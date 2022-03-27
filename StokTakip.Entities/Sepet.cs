using StokTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    public class Sepet : BaseEntity
    {
        public string UrunAdi { get; set; }
        public string BarkodNo { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public decimal ToplamFiyat { get; set; }
        public decimal Miktar { get; set; }
        public int Kdv { get; set; }
        public DateTime Tarih { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public int MarkaId { get; set; }
        public Marka Marka { get; set; }
        public int BirimId { get; set; }
        public Birim Birim { get; set; }
    }
}
