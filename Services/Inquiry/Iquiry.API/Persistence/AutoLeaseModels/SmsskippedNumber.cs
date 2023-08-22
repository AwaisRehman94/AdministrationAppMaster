using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class SmsskippedNumber
{
    public int Id { get; set; }

    public string? PhoneNo { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UserId { get; set; }

    public string? CreatedBy { get; set; }
}
