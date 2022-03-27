using StokTakip.Core.Entities.Abstract;

namespace StokTakip.Entities.Concrete
{
    public class Birim : BaseEntity
    {
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Urun> Urunler { get; set; }
        public ICollection<Sepet> Sepetler { get; set; }
    }
}
