using IMuDB.Domain.Entities.Instruments;
using IMuDB.Domain.Interfaces.Repositories.Instruments;

namespace IMuDB.Infrastructure.Repositories.Instruments
{
    public class InstrumentRepository(DataContext context) : GenericRepository<InstrumentEntity>(context), IInstrumentRepository
    {
    }
}
