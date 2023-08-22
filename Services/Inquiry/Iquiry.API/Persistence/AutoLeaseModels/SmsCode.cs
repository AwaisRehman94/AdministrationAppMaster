using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class SmsCode
{
    public int Id { get; set; }

    public string Mobile { get; set; } = null!;

    public string Code { get; set; } = null!;

    public bool IsVerified { get; set; }

    public DateTime? CreatedDate { get; set; }
}
