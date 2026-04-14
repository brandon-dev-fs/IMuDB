using IMuDB.Domain.DTOs.Instrument.Request;
using IMuDB.Domain.DTOs.Instrument.Response;

namespace IMuDB.Domain.Interfaces.Services.Instrument
{
    public interface IInstrumentService
    {
        Task<IEnumerable<InstrumentBaseResponse>> GetInstrumentsAsync();
        Task<InstrumentBaseResponse> CreateInstrumentAsync(InstrumentCreateRequest createInstrumentRequest);
        Task DeleteInstrumentAsync(string instrumentId);
    }
}
