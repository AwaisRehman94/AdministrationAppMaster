using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class WataniyaDraftPolicy
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public Guid? UserId { get; set; }

    public string? UserName { get; set; }

    public string? Method { get; set; }

    public string? Channel { get; set; }

    public string? ReferenceId { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? QuotationNumber { get; set; }

    public string? PolicyNo { get; set; }

    public string? PolicyEffectiveDate { get; set; }

    public string? PolicyExpiryDate { get; set; }
}
