using IMuDB.API.Filters.ValidationFilters;
using IMuDB.Domain.DTOs.Genre.Request;
using IMuDB.Domain.DTOs.Genre.Response;
using IMuDB.Domain.Interfaces.Services.Genre;
using Microsoft.AspNetCore.Mvc;

namespace IMuDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController(ILogger<GenreController> logger, IGenreService genreService) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType<IEnumerable<GenreBaseResponse>>(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetGenresAsync()
        {
            try
            {
                IEnumerable<GenreBaseResponse> genres = await genreService.GetGenresAsync();
                return Ok(genres);
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
        public async Task<ActionResult> CreateGenreAsync([FromBody] GenreCreateRequest createGenreRequest)
        {
            try
            {
                GenreBaseResponse createdGenre = await genreService.CreateGenreAsync(createGenreRequest);
                return Created();
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{genreId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> DeleteGenreAsync([FromRoute] string genreId)
        {
            try
            {
                await genreService.DeleteGenreAsync(genreId);
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
