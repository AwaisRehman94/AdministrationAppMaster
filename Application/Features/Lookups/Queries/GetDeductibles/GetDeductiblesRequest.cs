
using Microsoft.EntityFrameworkCore;
using Inquiry.Application.Common.Interfaces;

using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using GlobalCommon.Models;

namespace Inquiry.Application.Features.Lookups.Queries.GetDeductibles
{
    public class GetDeductiblesRequest : IRequest<Result<List<GetDeductiblesResponse>>>
    {
    }

    public class GetAutoleasingDeductiblesQueryHandler : IRequestHandler<GetDeductiblesRequest, Result<List<GetDeductiblesResponse>>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GetAutoleasingDeductiblesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<GetDeductiblesResponse>>> Handle(GetDeductiblesRequest request, CancellationToken cancellationToken)
        {
            Result<List<GetDeductiblesResponse>> result = new Result<List<GetDeductiblesResponse>>();



            //await _context.AutoleasingDeductibles.FromSql("GetAutoleasingCompaniesByUserId")

            result.Data = await _context.AutoleasingDeductibles.Where(x => x.IsActive == true).OrderBy(x => x.Value).Select(x => new GetDeductiblesResponse()
                {
                    Id = x.Id,
                    Value = x.Value.ToString(),
                }).ProjectTo<GetDeductiblesResponse>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            return result;

        }
    }
}
