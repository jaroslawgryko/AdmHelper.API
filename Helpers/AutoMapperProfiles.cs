using System;
using System.Linq;
using AdmHelper.API.Dtos;
using AdmHelper.API.Models;
using AutoMapper;

namespace AdmHelper.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
            .ForMember(dest => dest.InstytucjaNazwa, opt => {
                opt.MapFrom(src => src.Jednostki.FirstOrDefault(j => j.IsMain).Nazwa);
            });        

            CreateMap<User, UserForDetailedDto>()
            .ForMember(dest => dest.InstytucjaNazwa, opt => {
                opt.MapFrom(src => src.Jednostki.FirstOrDefault(j => j.IsMain).Nazwa);
            })
            .ForMember(dest => dest.InstytucjaSymbol, opt => {
                opt.MapFrom(src => src.Jednostki.FirstOrDefault(j => j.IsMain).Symbol);
            })
            .ForMember(dest => dest.InstytucjaOpis, opt => {
                opt.MapFrom(src => src.Jednostki.FirstOrDefault(j => j.IsMain).Opis);
            });

            CreateMap<Jednostka, JednostkaForDetailedDto>();     

            CreateMap<UserForUpdateDto, User>()
            .ForMember(dest => dest.Email, opt => {
                opt.MapFrom(src => src.Email);
            })
            .ForMember(dest => dest.Jednostki, opt => opt.Ignore())
            .AfterMap((us, ud) => {  
                ud.DataModyfikacji = DateTime.Now;                             
                ud.Jednostki.Where(j => j.UserId == ud.Id && j.IsMain).SingleOrDefault().Nazwa = us.InstytucjaNazwa;
                ud.Jednostki.Where(j => j.UserId == ud.Id && j.IsMain).SingleOrDefault().Symbol = us.InstytucjaSymbol;
                ud.Jednostki.Where(j => j.UserId == ud.Id && j.IsMain).SingleOrDefault().Opis = us.InstytucjaOpis;
                ud.Jednostki.Where(j => j.UserId == ud.Id && j.IsMain).SingleOrDefault().DataModyfikacji = DateTime.Now;                
            } );

        }
    }
}