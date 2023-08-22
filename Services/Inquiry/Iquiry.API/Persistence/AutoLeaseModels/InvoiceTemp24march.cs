using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class InvoiceTemp24march
{
    public int Id { get; set; }

    public int InvoiceNo { get; set; }

    public DateTime InvoiceDate { get; set; }

    public DateTime InvoiceDueDate { get; set; }

    public string UserId { get; set; } = null!;

    public string? ReferenceId { get; set; }

    public short? InsuranceTypeCode { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public int? PolicyId { get; set; }

    public decimal? ProductPrice { get; set; }

    public decimal? Fees { get; set; }

    public decimal? Vat { get; set; }

    public decimal? SubTotalPrice { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? ExtraPremiumPrice { get; set; }

    public decimal? Discount { get; set; }
}
