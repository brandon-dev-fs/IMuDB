using IMuDB.Domain.Entities.Acts;
using IMuDB.Domain.Entities.Instruments;

namespace IMuDB.Domain.Entities.Musicians
{
    public class MusicianEntity : BaseEntity
    {
        // Musician Attributes
        public string Name { get; set; } = string.Empty;
        // relationship 1-: Acts
        public ICollection<ActEntity> Acts { get; set; } = null!;

        // relationship 1-: Instruments
        public ICollection<InstrumentEntity>? Instruments { get; set; }

    }
}
