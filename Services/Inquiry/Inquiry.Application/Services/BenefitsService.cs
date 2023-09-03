
using AutoMapper;
using AutoMapper.QueryableExtensions;

using Common.Application.Common.Interfaces.Persistence;
using Common.Application.Common.Mappings;
using Common.Domain.DomainEntities.Entities.DomainEntities;
using Common.Domain.Entities;

using Inquiry.Application.Common.Interfaces;
using Inquiry.Application.Features.Lookups.Queries.GetBenefits;

namespace Inquiry.Application.Services
{
    public class BenefitsService : IBenefitsService
    {
        private readonly IRepository<AutoleasingBenefit> _repository;
        private readonly IMapper _mapper;
        public BenefitsService(IRepository<AutoleasingBenefit> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<GetBenefitResponse>> GetAllAsync(string language = "ar")
        {
            if (language == "en")
            {
                var _result = await _repository.TableNoTracking
                    .Select(
                    x => new GetBenefitResponse()
                    {
                        Id = Convert.ToInt32(x.Code),
                        Name = x.EnglishDescription,
                        ReadOnly = (x.Code == 1 || x.Code == 10) ? true : false
                    }
                    )
                    .ProjectTo<GetBenefitResponse>(_mapper.ConfigurationProvider)
                    .PaginatedListAsync(1, 1000);
                return _result.Items;
            }
            else
            {
                var _result = await _repository.TableNoTracking
                    .Select
                    (x => new GetBenefitResponse()
                    {
                        Id = Convert.ToInt32(x.Code),
                        Name = x.ArabicDescription,
                        ReadOnly = (x.Code == 1 || x.Code == 10) ? true : false
                    }
                    )
                    .ProjectTo<GetBenefitResponse>(_mapper.ConfigurationProvider)
                    .PaginatedListAsync(1, 1000);
                return _result.Items;
            }
        }
    }
}