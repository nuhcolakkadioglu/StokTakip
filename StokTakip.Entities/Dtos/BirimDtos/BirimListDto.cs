using StokTakip.Core.Entities.Abstract;
using StokTakip.Entities.Concrete;

namespace StokTakip.Entities.Dtos.BirimDtos
{
    public class BirimListDto : DtoGetBase
    {
        public IList<Birim> Birimler { get; set; }
    }
}
