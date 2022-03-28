using AutoMapper;
using StokTakip.Core.Utilities.Results.Abstract;
using StokTakip.Core.Utilities.Results.ComplexType;
using StokTakip.Core.Utilities.Results.Concrete;
using StokTakip.Data.Abstract;
using StokTakip.Entities.Concrete;
using StokTakip.Entities.Dtos.KategoriDtos;
using StokTakip.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Services.Concrete
{
    public class KategoriManager : IKategoriService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public KategoriManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<KategoriDto>> Add(KategoriAddDto dto)
        {
            var kategori = _mapper.Map<Kategori>(dto);
            var addkategori = await _unitOfWork.Kategori.AddAsync(kategori);
            await _unitOfWork.SaveAsync();

            return new DataResult<KategoriDto>(ResultStatus.Success, "Kayıt eklendi", new KategoriDto
            {
                ResultStatus = ResultStatus.Success,
                Message = "Kayıt eklendi",
                Kategori = addkategori
            });

        }

        public async Task<IResult> Delete(int id)
        {
            var data = await _unitOfWork.Kategori.GetAsync(m => m.Id == id);
            if(data != null)
            {
                data.IsDelete = true;
                data.UpdatedDate = DateTime.Now;
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Kayıt güncellendi");
            }
            return new Result(ResultStatus.Error, "Kayıt bulunamadı");

        }

        public async Task<IDataResult<KategoriDto>> Get(int id)
        {
            var kategori = await _unitOfWork.Kategori.GetAsync(m => m.Id == id);
            if (kategori is not null)
            {
                return new DataResult<KategoriDto>(ResultStatus.Success, new KategoriDto
                {
                    Kategori = kategori,
                    ResultStatus = ResultStatus.Success
                });
            }

            return new DataResult<KategoriDto>(ResultStatus.Error, new KategoriDto
            {
                ResultStatus = ResultStatus.Error,
                Message = "Böyle bir kayıt bulunamadı",
                Kategori = null
            });
        }

        public async Task<IDataResult<KategoriListDto>> GetAll()
        {
            var data = await _unitOfWork.Kategori.GetAllAsync();
            if (data.Count > -1)
            {
                return new DataResult<KategoriListDto>(ResultStatus.Success, new KategoriListDto
                {
                    Kategoriler = data,
                    Message = "İşlem başarılı",
                    ResultStatus = ResultStatus.Success
                });
            }
            return new DataResult<KategoriListDto>(ResultStatus.Error, new KategoriListDto
            {
                Kategoriler = null,
                Message = "İşlem başarısız",
                ResultStatus = ResultStatus.Error
            });
        }

        public async Task<IResult> HardDelete(int id)
        {
            var data = await _unitOfWork.Kategori.GetAsync(m => m.Id == id);
            if (data is not null)
            {
                await _unitOfWork.Kategori.DeleteAsync(data);
                await _unitOfWork.SaveAsync();
                return new Result(ResultStatus.Success, "Kayıt Silindi");
            }
            return new Result(ResultStatus.Error, "Kayıt bulunamadı");
        }

        public async Task<IDataResult<KategoriDto>> Update(KategoriUpdateDto dto)
        {
            var birim = _mapper.Map<Kategori>(dto);
            var update = await _unitOfWork.Kategori.UpdateAsync(birim);
            await _unitOfWork.SaveAsync();
            return new DataResult<KategoriDto>(ResultStatus.Success, "Kayıt güncelledi", new KategoriDto
            {
                ResultStatus = ResultStatus.Success,
                Message = "Kayıt güncellendi",
                Kategori = update
            });
        }
    }
}
