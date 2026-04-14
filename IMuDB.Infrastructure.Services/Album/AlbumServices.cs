using IMuDB.Domain.DTOs.Album.Request;
using IMuDB.Domain.DTOs.Album.Response;
using IMuDB.Domain.DTOs.Songs.Request;
using IMuDB.Domain.Entities.Acts;
using IMuDB.Domain.Entities.Albums;
using IMuDB.Domain.Entities.Songs;
using IMuDB.Domain.Exceptions;
using IMuDB.Domain.Interfaces.Repositories.Act;
using IMuDB.Domain.Interfaces.Repositories.Albums;
using IMuDB.Domain.Interfaces.Repositories.Songs;
using IMuDB.Domain.Interfaces.Services.Album;
using IMuDB.Infrastructure.Extensions.Mapping.Album;

namespace IMuDB.Infrastructure.Services.Album
{
    public class AlbumServices(IAlbumRepository albumRepository,
            IActRepository actRepository, ISongRepository songRepository) : IAlbumService
    {
        /// <summary>
        /// Gets All Album entity intersected with Song and Act filtered by the Act's Id and cast to BaseDTO
        /// </summary>
        /// <param name="actId"></param>
        public async Task<IEnumerable<AlbumBaseResponse>> GetAlbumsByMusicianAsync(string actId)
        {
            IEnumerable<AlbumEntity>? actAlbums = await albumRepository.GetAllByMusicianAsync(actId);
            return actAlbums?.Select(_ => _.ToBaseDto()) ?? [];
        }

        /// <summary>
        /// Gets All Album entities intersected with Songs and Musician and cast to BaseDTO
        /// </summary>
        public async Task<IEnumerable<AlbumBaseResponse>> GetAlbumsAsync()
        {
            IEnumerable<AlbumEntity>? albums = await albumRepository.GetAllAlbumsAsync();
            return albums?.Select(_ => _.ToBaseDto()) ?? [];
        }

        /// <summary>
        /// Gets a single Album entity intersected with Songs and Musician filtered by Id and cast to DetailedDto
        /// </summary>
        /// <param name="Id"></param>
        /// <exception cref="Exception"></exception>
        public async Task<AlbumDetailsResponse?> GetAlbumByIdAsync(string Id)
        {
            AlbumEntity? album = await albumRepository.GetAlbumByIdAsync(Id);
            return album?.ToDetailedDto();
        }

        /// <summary>
        /// Creates a new album after first checking the artist exist and that the artist does not have an album by the same name
        /// </summary>
        /// <param name="data"></param>
        /// <exception cref="MissingSongsException"></exception>
        /// <exception cref="Exception"></exception>
        public async Task<AlbumDetailsResponse> CreateAlbumAsync(AlbumCreateRequest createAlbumRequest)
        {
            if (createAlbumRequest?.CreateSong?.Count() <= 0 && createAlbumRequest?.UpdateSong?.Count() <= 0)
            {
                throw new MissingSongsException("Album must include songs");
            }

            if (await albumRepository.UniqueAlbumCheckAsync(createAlbumRequest!.Name, createAlbumRequest.ActId) != null)
            {
                throw new Exception($"Album with {createAlbumRequest.Name} by artist {createAlbumRequest.ActId} already exists");
            }

            ActEntity act = await actRepository.GetActByIdAsync(createAlbumRequest.ActId.ToString()) ?? throw new Exception($"Musician with Id:{createAlbumRequest.ActId} does not exist. Cannot create an album without an album.");

            List<SongEntity> albumSongs = [];

            if (createAlbumRequest?.UpdateSong != null && createAlbumRequest?.UpdateSong.Count() > 0)
            {
                foreach (SongUpdateRequest Song in createAlbumRequest.UpdateSong)
                {
                    SongEntity musicianEntity = await songRepository.GetByIdAsync(Song.Id) ?? throw new Exception($"Song with id: ${Song?.Id} does not exist");
                    albumSongs.Add(musicianEntity);
                }
            }

            if (createAlbumRequest?.CreateSong != null && createAlbumRequest?.CreateSong.Count() > 0)
            {
                foreach (SongCreateRequest Song in createAlbumRequest.CreateSong)
                {
                    albumSongs.Add(new SongEntity
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = Song.Name,
                        Track = Song.Track,
                        Length = Song.Length,
                        Act = act,
                        IsActive = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    });
                }
            }

            AlbumEntity newAlbum = new()
            {
                Id = Guid.NewGuid().ToString(),
                Name = createAlbumRequest!.Name,
                Act = act,
                Songs = albumSongs,
                Year = createAlbumRequest.Year,
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            return (await albumRepository.AddEntityAsync(newAlbum)).ToDetailedDto();
        }

        /// <summary>
        /// Finds Album entity by id updates ImageUrl, Name, Year
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="data"></param>
        /// <exception cref="Exception"></exception>
        public async Task UpdateAlbumAsync(string albumId, AlbumUpdateRequest updateAlbumRequest)
        {
            AlbumEntity updateAlbum = await albumRepository.GetByIdAsync(albumId) ?? throw new Exception($"Album with Id:{albumId} could not be found");

            updateAlbum.ImageUrl = updateAlbumRequest.ImageUrl;
            updateAlbum.UpdatedAt = DateTime.UtcNow;

            await albumRepository.UpdateEntityAsync(updateAlbum);
        }

        /// <summary>
        /// Finds Album entity by id sets active flag to false
        /// </summary>
        /// <param name="Id"></param>
        /// <exception cref="Exception"></exception>
        public async Task DeleteAlbumAsync(string albumId)
        {
            AlbumEntity deleteAlbum = await albumRepository.GetByIdAsync(albumId) ?? throw new Exception($"Album with Id:{albumId} could not be found");

            deleteAlbum.IsActive = false;
            deleteAlbum.UpdatedAt = DateTime.UtcNow;

            await albumRepository.UpdateEntityAsync(deleteAlbum);
        }
    }
}
