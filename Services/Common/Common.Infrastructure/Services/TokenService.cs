
//using Microsoft.Extensions.Configuration;
//using Microsoft.IdentityModel.Tokens;

//using System.IdentityModel.Tokens.Jwt;

//using System.Security.Claims;
//using System.Text;

//using Common.Application.Common.Interfaces;

//namespace Common.Infrastructure.Services
//{
//    public class TokenService : ITokenService
//    {
//        private readonly IConfiguration _configuration;

//        public TokenService(IConfiguration configuration)
//        {
//            _configuration = configuration;
//        }

//        /// <summary>
//        /// generate token for given user
//        /// </summary>
//        /// <param name="userId"></param>
//        /// <returns></returns>
//        public string GenerateToken(string userId)
//        {
//            // generate token that is valid for 7 days
//            var tokenHandler = new JwtSecurityTokenHandler();
//            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("JWT:SecretKey").Value!);
//            var tokenDescriptor = new SecurityTokenDescriptor
//            {
//                Subject = new ClaimsIdentity(new[] { new Claim("current_user_id", userId) }),
//                Expires = DateTime.UtcNow.AddDays(7),
//                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
//            };
//            var token = tokenHandler.CreateToken(tokenDescriptor);
//            return tokenHandler.WriteToken(token);
//        }

//        /// <summary>
//        /// validate given token
//        /// </summary>
//        /// <param name="token">token to validate</param>
//        /// <returns></returns>
//        public string? ValidateToken(string? token)
//        {
//            if (token == null)
//                return null;

//            var tokenHandler = new JwtSecurityTokenHandler();
//            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("JWT:SecretKey").Value!);
//            try
//            {
//                tokenHandler.ValidateToken(token, new TokenValidationParameters
//                {
//                    ValidateIssuerSigningKey = true,
//                    IssuerSigningKey = new SymmetricSecurityKey(key),
//                    ValidateIssuer = false,
//                    ValidateAudience = false,
//                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
//                    ClockSkew = TimeSpan.Zero
//                }, out SecurityToken validatedToken);

//                var jwtToken = (JwtSecurityToken)validatedToken;
//                var userId = jwtToken.Claims.First(x => x.Type == "current_user_id").Value;

//                // return user id from JWT token if validation successful
//                return userId;
//            }
//            catch
//            {
//                // return null if validation fails
//                return null;
//            }
//        }
//    }
//}
