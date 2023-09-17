using MediatR;
using AutoMapper;
using MediatR;

using Common.Domain.Common.Models;
using Administration.Application.Common.Interfaces;
using Administration.Application.Services;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus;
using Administration.Application.Features.Lookups.Queries.GetAllInsuranceCompanies;

namespace Administration.Application.Features.Lookups.Queries.GetAllProductTypes
{
    public class GetAllProductTypesHandler : IRequestHandler<GetAllProductTypesRequest, Result<List<GetAllProductTypesResponse>>>
    {
        private readonly IProductTypeService _productTypeService;
        private readonly IMapper _mapper;
        public GetAllProductTypesHandler(IProductTypeService productTypeService, IMapper mapper)
        {

            _productTypeService = productTypeService;
            _mapper = mapper;
        }

        public async Task<Result<List<GetAllProductTypesResponse>>> Handle(GetAllProductTypesRequest request, CancellationToken cancellationToken)
        {
            Result<List<GetAllProductTypesResponse>> result = new Result<List<GetAllProductTypesResponse>>();
            result.ErrorDescription = "Success";
            result.ErrorCode = 1;

            //result.Data = await _insuranceCompanyService.GetAllInsuranceCompanies(request.language);
            return result;
        }
    }
}
