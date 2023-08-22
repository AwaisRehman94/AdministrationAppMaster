using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class AutoleasingDeductible
{
    public int Id { get; set; }

    public decimal? Value { get; set; }

    public bool? IsActive { get; set; }
}
