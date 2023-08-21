//using Common.Application.Common.Interfaces;

//namespace Identity.API.Authorization
//{
//    public class JwtMiddleware
//    {
//        private readonly RequestDelegate _next;

//        public JwtMiddleware(RequestDelegate next)
//        {
//            _next = next;
//        }

//        public async Task Invoke(HttpContext context, ITokenService tokenService)
//        {
//            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
//            var userId = tokenService.ValidateToken(token);
//            if (userId != null)
//            {
//                Dictionary<string,string> keyValuePairs = new Dictionary<string,string>();
//                keyValuePairs.Add("current_user_id", userId);
//                context.Items["User"] = keyValuePairs;

//                // attach user to context on successful jwt validation
//                // context.Items["User"] = await _authorizationService.GetUserByIdAsync(userId);

//            }
//            else
//            {
//                context.Items["User"] = null;
//            }

//            await _next(context);
//        }
//    }
//}
