﻿using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class EndorsmentBenefit
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ReferenceId { get; set; }

    public int? EndorsmentId { get; set; }

    public string? QuotationReferenceId { get; set; }

    public string? BenefitId { get; set; }
}