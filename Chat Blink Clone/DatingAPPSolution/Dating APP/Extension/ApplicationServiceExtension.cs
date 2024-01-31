using Dating_APP.Data;
using Dating_APP.Interfaces;
using Dating_APP.Service;
using Microsoft.EntityFrameworkCore;

namespace Dating_APP.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));

            });

            services.AddCors();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
