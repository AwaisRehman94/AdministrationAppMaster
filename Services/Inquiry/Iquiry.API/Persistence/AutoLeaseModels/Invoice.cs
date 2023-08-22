using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class Invoice
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

    public bool? IsCancelled { get; set; }

    public DateTime? CancelationDate { get; set; }

    public string? CancelledBy { get; set; }

    public decimal? SpecialDiscount { get; set; }

    public decimal? SpecialDiscountPercentageValue { get; set; }

    public decimal? DiscountPercentageValue { get; set; }

    public decimal? LoyaltyDiscountValue { get; set; }

    public decimal? LoyaltyDiscountPercentage { get; set; }

    public decimal? SpecialDiscount2 { get; set; }

    public decimal? SpecialDiscount2PercentageValue { get; set; }

    public decimal? TotalBenefitPrice { get; set; }

    public decimal? TotalBcareCommission { get; set; }

    public decimal? TotalBcareFees { get; set; }

    public decimal? TotalCompanyAmount { get; set; }

    public decimal? ActualBankFees { get; set; }

    public string? FeesCalculationDetails { get; set; }

    public int? TemplateId { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public decimal? TotalBcareDiscount { get; set; }

    public string? TaxInvoiceNumber { get; set; }

    public decimal? TotalDiscount { get; set; }

    public string? Odreference { get; set; }

    public decimal? BasicPrice { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? MainPolicyReferance { get; set; }

    public virtual InsuranceCompany? InsuranceCompany { get; set; }

    public virtual ProductType? InsuranceTypeCodeNavigation { get; set; }

    public virtual ICollection<InvoiceBenefit> InvoiceBenefits { get; set; } = new List<InvoiceBenefit>();

    public virtual InvoiceFile? InvoiceFile { get; set; }

    public virtual Policy? Policy { get; set; }

    public virtual AspNetUser User { get; set; } = null!;
}
