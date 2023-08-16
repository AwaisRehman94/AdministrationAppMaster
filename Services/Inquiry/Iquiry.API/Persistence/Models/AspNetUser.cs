using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public Guid RoleId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastModifiedDate { get; set; }

    public DateTime LastLoginDate { get; set; }

    public string? DeviceToken { get; set; }

    public Guid LanguageId { get; set; }

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string UserName { get; set; } = null!;

    public string? FullName { get; set; }

    public int PromotionCodeCount { get; set; }

    public int PoliciesCount { get; set; }

    public string? Channel { get; set; }

    public bool? IsAutoLeasing { get; set; }

    public int? AutoLeasingBankId { get; set; }

    public string? AutoLeasingAdminId { get; set; }

    public bool? IsAutoLeasingSuperAdmin { get; set; }

    public bool? IsFirstLogin { get; set; }

    public bool? IsCorporateUser { get; set; }

    public string? LockedBy { get; set; }

    public string? LockedReason { get; set; }

    public bool? IsPhoneVerifiedByYakeen { get; set; }

    public string? NationalId { get; set; }

    public bool? IsYakeenNationalIdVerified { get; set; }

    public int? Otp { get; set; }

    public DateTime? OtpexpirationDate { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public string? NormalizedEmail { get; set; }

    public string? NormalizedUserName { get; set; }

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; } = new List<AspNetUserToken>();

    public virtual ICollection<CheckoutDetail> CheckoutDetails { get; set; } = new List<CheckoutDetail>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual Language Language { get; set; } = null!;

    public virtual ICollection<PromotionProgramCode> PromotionProgramCodeCreators { get; set; } = new List<PromotionProgramCode>();

    public virtual ICollection<PromotionProgramCode> PromotionProgramCodeModifiers { get; set; } = new List<PromotionProgramCode>();

    public virtual ICollection<PromotionProgram> PromotionProgramCreatedByNavigations { get; set; } = new List<PromotionProgram>();

    public virtual ICollection<PromotionProgramDomain> PromotionProgramDomainCreatedByNavigations { get; set; } = new List<PromotionProgramDomain>();

    public virtual ICollection<PromotionProgramDomain> PromotionProgramDomainModifiedByNavigations { get; set; } = new List<PromotionProgramDomain>();

    public virtual ICollection<PromotionProgram> PromotionProgramModifiedByNavigations { get; set; } = new List<PromotionProgram>();

    public virtual ICollection<PromotionProgramUser> PromotionProgramUserCreatedByNavigations { get; set; } = new List<PromotionProgramUser>();

    public virtual ICollection<PromotionProgramUser> PromotionProgramUserModifiedByNavigations { get; set; } = new List<PromotionProgramUser>();

    public virtual ICollection<PromotionProgramUser> PromotionProgramUserUsers { get; set; } = new List<PromotionProgramUser>();

    public virtual ICollection<QuotationRequest> QuotationRequests { get; set; } = new List<QuotationRequest>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<UserPurchasedPromotionProgram> UserPurchasedPromotionPrograms { get; set; } = new List<UserPurchasedPromotionProgram>();
}
