using System;
using System.Collections.Generic;

namespace Tameenk.Autoleasing.InquiryAPI.Persistence.Models;

public partial class RenwalStatiticsOld
{
    public string? ParentExternalId { get; set; }

    public string? ParentReferenceId { get; set; }

    public string? ReferenceId { get; set; }

    public string? ExternalId { get; set; }

    public string? SequenceNumber { get; set; }

    public decimal? TotalPrice { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UserId { get; set; }

    public bool? IsDeleted { get; set; }
}
