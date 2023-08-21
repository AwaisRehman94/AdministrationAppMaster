
namespace Identity.Application.Features.Authorization.Queries
{
    public class LoginResponse
    {
        public string? VerificationCode { get; set; }
        public string? Token { get; set; }
    }
}