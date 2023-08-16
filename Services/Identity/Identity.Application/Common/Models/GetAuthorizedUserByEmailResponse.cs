

namespace Identity.Application.Common.Models
{
    public class GetAuthorizedUserByEmailResponse
    {
        public string Id { get; set; } = null!;
        public string? Email { get; set; }
    }
}