using IMuDB.Domain.DTOs.Songs.Response;
using IMuDB.Domain.Interfaces.Services.Song;
using Microsoft.AspNetCore.Mvc;

namespace IMuDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController(ILogger<SongController> logger, ISongService songService) : ControllerBase
    {
        [HttpGet("{songId}")]
        [ProducesResponseType<SongDetailsResponse>(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetSongByIdAsync([FromRoute] string songId)
        {
            try
            {
                SongDetailsResponse? song = await songService.GetSongById(songId);
                return Ok(song);
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
