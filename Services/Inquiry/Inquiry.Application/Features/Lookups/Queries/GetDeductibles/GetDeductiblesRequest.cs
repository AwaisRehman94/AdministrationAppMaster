
using AutoMapper;
using MediatR;

using Inquiry.Application.Common.Interfaces;
using GlobalCommon.Application.Common.Models;

namespace Inquiry.Application.Features.Lookups.Queries.GetDeductibles
{
    public class GetDeductiblesRequest : IRequest<Result<List<GetDeductiblesResponse>>>
    {
    }

    public class GetAutoleasingDeductiblesQueryHandler : IRequestHandler<GetDeductiblesRequest, Result<List<GetDeductiblesResponse>>>
    {
        private readonly IDeductibleService _deductibleService;
        private readonly IMapper _mapper;
        public GetAutoleasingDeductiblesQueryHandler(IDeductibleService deductibleService, IMapper mapper)
        {
            _deductibleService = deductibleService;
            _mapper = mapper;
        }

        public async Task<Result<List<GetDeductiblesResponse>>> Handle(GetDeductiblesRequest request, CancellationToken cancellationToken)
        {
            //await _context.AutoleasingDeductibles.FromSql("GetAutoleasingCompaniesByUserId")
            Result<List<GetDeductiblesResponse>> result = new Result<List<GetDeductiblesResponse>>();
            result.ErrorDescription = "Success";
            result.ErrorCode = 1;
            var deductables = await _deductibleService.GetAllAsync();

            result.Data = deductables;
            return result;
        }
    }
}