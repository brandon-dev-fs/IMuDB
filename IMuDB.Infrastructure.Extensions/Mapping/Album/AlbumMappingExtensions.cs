using IMuDB.Domain.DTOs.Album.Response;
using IMuDB.Domain.Entities.Albums;
using IMuDB.Infrastructure.Extensions.Mapping.Act;
using IMuDB.Infrastructure.Extensions.Mapping.Song;

namespace IMuDB.Infrastructure.Extensions.Mapping.Album
{
    public static class AlbumEntityExtensions
    {
        public static AlbumDetailsResponse ToDetailedDto(this AlbumEntity album)
        {
            return new AlbumDetailsResponse
            {
                Id = album.Id,
                Name = album.Name,
                ImageUrl = album.ImageUrl,
                Year = album.Year,
                Act = album.Act.ToBaseResponseDto(),
                Songs = album.Songs.Select(_ => _.ToBaseDto()),
            };
        }

        public static AlbumBaseResponse ToBaseDto(this AlbumEntity album)
        {
            return new AlbumBaseResponse
            {
                Id = album.Id,
                Name = album.Name,
                ImageUrl = album.ImageUrl,
                Year = album.Year,
                Act = album.Act.ToBaseResponseDto(),
                UpdatedAt = album.UpdatedAt,
            };
        }
    }
}
