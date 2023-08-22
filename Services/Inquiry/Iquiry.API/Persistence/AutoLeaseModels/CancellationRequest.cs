using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class CancellationRequest
{
    public int Id { get; set; }

    public string? ReferenceId { get; set; }

    public string? PolicyNo { get; set; }

    public DateTime? CancelDate { get; set; }

    public int? CancellationReasonCode { get; set; }

    public string? CancellationAttachment { get; set; }

    public string? UserName { get; set; }

    public bool? IsAutolease { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
