using System.ComponentModel.DataAnnotations;

namespace SocialExtractor.DataService.presentation.RequestModels
{
    public class AuthenticateModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
