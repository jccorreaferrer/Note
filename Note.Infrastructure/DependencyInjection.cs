using Note.Application.Interfaces.Repositories;
using Note.Application.Interfaces.Services;
using Note.Application.Services;
using Note.Infrastructure.Data;
using Note.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Note.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NoteDbContext>(options =>
                options.UseMySql(
                    configuration.GetConnectionString("DefaultConnection"),
                    //ServerVersion.AutoDetect(configuration.GetConnectionString("DefaultConnection"))));
                    new MariaDbServerVersion(new Version(11, 8, 8))));
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddScoped<INoteService, NoteService>();

            return services;
        }
    }
}
