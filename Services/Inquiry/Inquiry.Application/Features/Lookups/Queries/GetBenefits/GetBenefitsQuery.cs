
using AutoMapper;
using MediatR;

using Inquiry.Application.Common.Interfaces;
using Common.Application.Common.Models;

namespace Inquiry.Application.Features.Lookups.Queries.GetBenefits
{
    public class GetBenefitsRequest : IRequest<Result<List<GetBenefitResponse>>>
    {
        public string Language { get; set; }
    }

    public class GetBenefitsRequestHandler : IRequestHandler<GetBenefitsRequest, Result<List<GetBenefitResponse>>>
    {
        private readonly IBenefitsService _benefitsService;
        private readonly IMapper _mapper;
        public GetBenefitsRequestHandler(IBenefitsService benefitsService, IMapper mapper)
        {

            _benefitsService = benefitsService;
            _mapper = mapper;
        }

        public async Task<Result<List<GetBenefitResponse>>> Handle(GetBenefitsRequest request, CancellationToken cancellationToken)
        {
            Result<List<GetBenefitResponse>> result = new Result<List<GetBenefitResponse>>();
            result.ErrorDescription = "Success";
            result.ErrorCode = 1;

            result.Data = await _benefitsService.GetAllAsync(request.Language);
            return result;
        }
    }
}