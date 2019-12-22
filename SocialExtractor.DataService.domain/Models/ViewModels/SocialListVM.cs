using System.Collections.Generic;

namespace SocialExtractor.DataService.domain.Models.ViewModels
{
    public class SocialListVM : SocialListBaseVM
    {
        public List<MediaPostVM> MediaPosts { get; set; }

        public SocialListVM() { }
    }
}
