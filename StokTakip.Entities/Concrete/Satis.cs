using StokTakip.Core.Entities.Abstract;

namespace StokTakip.Entities.Concrete
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
        public int SepetId { get; set; }
        public Sepet Sepet { get; set; }
    }
}
