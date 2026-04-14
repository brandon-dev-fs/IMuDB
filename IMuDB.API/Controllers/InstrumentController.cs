using IMuDB.API.Filters.ValidationFilters;
using IMuDB.Domain.DTOs.Instrument.Request;
using IMuDB.Domain.DTOs.Instrument.Response;
using IMuDB.Domain.Interfaces.Services.Instrument;
using Microsoft.AspNetCore.Mvc;

namespace IMuDB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentController(ILogger<InstrumentController> logger, IInstrumentService instrumentService) : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType<IEnumerable<string>>(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetInstrumentsAsync()
        {
            try
            {
                IEnumerable<InstrumentBaseResponse> instruments = await instrumentService.GetInstrumentsAsync();
                return Ok(instruments);
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
        public async Task<ActionResult> CreateInstrumentAsync([FromBody] InstrumentCreateRequest createInstrumentRequest)
        {
            try
            {
                InstrumentBaseResponse createdInstrument = await instrumentService.CreateInstrumentAsync(createInstrumentRequest);
                return Created();
            }
            catch (Exception ex)
            {
                logger.LogError("{Message}", ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{instrumentId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> DeleteInstrumentAsync([FromRoute] string instrumentId)
        {
            try
            {
                await instrumentService.DeleteInstrumentAsync(instrumentId);
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
