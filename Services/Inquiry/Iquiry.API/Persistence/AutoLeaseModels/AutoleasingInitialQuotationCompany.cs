using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class AutoleasingInitialQuotationCompany
{
    public int Id { get; set; }

    public string ExternalId { get; set; } = null!;

    public int CompanyId { get; set; }

    public int BankId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }
}
