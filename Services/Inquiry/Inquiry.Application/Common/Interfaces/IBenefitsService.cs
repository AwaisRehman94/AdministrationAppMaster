
using Inquiry.Application.Features.Lookups.Queries.GetBenefits;

namespace Inquiry.Application.Common.Interfaces
{
    public interface IBenefitsService
    {
        public Task<List<GetBenefitResponse>> GetAllAsync(string language = "ar");
    }
}