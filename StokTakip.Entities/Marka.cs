using StokTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities
{
    public class Marka : BaseEntity
    {
        public string MarkaAdi { get; set; }
        public string Aciklama { get; set; }

        public Kategori KategoriId { get; set; }
        public Kategori Kategori { get; set; }

        public ICollection<Urun> Urunler { get; set; }
    }
}
