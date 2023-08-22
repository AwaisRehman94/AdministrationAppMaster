using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Deductible
{
    public int Id { get; set; }

    public int InsuranceCompanyId { get; set; }

    public decimal Name { get; set; }

    public virtual InsuranceCompany InsuranceCompany { get; set; } = null!;
}
