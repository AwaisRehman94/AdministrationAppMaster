﻿
namespace Identity.Domain.Entities
{
    public class AutoleasingUser: BaseEntity
    {
        public string Id { get; set; } = null!;

        public string? UserId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public string? Email { get; set; }

        public string? PasswordHash { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool? LockoutEnabled { get; set; }

        public string? UserName { get; set; }

        public string? FullName { get; set; }

        public int? BankId { get; set; }

        public string? BankName { get; set; }

        public string? AdminId { get; set; }

        public bool? IsSuperAdmin { get; set; }

        public bool? IsFirstLogin { get; set; }

        public string? City { get; set; }

        public string? Region { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? DeletedDate { get; set; }

        public string? CreatedBy { get; set; }

        public string? ModifiedBy { get; set; }

        public long? CityCode { get; set; }

        public bool CanPurchase { get; set; }
    }
}