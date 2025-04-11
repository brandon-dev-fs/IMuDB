using IMuDB.Domain.DTOs.Return.Album;
using IMuDB.Domain.DTOs.Return.Artists;
using IMuDB.Domain.DTOs.Return.Songs;
using IMuDB.Domain.Entities.Songs;

namespace IMuDB.Infrastructure.Extensions
{
    public static class SongEntityExtensions
    {
        public static SongDetails ToDetailedDto(this SongEntity song)
        {
            return new SongDetails
            {
                Id = song.Id,
                Name = song.Name,
                Track = song.Track,
                Length = song.Length,
                Genre = song.Genre ?? string.Empty,
                Lyrics = song.Lyrics ?? string.Empty,
                Album = new AlbumBase
                {
                    Id = song.Album?.Id,
                    Name = song.Album.Name,
                    Artist = new ArtistBase
                    {
                        Id = song.Artist?.Id,
                        Name = song.Artist.Name,
                        Musicians = song.Artist.Musicians ?? new List<string>()
                    },
                },
                UpdatedAt = song.UpdatedAt
            };
        }

        public static SongBase ToBaseDto(this SongEntity song)
        {
            return new SongBase
            {
                Id = song.Id,
                Name = song.Name,
                Track = song.Track,
                Length = song.Length
            };
        }
    }
}
