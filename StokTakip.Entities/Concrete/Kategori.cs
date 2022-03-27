using StokTakip.Core.Entities.Abstract;

namespace StokTakip.Entities.Concrete
{
    public class Kategori : BaseEntity
    {
        public string Adi { get; set; }
        public string Aciklama { get; set; }

        public ICollection<Marka> Markalar { get; set; }
        public ICollection<Urun> Urunler { get; set; }
        public ICollection<Sepet> Sepetler { get; set; }


    }
}
