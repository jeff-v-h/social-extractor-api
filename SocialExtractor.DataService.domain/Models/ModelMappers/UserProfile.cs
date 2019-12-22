using AutoMapper;
using SocialExtractor.DataService.data.Models.User;
using SocialExtractor.DataService.domain.Models.ViewModels;

namespace SocialExtractor.DataService.domain.Models.ModelMappers
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserVM>();
            CreateMap<UserVM, User>();
        }
    }
}
