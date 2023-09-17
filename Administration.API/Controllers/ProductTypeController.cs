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
using Administration.Application.Features.Lookups.Queries.GetAllProductTypes;

namespace Administration.API.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class ProductTypeController : BaseApiController
    {

        private readonly ILogger<ProductTypeController> _logger;
        public ProductTypeController(ILogger<ProductTypeController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "GetAllProductTypes")]
       
        public async Task<ActionResult<Result<List<GetAllProductTypesResponse>>>> GetAllProductTypes([FromBody] GetAllProductTypesRequest request)
        {
            return await Mediator.Send(request);
        }

    }
}
