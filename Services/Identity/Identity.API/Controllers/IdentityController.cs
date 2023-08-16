
using Identity.Application.Common.Exceptions;
using Identity.Application.Common.Models;
using Identity.Application.Features.Authorization.Queries;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<Result<LoginResponse>>> Login(LoginRequest login)
        {
            return await Mediator.Send(login);
        }
    }
}