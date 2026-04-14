using IMuDB.Domain.DTOs.Act.Request;
using IMuDB.Domain.DTOs.Act.Response;

namespace IMuDB.Domain.Interfaces.Services.Act
{
    public interface IActService
    {
        Task<IEnumerable<ActBaseResponse>> GetActsAsync();
        Task<ActDetailedResponse?> GetActByIdAsync(string actId);
        Task<ActDetailedResponse> CreateActAsync(ActCreateRequest createActRequest);
        Task UpdateActAsync(string actId, ActUpdateRequest updateActRequest);
        Task DeleteActAsync(string actId);
    }
}
