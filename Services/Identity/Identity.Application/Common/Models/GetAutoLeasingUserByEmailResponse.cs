
namespace Identity.Application.Common.Models
{
    public class GetAutoLeasingUserByEmailResponse
    {
        public string Id { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool? IsDeleted { get; set; }
        public string? PasswordHash { get; set; }

    }
}
