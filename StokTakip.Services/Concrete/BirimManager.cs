using AutoMapper;
using StokTakip.Core.Utilities.Results.Abstract;
using StokTakip.Core.Utilities.Results.ComplexType;
using StokTakip.Core.Utilities.Results.Concrete;
using StokTakip.Data.Abstract;
using StokTakip.Entities.Concrete;
using StokTakip.Entities.Dtos.BirimDtos;
using StokTakip.Services.Abstract;

namespace StokTakip.Services.Concrete
{
    public class BirimManager : IBirimService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BirimManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<BirimDto>> Add(BirimAddDto dto)
        {
            var birim = _mapper.Map<Birim>(dto);
            var addBirim = await _unitOfWork.Birim.AddAsync(birim);
            await _unitOfWork.SaveAsync();

            return new DataResult<BirimDto>(ResultStatus.Success, "Kayıt eklendi", new BirimDto
            {
                ResultStatus = ResultStatus.Success,
                Message = "Kayıt eklendi",
                Birim = addBirim
            });
        }

        public async Task<IResult> Delete(int id)
        {
            var data = await _unitOfWork.Birim.GetAsync(m => m.Id == id);
            if (data is not null)
            {
                data.IsDelete = true;
                data.UpdatedDate = DateTime.Now;
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Kayıt güncellendi");
            }
            return new Result(ResultStatus.Error, "Kayıt bulunamadı");
        }

        public async Task<IDataResult<BirimDto>> Get(int birimId)
        {
            var birim = await _unitOfWork.Birim.GetAsync(m => m.Id == birimId);
            if (birim is not null)
            {
                return new DataResult<BirimDto>(ResultStatus.Success, new BirimDto
                {
                    Birim = birim,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<BirimDto>(ResultStatus.Error, new BirimDto
            {
                ResultStatus = ResultStatus.Error,
                Message = "Böyle bir kayıt bulunamadı",
                Birim = null
            });
        }

        public async Task<IDataResult<BirimListDto>> GetAll()
        {
            var data = await _unitOfWork.Birim.GetAllAsync();
            if (data.Count > -1)
            {
                return new DataResult<BirimListDto>(ResultStatus.Success, new BirimListDto
                {
                    Birimler = data,
                    Message = "İşlem başarılı",
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BirimListDto>(ResultStatus.Error, new BirimListDto
            {
                Birimler = null,
                Message = "İşlem başarısız",
                ResultStatus = ResultStatus.Error
            });
        }

        public async Task<IDataResult<BirimListDto>> GetAllByNonDelete()
        {
            var data = await _unitOfWork.Birim.GetAllAsync(m => !m.IsDelete);

            if (data.Count > -1)
            {
                return new DataResult<BirimListDto>(ResultStatus.Success, new BirimListDto
                {
                    Birimler = data,
                    Message = "İşlem başarılı",
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BirimListDto>(ResultStatus.Error, new BirimListDto
            {
                Birimler = null,
                Message = "İşlem başarısız",
                ResultStatus = ResultStatus.Error
            });
        }

        public async Task<IDataResult<BirimListDto>> GetAllByNonDeleteAndActive()
        {
            var data = await _unitOfWork.Birim.GetAllAsync(m => !m.IsDelete && m.IsActive);

            if (data.Count > -1)
            {
                return new DataResult<BirimListDto>(ResultStatus.Success, new BirimListDto
                {
                    Birimler = data,
                    Message = "İşlem başarılı",
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<BirimListDto>(ResultStatus.Error, new BirimListDto
            {
                Birimler = null,
                Message = "İşlem başarısız",
                ResultStatus = ResultStatus.Error
            });
        }

        public async Task<IResult> HardDelete(int id)
        {
            var data = await _unitOfWork.Birim.GetAsync(m => m.Id == id);
            if (data is not null)
            {
                await _unitOfWork.Birim.DeleteAsync(data);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Kayıt Silindi");
            }
            return new Result(ResultStatus.Error, "Kayıt bulunamadı");
        }

        public async Task<IDataResult<BirimDto>> Update(BirimUpdateDto dto)
        {
            var birim = _mapper.Map<Birim>(dto);
            var updateBirim = await _unitOfWork.Birim.UpdateAsync(birim);
            await _unitOfWork.SaveAsync();
            return new DataResult<BirimDto>(ResultStatus.Success, "Kayıt güncelledi", new BirimDto
            {
                ResultStatus = ResultStatus.Success,
                Message ="Kayıt güncellendi",
                Birim = updateBirim
            });
        }
    }
}
