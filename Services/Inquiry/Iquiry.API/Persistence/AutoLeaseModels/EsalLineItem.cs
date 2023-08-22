using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class EsalLineItem
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ReferenceId { get; set; }

    public long? SerialNumber { get; set; }

    public string? Code { get; set; }

    public string? DescriptionEnglish { get; set; }

    public string? DescriptionArabic { get; set; }

    public string? UomEnglish { get; set; }

    public string? UomArabic { get; set; }

    public decimal? Price { get; set; }

    public int? Quantity { get; set; }

    public decimal? Amount { get; set; }

    public decimal? DiscountPercent { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? AmountAfterDiscount { get; set; }

    public decimal? VatPercent { get; set; }

    public decimal? TotalVat { get; set; }

    public decimal? PriceAfterVat { get; set; }
}
