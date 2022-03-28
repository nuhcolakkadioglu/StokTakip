using AutoMapper;
using StokTakip.Entities.Concrete;
using StokTakip.Entities.Dtos.BirimDtos;
using StokTakip.Entities.Dtos.KategoriDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Services.AutoMapper.Profiles
{
    public class MapsProfile:Profile
    {
        public MapsProfile()
        {
            CreateMap<BirimAddDto,Birim>().ForMember(dest=>dest.CreatedDate,opt =>opt.MapFrom(x=>DateTime.Now));
            CreateMap<BirimUpdateDto ,Birim>().ForMember(dest =>dest.UpdatedDate,opt => opt.MapFrom(x=>DateTime.Now));
            CreateMap<Birim, BirimDto>().ReverseMap();
            CreateMap<Birim, BirimListDto>().ReverseMap();

            CreateMap<KategoriAddDto, Kategori>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<KategoriUpdateDto, Kategori>().ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Kategori, KategoriDto>().ReverseMap();
            CreateMap<Kategori, KategoriListDto>().ReverseMap();

        }
    }
}
