using IMuDB.Domain.Interfaces.Services.Album;
using IMuDB.Domain.Interfaces.Services.Artist;
using IMuDB.Domain.Interfaces.Services.Song;
using IMuDB.Infrastructure.Services.Album;
using IMuDB.Infrastructure.Services.Artist;
using IMuDB.Infrastructure.Services.Song;
using Microsoft.Extensions.DependencyInjection;

namespace IMuDB.Infrastructure.Services.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services
                .AddScoped<IAlbumService, AlbumServices>()
                .AddScoped<IArtistService, ArtistServices>()
                .AddScoped<ISongService, SongServices>();
            return services;
        }
    }
}
