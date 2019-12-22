using SocialExtractor.DataService.common.Models;

namespace SocialExtractor.DataService.common.Helpers
{
    public interface IPasswordHasher
    {
        string Hash(string password);
        PasswordCheck Check(string hash, string password);
    }
}
