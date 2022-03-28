using StokTakip.Core.Utilities.Results.Abstract;
using StokTakip.Entities.Dtos.KategoriDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Services.Abstract
{
    public interface IKategoriService
    {
        Task<IDataResult<KategoriDto>> Get(int id);
        Task<IDataResult<KategoriListDto>> GetAll();
        //Task<IDataResult<KategoriListDto>> GetAllByNonDelete();
        //Task<IDataResult<KategoriListDto>> GetAllByNonDeleteAndActive();
        Task<IDataResult<KategoriDto>> Add(KategoriAddDto dto);
        Task<IDataResult<KategoriDto>> Update(KategoriUpdateDto dto);
        Task<IResult> Delete(int id);
        Task<IResult> HardDelete(int id);
    }
}
