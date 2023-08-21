
using AutoMapper;
using AutoMapper.QueryableExtensions;

using Inquiry.Application.Common.Interfaces;
using Inquiry.Application.Features.Lookups.Queries.GetDeductibles;

using Common.Application.Common.Interfaces.Persistence;
using Common.Application.Common.Mappings;
using Common.Domain.Entities;

namespace Inquiry.Application.Services
{
    public class DeductibleService : IDeductibleService
    {
        private readonly IRepository<AutoleasingDeductible> _repository;
        private readonly IMapper _mapper;
        public DeductibleService(IRepository<AutoleasingDeductible> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetDeductiblesResponse>> GetAllAsync()
        {
            var deducables = await _repository.TableNoTracking
                .Where(x => x.IsActive == true)
                .OrderBy(x => x.Value)
                .Select(x => new GetDeductiblesResponse()
                {
                    Id = x.Id,
                    Value = x.Value.ToString(),
                }).ProjectTo<GetDeductiblesResponse>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(1, 1000);
            return deducables.Items;
        }
    }
}