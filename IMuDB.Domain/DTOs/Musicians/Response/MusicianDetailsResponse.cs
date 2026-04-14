using IMuDB.Domain.DTOs.Instrument.Response;

namespace IMuDB.Domain.DTOs.Musicians.Response
{
    public class MusicianDetailsResponse : MusicianBaseResponse
    {
        public IEnumerable<InstrumentBaseResponse>? Instruments { get; set; }
    }
}
