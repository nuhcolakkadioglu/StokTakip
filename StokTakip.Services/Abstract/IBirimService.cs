using StokTakip.Core.Utilities.Results.Abstract;
using StokTakip.Entities.Dtos.BirimDtos;

namespace StokTakip.Services.Abstract
{
    public interface IBirimService
    {
        Task<IDataResult<BirimDto>> Get(int birimId);
        Task<IDataResult<BirimListDto>> GetAll();
        Task<IDataResult<BirimListDto>> GetAllByNonDelete();
        Task<IDataResult<BirimListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<BirimDto>> Add(BirimAddDto dto);
        Task<IDataResult<BirimDto>> Update(BirimUpdateDto dto);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);

    }
}
