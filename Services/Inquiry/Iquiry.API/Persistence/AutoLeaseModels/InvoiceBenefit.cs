using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class InvoiceBenefit
{
    public int Id { get; set; }

    public int? InvoiceId { get; set; }

    public short? BenefitId { get; set; }

    public decimal? BenefitPrice { get; set; }

    public virtual Benefit? Benefit { get; set; }

    public virtual Invoice? Invoice { get; set; }
}
