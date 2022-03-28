using StokTakip.Core.Entities.Abstract;
using StokTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Entities.Dtos.KategoriDtos
{
    public class KategoriListDto: DtoGetBase
    {
        public IList<Kategori> Kategoriler { get; set; }
    }
}
