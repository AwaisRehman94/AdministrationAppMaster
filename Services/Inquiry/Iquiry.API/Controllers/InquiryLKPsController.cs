
using Common.Application.Common.Models;
using Common.Application.Common.Security;
using Inquiry.Application.Features.Lookups.Queries.GetBenefits;
using Inquiry.Application.Features.Lookups.Queries.GetDeductibles;

using Microsoft.AspNetCore.Mvc;

namespace Tameenk.Autoleasing.InquiryAPI.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class InquiryLKPsController : BaseApiController
    {
        private readonly ILogger<InquiryLKPsController> _logger;
        public InquiryLKPsController(ILogger<InquiryLKPsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBenefits")]
        public async Task<ActionResult<Result<List<GetBenefitResponse>>>> GetBenefits(string language = "ar")
        {
            return await Mediator.Send(new GetBenefitsRequest() { Language = language });
        }

        [Authorize]
        [HttpGet(Name = "GetDeductibles")]
        public async Task<ActionResult<Result<List<GetDeductiblesResponse>>>> GetDeductibles()
        {
            return await Mediator.Send(new GetDeductiblesRequest());
        }
    }
}