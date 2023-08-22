using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class OtpInfo
{
    public int Id { get; set; }

    public Guid? UserId { get; set; }

    public string? UserEmail { get; set; }

    public int? VerificationCode { get; set; }

    public bool? IsCodeVerified { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Nin { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
