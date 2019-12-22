using Microsoft.Extensions.DependencyInjection;
using SocialExtractor.DataService.common.Helpers;
using SocialExtractor.DataService.data.Models;
using SocialExtractor.DataService.data.Repositories;
using SocialExtractor.DataService.data.XAL;

namespace SocialExtractor.DataService.domain.Frameworks
{
    public class ServiceManager
    {
        public static void InjectServices(IServiceCollection services)
        {
            services.AddScoped<ISocialRepository, SocialRepository>();
            services.AddScoped<IDocumentRepository<SocialList>, MongoBaseRepository<SocialList>>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ISocialXmlAccessLayer, SocialXmlAccessLayer>();

            services.AddScoped<IPasswordHasher, PasswordHasher>();
        }
    }
}
