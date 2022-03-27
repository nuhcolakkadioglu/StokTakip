using StokTakip.Core.Entities.Abstract;

namespace StokTakip.Entities.Concrete
{
    public class Musteri : BaseEntity
    {
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Resim { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Puan { get; set; }
        public string Aciklama { get; set; }
    }
}
