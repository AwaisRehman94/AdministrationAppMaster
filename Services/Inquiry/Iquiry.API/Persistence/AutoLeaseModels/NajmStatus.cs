using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class NajmStatus
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? NameEn { get; set; }

    public string? NameAr { get; set; }

    public virtual ICollection<Policy> Policies { get; set; } = new List<Policy>();
}
