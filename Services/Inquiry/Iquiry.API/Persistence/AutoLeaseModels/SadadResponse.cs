using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class SadadResponse
{
    public int Id { get; set; }

    public int SadadRequestId { get; set; }

    public string Status { get; set; } = null!;

    public int ErrorCode { get; set; }

    public string Description { get; set; } = null!;

    public int TrackingId { get; set; }

    public virtual SadadRequest SadadRequest { get; set; } = null!;
}
