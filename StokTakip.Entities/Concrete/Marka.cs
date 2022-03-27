using StokTakip.Core.Entities.Abstract;

namespace StokTakip.Entities.Concrete
{
    public class Marka : BaseEntity
    {
        public string MarkaAdi { get; set; }
        public string Aciklama { get; set; }

        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }


        public ICollection<Urun> Urunler { get; set; }
        public ICollection<Sepet> Sepetler { get; set; }

    }
}
