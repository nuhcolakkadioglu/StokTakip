using StokTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
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
