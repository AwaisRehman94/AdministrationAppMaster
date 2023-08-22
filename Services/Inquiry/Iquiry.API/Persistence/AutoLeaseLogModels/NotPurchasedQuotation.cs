using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class NotPurchasedQuotation
{
    public string ReferenceId { get; set; } = null!;

    public int InsuranceCompanyId { get; set; }

    public DateTime? CreateDateTime { get; set; }
}
