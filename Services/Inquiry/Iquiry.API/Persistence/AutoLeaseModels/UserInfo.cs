using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class UserInfo
{
    public int Id { get; set; }

    public string NationalId { get; set; } = null!;

    public string SequenceNumber { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public bool IsDriverExist { get; set; }

    public Guid? DriverId { get; set; }

    public bool IsVechileExist { get; set; }

    public Guid? VechileId { get; set; }

    public int? BirthDateMonth { get; set; }

    public int? BirthDateYear { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public bool IsActive { get; set; }

    public DateTime? OtpcreatedDate { get; set; }

    public int? Otp { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedAt { get; set; }

    public string? Hashed { get; set; }
}
