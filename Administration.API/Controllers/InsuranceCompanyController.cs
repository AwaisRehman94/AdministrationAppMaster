using Common.Domain.Common.Models;
using Common.Application.Common.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus;
using Administration.Application.Features.Lookups.Queries.GetAllChannels;
using Azure.Core;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus_SP;
using Common.Domain.DomainEntities.Entities.DomainEntities;
using Administration.Application.Features.Lookups.Queries.GetNajmStatusByID_SP;
using Administration.Application.Features.Lookups.Queries.GetAllInsuranceCompanies;

namespace Administration.API.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class InsuranceCompanyController : BaseApiController
    {

        private readonly ILogger<InsuranceCompanyController> _logger;
        public InsuranceCompanyController(ILogger<InsuranceCompanyController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "GetAllInsuranceCompanies")]
       
        public async Task<ActionResult<Result<List<GetAllInsuranceCompaniesResponse>>>> GetAllInsuranceCompanies([FromBody]GetAllInsuranceCompaniesRequest request)
        {
            return await Mediator.Send(request);
        }

    }
}
