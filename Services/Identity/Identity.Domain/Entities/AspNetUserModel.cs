
namespace Identity.Domain.Entities
{
    public class AspNetUserModel: BaseEntity
    {
        public string Id { get; set; } = null!;

        public string? UserName { get; set; }

        public string? NormalizedUserName { get; set; }

        public string? Email { get; set; }

        public string? NormalizedEmail { get; set; }
    }
}