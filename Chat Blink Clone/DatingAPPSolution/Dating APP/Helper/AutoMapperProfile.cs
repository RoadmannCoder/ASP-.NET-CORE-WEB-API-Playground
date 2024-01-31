using AutoMapper;
using Dating_APP.DTOs;
using Dating_APP.Entities;
using Dating_APP.Extension;

namespace Dating_APP.Helper
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, MemberDTO>()
               .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
                   src.Photos.FirstOrDefault(x => x.IsMain).Url))
               .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDTO>();
        }
    }
}
