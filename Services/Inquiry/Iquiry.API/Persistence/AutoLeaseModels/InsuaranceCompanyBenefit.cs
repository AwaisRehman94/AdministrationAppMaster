﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class InsuaranceCompanyBenefit
{
    public Guid BenefitId { get; set; }

    public int InsurnaceCompanyId { get; set; }

    public short BenefitCode { get; set; }

    public decimal BenefitPrice { get; set; }

    public virtual Benefit BenefitCodeNavigation { get; set; } = null!;

    public virtual InsuranceCompany InsurnaceCompany { get; set; } = null!;
}