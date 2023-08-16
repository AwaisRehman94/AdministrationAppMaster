
using Inquiry.Application.Features.Lookups.Queries.GetDeductibles;

namespace Inquiry.Application.Common.Interfaces
{
    public interface IDeductibleService
    {
        Task<List<GetDeductiblesResponse>> GetAllAsync();
    }
}