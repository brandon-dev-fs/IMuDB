using IMuDB.Domain.Interfaces.Repositories.Act;
using IMuDB.Domain.Interfaces.Repositories.Albums;
using IMuDB.Domain.Interfaces.Repositories.Genres;
using IMuDB.Domain.Interfaces.Repositories.Instruments;
using IMuDB.Domain.Interfaces.Repositories.Musician;
using IMuDB.Domain.Interfaces.Repositories.Songs;
using IMuDB.Domain.Interfaces.Repositories.Users;
using IMuDB.Infrastructure.Repositories.Acts;
using IMuDB.Infrastructure.Repositories.Albums;
using IMuDB.Infrastructure.Repositories.Genres;
using IMuDB.Infrastructure.Repositories.Instruments;
using IMuDB.Infrastructure.Repositories.Musicians;
using IMuDB.Infrastructure.Repositories.Songs;
using IMuDB.Infrastructure.Repositories.Users;
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

            services
                .AddScoped<IActRepository, ActRepository>()
                .AddScoped<IAlbumRepository, AlbumRepository>()
                .AddScoped<IMusicianRepository, MusicianRepository>()
                .AddScoped<IGenreRepository, GenreRepository>()
                .AddScoped<IInstrumentRepository, InstrumentRepository>()
                .AddScoped<ISongRepository, SongRepository>()
                .AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
