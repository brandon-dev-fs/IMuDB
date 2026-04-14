using IMuDB.Domain.DTOs.Instrument.Response;
using IMuDB.Domain.Entities.Instruments;

namespace IMuDB.Infrastructure.Extensions.Mapping.Instrument
{
    public static class InstrumentMappingExtensions
    {

        public static InstrumentBaseResponse ToBaseDto(this InstrumentEntity instrument)
        {
            return new InstrumentBaseResponse
            {
                Id = instrument.Id,
                Instrument = instrument.Instrument,
                UpdatedAt = instrument.UpdatedAt
            };
        }
    }
}
