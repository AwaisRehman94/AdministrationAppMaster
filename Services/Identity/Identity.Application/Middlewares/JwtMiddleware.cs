
using Microsoft.AspNetCore.Http;

using Common.Application.Common.Interfaces;
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

        public async Task Invoke(HttpContext context, IAuthorizationService _authorizationService, ITokenService tokenService)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var userId = tokenService.ValidateToken(token);
            if (userId != null)
            {
                // attach user to context on successful jwt validation
                context.Items["User"] = await _authorizationService.GetUserByIdAsync(userId);

            }
            else
            {
                context.Items["User"] = null;
            }

            await _next(context);
        }
    }
}