using StokTakip.Core.Entities.Abstract;
using StokTakip.Entities.Concrete;

namespace StokTakip.Entities.Dtos.BirimDtos
{
    public class BirimDto : DtoGetBase
    {
        public Birim Birim { get; set; }
    }
}
