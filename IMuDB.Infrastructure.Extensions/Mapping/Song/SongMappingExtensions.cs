using IMuDB.Domain.DTOs.Act.Response;
using IMuDB.Domain.DTOs.Album.Response;
using IMuDB.Domain.DTOs.Songs.Response;
using IMuDB.Domain.Entities.Songs;
using IMuDB.Infrastructure.Extensions.Mapping.Genre;

namespace IMuDB.Infrastructure.Extensions.Mapping.Song
{
    public static class SongEntityExtensions
    {
        public static SongDetailsResponse ToDetailedDto(this SongEntity song)
        {
            return new SongDetailsResponse
            {
                Id = song.Id,
                Name = song.Name,
                Track = song.Track,
                Length = song.Length,
                Genre = song.Genre?.ToBaseDto() ?? null,
                Lyrics = song?.Lyrics ?? string.Empty,
                Album = new AlbumBaseResponse
                {
                    Id = song!.Album.Id,
                    Name = song.Album.Name,
                    Act = new ActBaseResponse
                    {
                        Id = song.Act!.Id,
                        Name = song.Act!.Name
                    },
                },
                UpdatedAt = song.UpdatedAt
            };
        }

        public static SongBaseResponse ToBaseDto(this SongEntity song)
        {
            return new SongBaseResponse
            {
                Id = song.Id,
                Name = song.Name,
                Track = song.Track,
                Length = song.Length,
                UpdatedAt = song.UpdatedAt
            };
        }
    }
}
