using AutoMapper;

namespace MVCCore.BoilerPlate.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Login, LoginModel>().ReverseMap();
            
           // CreateMap<Login, RegisterModel>().ReverseMap();

           // CreateMap<Login, PasswordResetModel>()
                //.ForMember(dest => dest.NewPassword, opt => opt.MapFrom(src => src.Password))
                //.ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src.EmailAddress)).ReverseMap();
     
        }
    }
}
