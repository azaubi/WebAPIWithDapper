using Microsoft.Extensions.DependencyInjection;
using WebAPIWithDapper.Data.Repos;

namespace WebAPIWithDapper.Services
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddTransients();
        }

        public static void AddTransients(this IServiceCollection services)
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .Where(x => !string.IsNullOrEmpty(x.FullName) && x.FullName.StartsWith("WebAPIWithDapper"))
                .SelectMany(x => x.DefinedTypes)
                .Where(type => type.IsClass && !type.IsAbstract)
                .ToList();

            foreach (var type in types)
            {
                foreach (var implementation in type.ImplementedInterfaces)
                {
                    services.AddTransient(implementation, type);
                }
            }
        }
    }
}
