using IMuDB.Domain.Interfaces.Services.Act;
using IMuDB.Domain.Interfaces.Services.Album;
using IMuDB.Domain.Interfaces.Services.Instrument;
using IMuDB.Domain.Interfaces.Services.Musician;
using IMuDB.Domain.Interfaces.Services.Song;
using IMuDB.Infrastructure.Services.Act;
using IMuDB.Infrastructure.Services.Album;
using IMuDB.Infrastructure.Services.Instruments;
using IMuDB.Infrastructure.Services.Musician;
using IMuDB.Infrastructure.Services.Song;
using Microsoft.Extensions.DependencyInjection;

namespace IMuDB.Infrastructure.Services.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services
                .AddScoped<IActService, ActService>()
                .AddScoped<IMusicianService, MusicianServices>()
                .AddScoped<IInstrumentService, InstrumentService>()
                .AddScoped<IAlbumService, AlbumServices>()
                .AddScoped<ISongService, SongServices>();
            return services;
        }
    }
}
