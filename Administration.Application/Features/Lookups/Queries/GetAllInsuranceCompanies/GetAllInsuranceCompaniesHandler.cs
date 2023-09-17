using MediatR;
using AutoMapper;
using MediatR;

using Common.Domain.Common.Models;
using Administration.Application.Common.Interfaces;
using Administration.Application.Services;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus;

namespace Administration.Application.Features.Lookups.Queries.GetAllInsuranceCompanies
{
    public class GetAllInsuranceCompaniesHandler : IRequestHandler<GetAllInsuranceCompaniesRequest, Result<List<GetAllInsuranceCompaniesResponse>>>
    {
        private readonly IInsuranceCompanyService _insuranceCompanyService;
        private readonly IMapper _mapper;
        public GetAllInsuranceCompaniesHandler(IInsuranceCompanyService insuranceCompanyService, IMapper mapper)
        {

            _insuranceCompanyService = insuranceCompanyService;
            _mapper = mapper;
        }

        public async Task<Result<List<GetAllInsuranceCompaniesResponse>>> Handle(GetAllInsuranceCompaniesRequest request, CancellationToken cancellationToken)
        {
            Result<List<GetAllInsuranceCompaniesResponse>> result = new Result<List<GetAllInsuranceCompaniesResponse>>();
            result.ErrorDescription = "Success";
            result.ErrorCode = 1;

           result.Data = await _insuranceCompanyService.GetAllInsuranceCompanies(request.language);
            return result;
        }
    }
}
