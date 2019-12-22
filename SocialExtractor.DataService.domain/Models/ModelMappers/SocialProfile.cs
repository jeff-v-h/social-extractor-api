using AutoMapper;
using PLP.Social.DataService.data.Models;
using SocialExtractor.DataService.domain.Models.ViewModels;

namespace SocialExtractor.DataService.domain.Models.ModelMappers
{
    public class SocialProfile : Profile
    {
        public SocialProfile()
        {
            CreateMap<SocialList, SocialListVM>();
            CreateMap<SocialListVM, SocialList>();

            CreateMap<MediaPost, MediaPostVM>();
            CreateMap<MediaPostVM, MediaPost>();

            CreateMap<Attachment, AttachmentVM>();
            CreateMap<AttachmentVM, Attachment>();

            CreateMap<SocialListBase, SocialListBaseVM>();
            CreateMap<SocialListBaseVM, SocialListBase>();

            CreateMap<SocialMediaListsDetails, SocialMediaListsDetailsVM>();
            CreateMap<SocialMediaListsDetailsVM, SocialMediaListsDetails>();

            CreateMap<SocialList, SocialListBase>();
            CreateMap<SocialListBase, SocialList>();
        }
    }
}
