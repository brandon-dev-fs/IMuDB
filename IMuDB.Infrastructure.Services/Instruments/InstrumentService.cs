using IMuDB.Domain.DTOs.Instrument.Request;
using IMuDB.Domain.DTOs.Instrument.Response;
using IMuDB.Domain.Entities.Instruments;
using IMuDB.Domain.Interfaces.Repositories.Instruments;
using IMuDB.Domain.Interfaces.Services.Instrument;
using IMuDB.Infrastructure.Extensions.Mapping.Instrument;

namespace IMuDB.Infrastructure.Services.Instruments
{
    public class InstrumentService(IInstrumentRepository instrumentRepository) : IInstrumentService
    {
        public async Task<IEnumerable<InstrumentBaseResponse>> GetInstrumentsAsync()
        {
            IEnumerable<InstrumentEntity> instruments = await instrumentRepository.GetAllAsync();
            return instruments.Select(_ => _.ToBaseDto()) ?? [];
        }

        public async Task<InstrumentBaseResponse> CreateInstrumentAsync(InstrumentCreateRequest createInstrumentRequest)
        {
            InstrumentEntity newInstrument = await instrumentRepository.AddEntityAsync(new InstrumentEntity
            {
                Id = Guid.NewGuid().ToString(),
                Instrument = createInstrumentRequest.Instrument,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            });

            return newInstrument.ToBaseDto();
        }

        public async Task DeleteInstrumentAsync(string instrumentId)
        {
            InstrumentEntity instrument = await instrumentRepository.GetByIdAsync(instrumentId) ?? throw new Exception($"Could not find Instrument with Id: {instrumentId}");

            instrument.IsActive = false;
            instrument.UpdatedAt = DateTime.UtcNow;

            await instrumentRepository.UpdateEntityAsync(instrument);
        }
    }
}
