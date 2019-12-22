using System.Collections.Generic;

namespace SocialExtractor.DataService.data.Models
{
    public class SocialList : SocialListBase
    {
        public List<MediaPost> MediaPosts { get; set; }
    }
}
