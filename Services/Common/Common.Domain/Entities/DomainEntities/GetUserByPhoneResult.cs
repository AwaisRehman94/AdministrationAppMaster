﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Domain.DomainEntities.Entities.DomainEntities
{
    public partial class GetUserByPhoneResult
    {
        public string Id { get; set; }
        public Guid RoleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string DeviceToken { get; set; }
        public Guid LanguageId { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public int PromotionCodeCount { get; set; }
        public int PoliciesCount { get; set; }
        public string Channel { get; set; }
        public bool? IsAutoLeasing { get; set; }
        public int? AutoLeasingBankId { get; set; }
        public string AutoLeasingAdminId { get; set; }
        public bool? IsAutoLeasingSuperAdmin { get; set; }
        public bool? IsFirstLogin { get; set; }
        public bool? IsCorporateUser { get; set; }
        public string LockedBy { get; set; }
        public string LockedReason { get; set; }
        public bool? IsPhoneVerifiedByYakeen { get; set; }
        public string NationalId { get; set; }
        public bool? IsYakeenNationalIdVerified { get; set; }
        public int? OTP { get; set; }
        public DateTime? OTPExpirationDate { get; set; }
        public string ConcurrencyStamp { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public string NormalizedUserName { get; set; }
    }
}
