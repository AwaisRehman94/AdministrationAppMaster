using System;
using System.Collections.Generic;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class EsalRequest
{
    public int Id { get; set; }

    public string? RequestId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? ReferenceId { get; set; }

    public string? SupplierId { get; set; }

    public string? SequenceNumber { get; set; }

    public string? DriverNin { get; set; }

    public Guid? UserId { get; set; }

    public string? InvoiceType { get; set; }

    public string? InvoiceNumber { get; set; }

    public DateTime? InvoiceIssueDate { get; set; }

    public string? InvoiceReference { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? DateOfDelivery { get; set; }

    public string? Currency { get; set; }

    public bool? ExemptedAmount { get; set; }

    public bool? AmountNotSubjToTaxation { get; set; }

    public bool? SelfAccountForTax { get; set; }

    public decimal? TotalBeforeVat { get; set; }

    public decimal? TotalVat { get; set; }

    public decimal? GrandTotal { get; set; }

    public decimal? AdvanceAmount { get; set; }

    public decimal? OutstandingAmount { get; set; }

    public string? RemarksArabic { get; set; }

    public string? RemarksEnglish { get; set; }

    public string? NarrationArabic { get; set; }

    public string? NarrationEnglish { get; set; }

    public bool? MilestonePayments { get; set; }

    public int? PercentOfCompletion { get; set; }

    public string? ShipmentRefNumber { get; set; }

    public string? SalespersonEnglish { get; set; }

    public string? SalespersonArabic { get; set; }

    public bool? HasEsalInvoice { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
