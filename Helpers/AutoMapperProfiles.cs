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
            .ForMember(dest => dest.JednostkaNazwa, opt => {
                opt.MapFrom(src => src.Jednostki.FirstOrDefault(j => j.IsMain).Nazwa);
            });        

            CreateMap<User, UserForDetailedDto>()
            .ForMember(dest => dest.JednostkaNazwa, opt => {
                opt.MapFrom(src => src.Jednostki.FirstOrDefault(j => j.IsMain).Nazwa);
            });  

            CreateMap<Jednostka, JednostkaForDetailedDto>();            
        }
    }
}