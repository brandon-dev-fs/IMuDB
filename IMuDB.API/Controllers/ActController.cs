using IMuDB.API.Filters.ValidationFilters;
using IMuDB.Domain.DTOs.Act.Request;
using IMuDB.Domain.DTOs.Act.Response;
using IMuDB.Domain.Interfaces.Services.Act;
using Microsoft.AspNetCore.Mvc;

namespace IMuDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActController(ILogger<ActController> logger, IActService actServices) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType<IEnumerable<ActBaseResponse>>(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetActsAsync()
        {
            try
            {
                IEnumerable<ActBaseResponse> act = await actServices.GetActsAsync();
                return Ok(act);
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{actId}", Name = "GetActByIdAsync")]
        [ProducesResponseType<ActDetailedResponse>(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetActByIdAsync([FromRoute] string actId)
        {
            try
            {
                ActDetailedResponse? act = await actServices.GetActByIdAsync(actId);

                if (act == null)
                {
                    return NotFound();
                }

                return Ok(act);
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
        public async Task<ActionResult> CreateActAsync([FromBody] ActCreateRequest createActRequest)
        {
            try
            {
                ActDetailedResponse createdAct = await actServices.CreateActAsync(createActRequest);
                return CreatedAtRoute(nameof(GetActByIdAsync), new { id = createdAct.Id?.ToString() }, createdAct);
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{actId}")]
        [ModelValidationFilter]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ActUpdateRequestIdValidationFilter]
        public async Task<ActionResult> UpdateActAsync([FromRoute] string actId, [FromBody] ActUpdateRequest updateActRequest)
        {
            try
            {
                await actServices.UpdateActAsync(actId, updateActRequest);
                return NoContent();
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{actId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> DeleteActAsync([FromRoute] string actId)
        {
            try
            {
                await actServices.DeleteActAsync(actId);
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
