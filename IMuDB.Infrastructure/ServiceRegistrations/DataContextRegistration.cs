using IMuDB.Domain.Interfaces.Repositories.Albums;
using IMuDB.Domain.Interfaces.Repositories.Artist;
using IMuDB.Domain.Interfaces.Repositories.Songs;
using IMuDB.Infrastructure;
using IMuDB.Infrastructure.Repositories.Albums;
using IMuDB.Infrastructure.Repositories.Artist;
using IMuDB.Infrastructure.Repositories.Songs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IMuDB.Infrastructure.ServiceRegistrations
{
    public static class DataContextRegistration
    {
        public static IServiceCollection AddDataContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("AlbumDBConnectionString"));
            });

            // services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services
                .AddScoped<IAlbumRepository, AlbumRepository>()
                .AddScoped<IArtistRepository, ArtistRepository>()
                .AddScoped<ISongRepository, SongRepository>();

            return services;
        }
    }
}
