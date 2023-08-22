using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class DeservingDiscount
{
    public int Id { get; set; }

    public string? NationalId { get; set; }

    public string? Name { get; set; }

    public string? Mobile { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedDate { get; set; }
}
