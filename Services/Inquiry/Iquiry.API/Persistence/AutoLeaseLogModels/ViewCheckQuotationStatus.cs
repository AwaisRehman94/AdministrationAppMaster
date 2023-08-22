using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class ViewCheckQuotationStatus
{
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ErrorCode { get; set; }
}
