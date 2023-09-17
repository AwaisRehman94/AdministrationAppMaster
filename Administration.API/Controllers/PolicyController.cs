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

namespace Administration.API.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class PolicyController : BaseApiController
    {

        private readonly ILogger<PolicyController> _logger;
        public PolicyController(ILogger<PolicyController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "GetNajmStatus")]
        //[Authorize]
        public async Task<ActionResult<Result<List<GetNajmStatusResponse>>>> GetNajmStatus([FromBody]GetNajmStatusRequest request)
        {
            return await Mediator.Send(request);
        }

        [HttpPost(Name = "GetAllChannels")]
        public async Task<Result<List<GetAllChannelsResponse>>> GetAllChannels(GetAllChannelsRequest request)
        {

            return await Mediator.Send(request);

        }


        [HttpPost(Name = "GetNajmStatusByID_SP")]
        public async Task<ActionResult<Result<NajmStatus>>> GetNajmStatusByID_SP([FromBody] GetNajmStatusByID_SP_Request request)
        {
            return await Mediator.Send(request);
        }


        [HttpPost(Name = "GetNajmStatus_SP")]
        public async Task<ActionResult<Result<List<NajmStatus>>>> GetNajmStatus_SP([FromBody] GetNajmStatus_SP_Request request)
        {
            return await Mediator.Send(request);
        }


        //[Authorize]
        //[HttpGet(Name = "GetDeductibles")]
        //public async Task<ActionResult<Result<List<GetDeductiblesResponse>>>> GetDeductibles()
        //{
        //    return await Mediator.Send(new GetDeductiblesRequest());
        //}


    }
}
