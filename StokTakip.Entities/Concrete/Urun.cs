using StokTakip.Core.Entities.Abstract;

namespace StokTakip.Entities.Concrete
{
    public class Urun : BaseEntity
    {
        public string UrunAdi { get; set; }
        public string BarkodNo { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public int Kdv { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }

        public int MarkaId { get; set; }
        public Marka Marka { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public int BirimId { get; set; }
        public Birim Birim { get; set; }

        public ICollection<Sepet> Sepetler { get; set; }
    }
}
