
using Microsoft.AspNetCore.Mvc;


using Common.Domain.Common.Models;
using Common.Application.Common.Security;

using Identity.Application.Features.Authorization.Queries;

namespace Identity.API.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class IdentityController : BaseApiController
    {
        private readonly ILogger<IdentityController> _logger;
        public IdentityController(ILogger<IdentityController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Login")]
        [AllowAnonymous]
        public async Task<ActionResult<Result<LoginResponse>>> Login(LoginRequest login)
        {
            return await Mediator.Send(login);
        }

        [HttpGet(Name = "Demo")]
        [Authorize]
        public ActionResult<string> Demo()
        {
            var result = "sdfdsfsdf";
            return result;
        }
    }
}