using IMuDB.API.Filters.ValidationFilters;
using IMuDB.Domain.DTOs.Album.Request;
using IMuDB.Domain.DTOs.Album.Response;
using IMuDB.Domain.Interfaces.Services.Album;
using Microsoft.AspNetCore.Mvc;

namespace IMuDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController(ILogger<AlbumController> logger, IAlbumService albumService) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType<IEnumerable<AlbumBaseResponse>>(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetAlbumsAsync([FromQuery] string? actId)
        {
            try
            {
                IEnumerable<AlbumBaseResponse> albums = await (!string.IsNullOrEmpty(actId) ? albumService.GetAlbumsByMusicianAsync(actId) : albumService.GetAlbumsAsync());

                return Ok(albums);
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{albumId}", Name = "GetAlbumByIdAsync")]
        [ProducesResponseType<AlbumDetailsResponse>(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetAlbumByIdAsync([FromRoute] string albumId)
        {
            try
            {
                AlbumDetailsResponse? album = await albumService.GetAlbumByIdAsync(albumId);
                return Ok(album);
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [ModelValidationFilter]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateAlbumAsync([FromBody] AlbumCreateRequest createAlbumRequest)
        {
            try
            {
                AlbumDetailsResponse createdAlbum = await albumService.CreateAlbumAsync(createAlbumRequest);
                return CreatedAtRoute(nameof(GetAlbumByIdAsync), new { id = createdAlbum.Id?.ToString(), createdAlbum });
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{albumId}")]
        [ModelValidationFilter]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [AlbumUpdateRequestIdValidationFilter]
        public async Task<ActionResult> UpdateAlbumAsync([FromRoute] string albumId, [FromBody] AlbumUpdateRequest updateAlbumRequest)
        {
            try
            {
                await albumService.UpdateAlbumAsync(albumId, updateAlbumRequest);
                return NoContent();
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{albumId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> DeleteAlbumAsync([FromRoute] string albumId)
        {
            try
            {
                await albumService.DeleteAlbumAsync(albumId);
                return NoContent();
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
