
using Microsoft.AspNetCore.Http;

using AutoMapper;

using Common.Application.Common.Interfaces;

using Common.Domain.Models;

using Identity.Application.Common.Interfaces;


namespace Identity.Application.Middlewares
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IAuthorizationService _authorizationService, ITokenService _tokenService, IMapper _mapper)
        {
            //try to find "Bearer" from HTTP 'Authorization' Request Header. for example
            // Authorization Bearer "5t3RC6yNAKawSc1pgPrVWh2i57L50A7FfOkPPcGxEqbGYdlUpyF2Oc-zr-a2KVBtVBTg--iDRM0ejhYmuu1qbHvw49zEIwQ-Np_R6Ew_p2AJHfn6VF74AyfXeB8C3hzHV0fLBSfgJ6KlJGrxK7ueICuqjjUPZw2vqts3uL03f72RvTyVA2wJPZANWpUObMb7rk8uxPgE9-hwk0oGJd8zb6s7KybVxg6q9oackwLpi4HUeoqWBDBIEcXHrtDk41BeelfqkSuqiY0iRcsnklioANFmw00-6Hskwws-BMkqdX_QnVA4sZlu7bv5qhE4dvp6O-zGrjOXLxm-WevXJC4y9ZVri_wPFug5czwTyNeC9drISLJ9Vl971WIWuGcRPXjxBTem6A"
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var userId = _tokenService.ValidateToken(token);
            if (userId != null)
            {
                // attach user to context on successful jwt validation
                var result = await _authorizationService.GetUserByIdAsync(userId);
                if (result != null)
                {
                    context.Items["User"] = _mapper.Map<UserModel>(result);
                }
            }
            else
            {
                context.Items["User"] = null;
            }
            await _next(context);
        }
    }
}