using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class CorporateUser
{
    public string UserId { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? UserName { get; set; }

    public int CorporateAccountId { get; set; }

    public string? PasswordHash { get; set; }

    public string? PhoneNumber { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsSuperAdmin { get; set; }

    public DateTime? NotificationDate { get; set; }
}
