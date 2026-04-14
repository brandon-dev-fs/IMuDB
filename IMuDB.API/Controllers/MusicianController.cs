using IMuDB.Domain.DTOs.Musicians.Response;
using IMuDB.Domain.Interfaces.Services.Musician;
using Microsoft.AspNetCore.Mvc;

namespace IMuDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicianController(ILogger<MusicianController> logger, IMusicianService musicianService) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType<IEnumerable<MusicianBaseResponse>>(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetMusiciansAsync()
        {
            try
            {
                IEnumerable<MusicianBaseResponse> musicians = await musicianService.GetMusiciansAsync();
                return Ok(musicians);
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{musicianId}")]
        [ProducesResponseType<MusicianDetailsResponse>(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetMusicianByIdAsync([FromRoute] string musicianId)
        {
            try
            {
                MusicianDetailsResponse? musician = await musicianService.GetMusicianByIdAsync(musicianId);
                return Ok(musician);
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{musicianId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> DeleteMusicianAsync([FromRoute] string musicianId)
        {
            try
            {
                await musicianService.DeleteMusicianAsync(musicianId);
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
