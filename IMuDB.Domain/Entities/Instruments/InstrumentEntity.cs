using IMuDB.Domain.Entities.Musicians;

namespace IMuDB.Domain.Entities.Instruments
{
    public class InstrumentEntity : BaseEntity
    {
        // Instrument Attributes
        public string Instrument { get; set; } = string.Empty;
        // relationship 1-: Musicians
        public ICollection<MusicianEntity>? Musicians { get; set; }
    }
}
